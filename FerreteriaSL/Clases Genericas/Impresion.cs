using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using FerreteriaSL.Clases_Base_de_Datos;
using Microsoft.Office.Interop.Excel;
using Net.SourceForge.Koogra.Excel.ValueTypes;
using Net.SourceForge.Koogra.Storage;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;

namespace FerreteriaSL.Clases_Genericas
{
    public class Impresion
    {
        private readonly PrintDocument _printDocument = new PrintDocument();
        private readonly Dictionary<string, object> _printingFieldsDictionary;
        private readonly List<Dictionary<string, object>> _printingGridList; 
        private int _totalPages,_currentPage;
        private readonly ModelPage _pageModel;

        public Impresion(Dictionary<string, object> printingFields,List<Dictionary<string,object>> printingGrid ,int documentType, short copies = 1)
        {
            _printingFieldsDictionary = printingFields;
            _pageModel = new ModelPage(documentType);
            _printingGridList = printingGrid;
            var pageSize = new PointF(_printDocument.DefaultPageSettings.PaperSize.Width,
                                      _printDocument.DefaultPageSettings.PaperSize.Height);
            _pageModel.TranslateRectangles(pageSize);
            _totalPages = CalculatePages();
            _printDocument.PrinterSettings.Copies = copies;
            _printDocument.PrintPage += OnPrint;
        }

        public void StartPrinting()
        {
            _currentPage = 0;
            _printDocument.Print();
        }

        private void OnPrint(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Margins.Top = 0;
            e.PageSettings.Margins.Left = 0;
            e.PageSettings.Margins.Bottom = 0;
            e.PageSettings.Margins.Right = 0;
            e.PageSettings.Landscape = false;
            
            e.PageSettings.PrinterResolution = new PrinterResolution
            {
                X = 600,
                Y = 600,
                Kind = PrinterResolutionKind.Custom
            };

            var hmx = (e.PageSettings.HardMarginX / 100) * 96;
            var hmy = (e.PageSettings.HardMarginY / 100) * 96;

            foreach (KeyValuePair<string, object> fieldValue in _printingFieldsDictionary.Where(fieldValue => _pageModel.Fields.ContainsKey(fieldValue.Key)))
            {
                using (PrintField fieldParameters = _pageModel.Fields[fieldValue.Key])
                {
                    var text = fieldValue.Value.ToString();
                    var customVerticalMargin = 0F;
                    if (text.Contains("&&"))
                    {
                        var customFontParts = text.Split(new[] { "&&" }, StringSplitOptions.None)[0].Split(',');
                        text = text.Split(new[] { "&&" }, StringSplitOptions.None)[1];
                        var fontFamily = customFontParts[0];
                        var fontSize = float.Parse(customFontParts[1]);
                        var fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), customFontParts[2], true);
                        var customFont = fontFamily == "fre3of9x" ? BarcodeFont(fontSize) : new Font(fontFamily, fontSize, fontStyle);
                        
                        customVerticalMargin = float.Parse(customFontParts[3]);
                        fieldParameters.Height = fieldParameters.Height * 2;
                        fieldParameters.Width = fieldParameters.Width * 2;
                        fieldParameters.CalculateFontSize(text, e, customFont);
                        fieldParameters.Height = fieldParameters.Height / 2;
                        fieldParameters.Width = fieldParameters.Width / 2;
                    }
                    else
                    {
                        fieldParameters.CalculateFontSize(text, e);
                    }         
                    fieldParameters.CenterText(text, e);
                    var coordX = fieldParameters.CenteredPosX - hmx;
                    var coordY = fieldParameters.CenteredPosY - hmy + customVerticalMargin;
                    e.Graphics.DrawString(text, fieldParameters.CalculatedFont, Brushes.Black, coordX,coordY);
                }
            }

            for (int i = 0; i < _printingGridList.Count; i++)
            {
                foreach (KeyValuePair<string, object> fieldValue in _printingGridList[i].Where(fieldValue => _pageModel.Fields.ContainsKey("grid_" + fieldValue.Key.ToLower())))
                {
                    using (PrintField fieldParameters = _pageModel.Fields["grid_" + fieldValue.Key.ToLower()])
                    {
                        var text = fieldValue.Value.ToString();
                        var customVerticalMargin = 0F;
                        if (text.Contains("&&"))
                        {
                            var customFontParts = text.Split(new[] {"&&"}, StringSplitOptions.None)[0].Split(',');
                            text = text.Split(new[] { "&&" }, StringSplitOptions.None)[1];
                            var fontFamily = customFontParts[0];
                            var fontSize = float.Parse(customFontParts[1]);
                            var fontStyle = (FontStyle) Enum.Parse(typeof (FontStyle), customFontParts[2], true);
                            var customFont = fontFamily == "fre3of9x" ? BarcodeFont(fontSize) : new Font(fontFamily, fontSize, fontStyle);
                                                   
                            customVerticalMargin = float.Parse(customFontParts[3]);
                            fieldParameters.Height = fieldParameters.Height * 2;
                            fieldParameters.Width = fieldParameters.Width * 2;
                            fieldParameters.CalculateFontSize(text,e,customFont);
                            fieldParameters.Height = fieldParameters.Height / 2;
                            fieldParameters.Width = fieldParameters.Width / 2;                               
                        }                       
                        else
                        {
                            fieldParameters.CalculateFontSize(text, e);
                        }                      
                        fieldParameters.CenterText(text, e);
                        var coordX = fieldParameters.CenteredPosX - hmx;
                        var coordY = (fieldParameters.CenteredPosY + (fieldParameters.Height + (fieldParameters.VerticalMargin) * 2) * i) - hmy + customVerticalMargin;
                        e.Graphics.DrawString(text, fieldParameters.CalculatedFont, Brushes.Black,coordX, coordY);
                    }
                }
            }

        }

        private Font BarcodeFont(float fontSize)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Fonts\code128.ttf"));
            return new Font(pfc.Families[0],fontSize);
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

        public ModelPage(int documentType)
        {
            Bd db = new Bd();
            DataTable dt = db.Read("SELECT * FROM print_page WHERE id = '"+documentType+"'");

            _modelPageSize = new PointF(float.Parse(dt.Rows[0]["model_page_width"].ToString()), float.Parse(dt.Rows[0]["model_page_height"].ToString()));
            GridRows = int.Parse(dt.Rows[0]["grid_rows"].ToString());

            dt = db.Read("SELECT * FROM print_field WHERE print_page_id = '" + documentType + "'");
            foreach (PrintField pf in from DataRow sRow in dt.Rows select new PrintField
            {
                Field = sRow["field"].ToString(),
                DefaultValue = sRow["default_string"].ToString(),
                FontFamily = sRow["font_family"].ToString(),
                X = float.Parse(sRow["pos_x"].ToString()),
                Y = float.Parse(sRow["pos_y"].ToString()),
                Width = float.Parse(sRow["size_width"].ToString()),
                Height = float.Parse(sRow["size_height"].ToString()),
                HorizontalMargin = float.Parse(sRow["margin_horizontal"].ToString()),
                VerticalMargin = float.Parse(sRow["margin_vertical"].ToString()),
                FontSize = float.Parse(sRow["font_size"].ToString()),
                CenterHorizontally =  (bool)sRow["center_h"],
                CenterVertically = (bool)sRow["center_v"]
            })
            {
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
        public bool CenterHorizontally { get; set; }
        public bool CenterVertically { get; set; }

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
        public void CenterText(string text, PrintPageEventArgs printer, bool overrideCenterH = true, bool overrideCenterV = true )
        {
            Font fontToTest = CalculatedFont ?? FieldFont;
            SizeF textSize = printer.Graphics.MeasureString(text, fontToTest);
            CenteredPosX = CenterHorizontally && overrideCenterH ? X + (Width/2) - ((textSize.Width - HorizontalMargin)/2) : X;
            CenteredPosY = CenterVertically && overrideCenterV ? Y + (Height / 2) - ((textSize.Height - VerticalMargin) / 2) : Y;
        }

        public void CalculateFontSize(string text, PrintPageEventArgs printer, Font overrideFont = null)
        {
            SizeF textSize = printer.Graphics.MeasureString(text, FieldFont);
            Font testFont = overrideFont ?? FieldFont;

            if (textSize.Width < Width || textSize.Height < Height)
            {
                for (float i = testFont.Size; i > 1; i-=0.3F)
                {
                    testFont = new Font(testFont.FontFamily, i,testFont.Style);
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