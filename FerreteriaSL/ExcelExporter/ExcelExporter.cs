using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace FerreteriaSL.ExcelExporter
{
    public partial class ExcelExporter : Form
    {
        private readonly DataGridView _dgvListaProductos;
        private ExcelPackage _objExcelPackage;
        private readonly BackgroundWorker _bwExport;
        private readonly string _fileName;
        private readonly string _subtitle;
        private readonly bool _calculateTotal;

        public ExcelExporter(string fileName, DataGridView dgvListaProductos,string subtitle, bool calculateTotal = false)
        {
            InitializeComponent();
            _bwExport = new BackgroundWorker();
            _bwExport.DoWork += bwExport_DoWork;
            _bwExport.RunWorkerCompleted += bwExport_RunWorkerCompleted;
            _bwExport.WorkerReportsProgress = true;
            _bwExport.ProgressChanged += bwExport_ProgressChanged;
            _dgvListaProductos = dgvListaProductos;
            _fileName = fileName;
            _subtitle = subtitle;
            _calculateTotal = calculateTotal;
            StartExporting();
        }

        void bwExport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_progress.Value = e.ProgressPercentage;
            lbl_info.Text = e.UserState.ToString();
        }

        void bwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExcelWorksheet objExcelWorksheet = (ExcelWorksheet)e.Result;

            var dgvRowCount = _dgvListaProductos.Rows.Cast<DataGridViewRow>().Count(r => r.Visible);
            var dgvColumnCount = _dgvListaProductos.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);

            objExcelWorksheet.Cells[1, 1].Value = "Ferreteria San Lorenzo";
            var titleRange = objExcelWorksheet.Cells[1, 1, 1, dgvColumnCount];
            titleRange.Merge = true;
            titleRange.Style.Font.Size = 26;
            titleRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            titleRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
            titleRange.Style.Fill.BackgroundColor.SetColor(Color.Black);
            titleRange.Style.Font.Color.SetColor(Color.Red);

            objExcelWorksheet.Cells[2, 1].Value = _subtitle + " - " + DateTime.Now.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            var subtitleRange = objExcelWorksheet.Cells[2, 1, 2, dgvColumnCount];
            subtitleRange.Merge = true;
            subtitleRange.Style.Font.Size = 16;
            subtitleRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            subtitleRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
            subtitleRange.Style.Fill.BackgroundColor.SetColor(Color.DarkCyan);

            var usedCells = objExcelWorksheet.Cells[1, 1, dgvRowCount + 3, dgvColumnCount];
            usedCells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            usedCells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            usedCells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            usedCells.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            objExcelWorksheet.Cells.AutoFitColumns(0);

            if (_calculateTotal)
            {
                var totalLabel = objExcelWorksheet.Cells[dgvRowCount + 4, dgvColumnCount - 1];
                var totalValue =  objExcelWorksheet.Cells[dgvRowCount + 4, dgvColumnCount];

                totalLabel.Value = "Total";
                totalLabel.Style.Font.Size = 16;
                totalLabel.Style.Font.Bold = true;
                totalLabel.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                totalValue.Value =
                    _dgvListaProductos.Rows.Cast<DataGridViewRow>()
                        .Where(w => w.Visible)
                        .Sum(s => (double) s.Cells["precio_subtotal"].Value);
                totalValue.Style.Font.Size = 16;
                totalValue.Style.Font.Bold = true;
                totalValue.Style.Numberformat.Format = "$#,##0.00";

                var borderTitle =
                    objExcelWorksheet.Cells[dgvRowCount + 4, dgvColumnCount - 1, dgvRowCount + 4, dgvColumnCount];
                borderTitle.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                borderTitle.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                borderTitle.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                borderTitle.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            }

            try
            {
                _objExcelPackage.Save();
                lbl_message.Text = "Exportación completada";
                lbl_info.Text = + dgvRowCount + " items exportados correctamente.";
                llbl_openFolder.Enabled = true;
            }
            catch
            {
                lbl_message.Text = "Error al exportar";
                lbl_info.Text = "Ocurrió un error al exportar.";
                lbl_info.ForeColor = Color.Red;
            }
            finally
            {
                btn_close.Enabled = true;
            }
        }

        void bwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            ExcelWorksheet objExcelWorksheet = (ExcelWorksheet) e.Argument;
            int rowCount = 4;
            int totalRows = _dgvListaProductos.Rows.Cast<DataGridViewRow>().Count(row => row.Visible);
            foreach (DataGridViewRow row in _dgvListaProductos.Rows.Cast<DataGridViewRow>().Where(row => row.Visible))
            {
                int cellCount = 1;
                foreach (DataGridViewCell cell in row.Cells.Cast<DataGridViewCell>().Where(cell => cell.Visible))
                {
                    var value = cell.Value;
                    if (cell.OwningColumn.HeaderText.ToLower().Contains("precio"))
                    {
                        objExcelWorksheet.Cells[rowCount, cellCount].Style.Numberformat.Format = "$#,##0.00";
                    }
                    else if (cell.OwningColumn.HeaderText.Contains("%"))
                    {
                        objExcelWorksheet.Cells[rowCount, cellCount].Style.Numberformat.Format = "0.00%";
                        value = (double) value/100;
                    }
                    else if (value is DateTime)
                    {
                        objExcelWorksheet.Cells[rowCount, cellCount].Style.Numberformat.Format = "dd/MM/yyyy";
                    }
                    else
                    {
                        objExcelWorksheet.Cells[rowCount, cellCount].Style.Numberformat.Format = "@";
                    }
                    objExcelWorksheet.Cells[rowCount, cellCount].Value = value;
                    cellCount++;
                }
                rowCount++;
                ((BackgroundWorker)sender).ReportProgress(((rowCount - 4) * 100) / totalRows, "Exportando: " + (rowCount - 4) + "/" + totalRows);
            }

            e.Result = objExcelWorksheet;
        }

        public void StartExporting()
        {
            FileInfo newFile = new FileInfo(_fileName);
            if (newFile.Exists)
                newFile.Delete();

            _objExcelPackage = new ExcelPackage(newFile);
            ExcelWorksheet objExcelWorksheet = _objExcelPackage.Workbook.Worksheets.Add("Inventario");

            int colCount = 1;
            foreach (DataGridViewColumn col in _dgvListaProductos.Columns.Cast<DataGridViewColumn>().Where(col => col.Visible))
            {
                var excelRange = objExcelWorksheet.Cells[3, colCount];
                excelRange.Value = col.HeaderText;

                excelRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                excelRange.Style.Fill.BackgroundColor.SetColor(Color.Bisque);
                excelRange.Style.Font.Bold = true;
                excelRange.Style.Font.Size = 13;
                colCount++;
            }

            _bwExport.RunWorkerAsync(objExcelWorksheet);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llbl_openFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!File.Exists(_fileName)) return;
            System.Diagnostics.Process.Start("explorer.exe", @"/select, " + _fileName);
        }



    }
}
