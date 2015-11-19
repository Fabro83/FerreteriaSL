using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Clases_Genericas
{
    public class Impresion
    {
        private PrintDocument _printDocument = new PrintDocument();
        private Dictionary<string, object> _printingFieldsDictionary;
        private List<Dictionary<string, object>> _printingGridList; 
        private int _totalPages,_currentPage;
        private ModelPage _pageModel;

        public Impresion(Dictionary<string, object> printingFields,List<Dictionary<string,object>> printingGrid ,string documentType)
        {
            _printingFieldsDictionary = printingFields;
            _pageModel = new ModelPage(documentType);
            _printingGridList = printingGrid;
            var pageSize = new PointF(_printDocument.DefaultPageSettings.Bounds.Size.Width, _printDocument.DefaultPageSettings.Bounds.Size.Height);
            _pageModel.TranslateRectangles(pageSize);
            _totalPages = CalculatePages();
            _printDocument.PrintPage += OnPrint;
        }

        public void StartPrinting()
        {
            _currentPage = 0;
            _printDocument.Print();
        }

        private void OnPrint(object sender, PrintPageEventArgs e)
        {
            _pageModel = new ModelPage("facturaA");

            PrinterResolution printerResolution = new PrinterResolution
            {
                X = 600,
                Y = 600,
                Kind = PrinterResolutionKind.Custom
            };
            e.PageSettings.PrinterResolution = printerResolution;


            var pageSize = new PointF(e.PageSettings.PrintableArea.Width - e.MarginBounds.X, e.PageSettings.PrintableArea.Height - e.MarginBounds.Y);
            _pageModel.TranslateRectangles(pageSize);
            foreach (KeyValuePair<string, object> fieldValue in _printingFieldsDictionary)
            {
                using (PrintField fieldParameters = _pageModel.Fields[fieldValue.Key])
                {
                    fieldParameters.CalculateFontSize(fieldValue.Value.ToString(), e);
                    fieldParameters.CenterText(fieldValue.Value.ToString(), e);
                    e.Graphics.DrawString(fieldValue.Value.ToString(), fieldParameters.CalculatedFont, Brushes.Black, fieldParameters.CenteredPosX, fieldParameters.CenteredPosY);                
                }
            }

            for (int i = 0; i < _printingGridList.Count; i++)
            {
                foreach (KeyValuePair<string, object> fieldValue in _printingGridList[i])
                {
                    using (PrintField fieldParameters = _pageModel.Fields["grid_"+fieldValue.Key.ToLower()])
                    {
                        if (fieldValue.Key.ToLower() != "descripcion")
                        {
                            fieldParameters.CalculateFontSize(fieldValue.Value.ToString(), e);
                            fieldParameters.CenterText(fieldValue.Value.ToString(), e);
                            e.Graphics.DrawString(fieldValue.Value.ToString(), fieldParameters.CalculatedFont, Brushes.Black, fieldParameters.CenteredPosX, fieldParameters.CenteredPosY + (fieldParameters.Height + fieldParameters.VerticalMargin * 2) * i);
                        }
                        else
                        {
                            fieldParameters.CalculateFontSize(fieldValue.Value.ToString(),e);
                            fieldParameters.CenterText(fieldValue.Value.ToString(), e, false);
                            e.Graphics.DrawString(fieldValue.Value.ToString(), fieldParameters.CalculatedFont, Brushes.Black, fieldParameters.CenteredPosX, fieldParameters.CenteredPosY + (fieldParameters.Height + fieldParameters.VerticalMargin*2) * i);
                        }


                    }
                }
            }

        }

        private int CalculatePages()
        {
            decimal r = _printingGridList.Count/_pageModel.GridRows;
            return int.Parse(Math.Floor(r).ToString(CultureInfo.InvariantCulture));
        }

    }

    public class ModelPage
    {
        PointF _modelPageSize;
        public int GridRows { get; private set; }
        Dictionary<string, PrintField> _fields = new Dictionary<string, PrintField>();

        public Dictionary<string, PrintField> Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }

        public ModelPage(string documentType)
        {
            Bd db = new Bd();
            DataTable dt = db.Read("SELECT * FROM print_page WHERE scope = '"+documentType+"'");

            _modelPageSize = new PointF(float.Parse(dt.Rows[0]["model_page_width"].ToString()), float.Parse(dt.Rows[0]["model_page_height"].ToString()));
            GridRows = int.Parse(dt.Rows[0]["grid_rows"].ToString());

            dt = db.Read("SELECT * FROM print_field WHERE scope = 'facturaA'");
            foreach (DataRow sRow in dt.Rows)
            {

                PrintField pf = new PrintField();
                pf.Field = sRow["field"].ToString();
                pf.DefaultValue = sRow["default_string"].ToString();
                pf.FontFamily = sRow["font_family"].ToString();
                pf.X = float.Parse(sRow["pos_x"].ToString());
                pf.Y = float.Parse(sRow["pos_y"].ToString());
                pf.Width = float.Parse(sRow["size_width"].ToString());
                pf.Height = float.Parse(sRow["size_height"].ToString());
                pf.HorizontalMargin = float.Parse(sRow["margin_horizontal"].ToString());
                pf.VerticalMargin = float.Parse(sRow["margin_vertical"].ToString());
                pf.FontSize = float.Parse(sRow["font_size"].ToString());
                _fields.Add(pf.Field, pf);
            }
            dt.Dispose();
            db.CloseConnection();
        }

        public void TranslateRectangles(PointF actualPageSize)
        {
            foreach (PrintField pf in _fields.Values)
            {
                pf.X = (actualPageSize.X * pf.X) / _modelPageSize.X;
                pf.Y = (actualPageSize.Y * pf.Y) / _modelPageSize.Y;
                pf.Width = (actualPageSize.X * pf.Width) / _modelPageSize.X;
                pf.Height = (actualPageSize.Y * pf.Height) / _modelPageSize.Y;
            }

            GridRows = int.Parse((Math.Floor(_fields["grid_height"].Height / (_fields["grid_cantidad"].Height + _fields["grid_cantidad"].VerticalMargin))).ToString(CultureInfo.InvariantCulture));

        }
    }

    public class PrintField : IDisposable
    {
        float _fontSize;
        string _fontFamily;

        #region Properties
        public Font CalculatedFont { get; set; }
        public float CenteredPosX { get; set; }
        public float CenteredPosY { get; set; }
        public Font FieldFont { get; set; }      
        public float HorizontalMargin { get; set; }
        public float VerticalMargin { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Y { get; set; }
        public float X { get; set; }
        public string Field { get; set; }
        public string DefaultValue { get; set; }

        public float FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                UpdateFont();
            }
        }

        public string FontFamily
        {
            get { return _fontFamily; }
            set
            {
                _fontFamily = value;
                UpdateFont();
            }
        }
        #endregion

        #region Methods
        public void CenterText(string text, PrintPageEventArgs printer, bool horizontal = true, bool vertical = true)
        {
            Font fontToTest = CalculatedFont ?? FieldFont;

            SizeF textSize = printer.Graphics.MeasureString(text, fontToTest);
            if (horizontal)
                CenteredPosX = X + (Width/2) - ((textSize.Width - HorizontalMargin)/2);
            else
                CenteredPosX = X;

            if (vertical) 
                CenteredPosY = Y + (Height / 2) - ((textSize.Height - VerticalMargin) / 2);
            else
                CenteredPosY = Y;

        }

        public void CalculateFontSize(string text, PrintPageEventArgs printer)
        {
            SizeF textSize = printer.Graphics.MeasureString(text, FieldFont);
            Font testFont = FieldFont;

            if (textSize.Width < Width || textSize.Height < Height)
            {
                for (float i = testFont.Size; i > 1; i-=0.3F)
                {
                    testFont = new Font(testFont.FontFamily, i);
                    textSize = printer.Graphics.MeasureString(text, testFont);
                    if (textSize.Width < Width && textSize.Height < Height) break;
                }
            }
            CalculatedFont = testFont;

        }

        private void UpdateFont()
        {
            FieldFont = new Font(_fontFamily, _fontSize > 0 ? _fontSize : 10);
        }

        public void Dispose()
        {
            // IMPLEMENTAR CORRECTAMENTE
        }

        #endregion

    }
}