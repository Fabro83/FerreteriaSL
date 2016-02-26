using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Net.SourceForge.Koogra;
using OfficeOpenXml;
using DataTable = System.Data.DataTable;

namespace FerreteriaSL.Productos
{
    public delegate void StatusChangedHandler(string status, int percentage, int type);
    public delegate void DataTableReadyHandler(DataTable result);
    public delegate void ExcelFileLoadedHandler();
    public delegate void PreviewLoadedhandler(DataTable previewTable);

    class KoograExcelImporter : IExcelReader
    {
        IWorkbook _xlsWorkbook;
        ExcelWorkbook _xlsxWorkbook;
        BackgroundWorker _bgwCargarArchivo;
        BackgroundWorker _bgwCargarHoja;
        BackgroundWorker _bgwCargarVistaPrevia;

        public string FilePath { get; private set; }

        public event StatusChangedHandler StatusChanged;
        void OnStatusChange(string status, int percentage = 0, int type = 0)
        {
            if (StatusChanged != null)
                StatusChanged(status, percentage, type);
        }
        // Types
        // -1 == ERROR
        //  0 == OK
        //  1 == Progress report with percentage
        //  2 == Cancelled
        //  3 == Progress report w/o percentage 

        public event ExcelFileLoadedHandler ExcelFileLoaded;
        void OnExcelFileLoaded()
        {
            if (ExcelFileLoaded != null)
                ExcelFileLoaded();
        }
     
        public event DataTableReadyHandler DataTableReady;
        void OnDataTableReady(DataTable result)
        {
            if (DataTableReady != null)
                DataTableReady(result);
        }

        public event PreviewLoadedhandler PreviewLoaded;
        void OnPreviewLoaded(DataTable previewTable)
        {
            if (PreviewLoaded != null)
                PreviewLoaded(previewTable);
        }

        public void LoadExcelFile(string filePath)
        {
            FilePath = filePath;
            _bgwCargarArchivo = new BackgroundWorker();
            _bgwCargarArchivo.DoWork += bgw_cargarArchivo_DoWork;
            _bgwCargarArchivo.RunWorkerCompleted += bgw_cargarArchivo_RunWorkerCompleted;
            string fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
            OnStatusChange("Cargando archivo \"" + fileName + "\"...",0,3);
            _bgwCargarArchivo.RunWorkerAsync(filePath);
        }

        void bgw_cargarArchivo_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = e.Argument.ToString();
            try
            {
                _xlsWorkbook = path.Contains("xlsx") ? WorkbookFactory.GetExcel2007Reader(path) : WorkbookFactory.GetExcelBIFFReader(path);                  
            }
            catch (Exception)
            {
                e.Cancel = true;
            }       
            e.Result = path;
        }

        void bgw_cargarArchivo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                OnStatusChange("No se pudo cargar el archivo. Intente guardar el archivo como 'Libro de Excel 97-2003'(.xls).", 0, -1);
            }
            else
            {
                OnStatusChange("\"" + (e.Result.ToString().Split('\\')[e.Result.ToString().Split('\\').Length - 1]) + "\" cargado correctamente.");
                OnExcelFileLoaded();
            }
        }

        public void ProcessExcelFile(int targetSheet, int[] targetColumns)
        {
            object[] workerArgs = { targetColumns, targetSheet };
            _bgwCargarHoja = new BackgroundWorker();
            _bgwCargarHoja.DoWork += bgw_cargarHoja_DoWork;
            _bgwCargarHoja.RunWorkerCompleted += bgw_cargarHoja_RunWorkerCompleted;
            _bgwCargarHoja.WorkerReportsProgress = true;
            _bgwCargarHoja.WorkerSupportsCancellation = true;
            _bgwCargarHoja.ProgressChanged += bgw_cargarHoja_ProgressChanged;
            _bgwCargarHoja.RunWorkerAsync(workerArgs);
        }

        void bgw_cargarHoja_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] targetColumns = ((e.Argument as object[])[0] as int[]);
            int targetSheet = int.Parse((e.Argument as object[])[1].ToString());

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("Codigo"), new DataColumn("Descripción"), new DataColumn("Precio", typeof(double)) });
            IWorksheet ws = _xlsWorkbook.Worksheets.GetWorksheetByIndex(targetSheet);
            
            for (uint r = ws.FirstRow; r <= ws.LastRow; r++)
            {
                if ((sender as BackgroundWorker).CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                (sender as BackgroundWorker).ReportProgress(0, (Convert.ToDouble(r) * 100D) / Convert.ToDouble(ws.LastRow));
                IRow iRow = ws.Rows.GetRow(r);
                double precio;
                string codigo;
                string descripcion;
                object rawPrecio;
                try
                {
                    codigo = iRow.GetCell(Convert.ToUInt32(targetColumns[0])).Value.ToString().Trim();
                    descripcion = iRow.GetCell(Convert.ToUInt32(targetColumns[1])).Value.ToString().Trim();
                    rawPrecio = iRow.GetCell(Convert.ToUInt32(targetColumns[2])).Value;
                }
                catch (NullReferenceException)
                {
                    continue;
                }

                if (rawPrecio == null || !double.TryParse(rawPrecio.ToString().Replace(".", ","), out precio) ||
                    descripcion == String.Empty || codigo == String.Empty) continue;
                DataRow dtRow = dt.NewRow();
                dtRow[0] = codigo;
                dtRow[1] = descripcion;
                dtRow[2] = precio;
                dt.Rows.Add(dtRow);
            }

            e.Result = dt;
        }
        // QUIZAS
        //void LoadXLSX(int selectedWorksheet)
        //{
        //    ExcelWorksheet objExcelWorksheet = _xlsxWorkbook.Worksheets[selectedWorksheet];
        //    DataTable excelDataTable = new DataTable();

        //    BuildColumnsNames(objExcelWorksheet.Dimension.End.Column).ToList().ForEach(f => excelDataTable.Columns.Add(f));

        //    for (int row = 1; row <= objExcelWorksheet.Dimension.End.Row; row++)
        //    {
        //        var newRow = excelDataTable.NewRow();
        //        foreach (var col in BuildColumnsNames(objExcelWorksheet.Dimension.End.Column))
        //        {
        //            newRow[col] = objExcelWorksheet.Cells[col + row].Value;
        //        }
        //        excelDataTable.Rows.Add(newRow);
        //    }
            
            

        //}

        void bgw_cargarHoja_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                OnStatusChange("Lectura de Excel cancelada.", 0, 2);
            }
            else
            {
                OnStatusChange("Lectura completada.");
                OnDataTableReady(e.Result as DataTable);
            }
        }

        void bgw_cargarHoja_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double percentage = Convert.ToDouble(e.UserState);
            OnStatusChange("Cargando " + percentage.ToString("0.00", CultureInfo.InvariantCulture) + "%",Convert.ToInt32(percentage),1);
        }

        public object[] GetSheetNames()
        {
            object[] sheetNames = new object[_xlsWorkbook.Worksheets.Count];
            for (int i = 0; i < _xlsWorkbook.Worksheets.Count; i++)
            {
                sheetNames[i] = _xlsWorkbook.Worksheets.GetWorksheetByIndex(i).Name;
            }
            return sheetNames;
        }

        public int GetNumberOfUsedColumns(int sheetIndex)
        {
            IWorksheet ws = _xlsWorkbook.Worksheets.GetWorksheetByIndex(sheetIndex);
            return Convert.ToInt32(ws.LastCol);
        }

        public void GetSheetPreview(int sheetIndex)
        {
            _bgwCargarVistaPrevia = new BackgroundWorker();
            _bgwCargarVistaPrevia.DoWork += bgw_cargarVistaPrevia_DoWork;
            _bgwCargarVistaPrevia.RunWorkerCompleted += bgw_cargarVistaPrevia_RunWorkerCompleted;
            OnStatusChange("Cargando hoja \"" + _xlsWorkbook.Worksheets.GetWorksheetByIndex(sheetIndex).Name + "\"...", 0, 3);
            _bgwCargarVistaPrevia.RunWorkerAsync(sheetIndex);
        }

        void bgw_cargarVistaPrevia_DoWork(object sender, DoWorkEventArgs e)
        {
            IWorksheet wSheet = _xlsWorkbook.Worksheets.GetWorksheetByIndex(Convert.ToInt32(e.Argument));

            uint maxRows = wSheet.LastRow <= 30 ? wSheet.LastRow : 30;
            uint maxColumns = wSheet.LastCol + 1;//<= 10 ? wSheet.LastCol + 1 : 50;

            IEnumerable<string> columnNames = BuildColumnsNames(Convert.ToInt32(maxColumns));

            DataTable previewTable = new DataTable();

            foreach (string sCol in columnNames)
            {
                previewTable.Columns.Add(sCol);
            }

            for (uint r = 0; r < maxRows; r++)
            {
                IRow sRow = wSheet.Rows.GetRow(r);
                DataRow newRow = previewTable.NewRow();
                bool newRowHasValues = false;
                for (uint c = 0; c < maxColumns; c++)
                {
                    try
                    {
                        newRow[Convert.ToInt32(c)] = sRow.GetCell(c).Value;
                    }
                    catch (NullReferenceException)
                    {
                        newRow[Convert.ToInt32(c)] = String.Empty;
                    }
                    if (newRow[Convert.ToInt32(c)] != null && newRow[Convert.ToInt32(c)].ToString() != String.Empty && newRow[Convert.ToInt32(c)] != DBNull.Value)
                        newRowHasValues = true;
                }
                if (newRowHasValues)
                    previewTable.Rows.Add(newRow);
            }

            e.Result = previewTable;

        }

        void bgw_cargarVistaPrevia_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnStatusChange("Vista previa cargada.");
            OnPreviewLoaded(e.Result as DataTable);
        }

        static IEnumerable<string> BuildColumnsNames(int columnCount)
        {
            string[] baseColumns = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            List<string> columnName = new List<string>();


            for (int i = 0; i < columnCount; i++)
            {
                int curCol = i;
                StringBuilder curColName = new StringBuilder();

                while (curCol >= baseColumns.Length)
                {
                    curColName.Insert(0, baseColumns[curCol % baseColumns.Length]);
                    curCol /= baseColumns.Length;
                }

                if (i >= baseColumns.Length)
                    curCol--;

                curColName.Insert(0, baseColumns[curCol]);

                columnName.Add(curColName.ToString());
            }

            return columnName.ToArray();
        }

    }

    interface IExcelReader
    {
        string FilePath { get; }

        object[] GetSheetNames();
        void LoadExcelFile(string filePath);
        void ProcessExcelFile(int targetSheet, int[] targetColumns);
        int GetNumberOfUsedColumns(int sheetIndex);

        event StatusChangedHandler StatusChanged;
        event ExcelFileLoadedHandler ExcelFileLoaded;
        event DataTableReadyHandler DataTableReady;
    }
}
