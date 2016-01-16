using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class ImportWindow : Form
    {
        KoograExcelImporter _kei;

        public string FileName { get; private set; }

        public DataTable ImportedExcel { get; private set; }

        public ImportWindow()
        {
            InitializeComponent();
            cb_codeColumn.SelectedIndex = 0;
            cb_descriptionColumn.SelectedIndex = 1;
            cb_priceColumn.SelectedIndex = 2;
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog {Filter = "Archivos Excel|*.xls;*.xlsx"};

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _kei = new KoograExcelImporter();
                _kei.StatusChanged += KEI_StatusChanged;
                _kei.ExcelFileLoaded += KEI_ExcelFileLoaded;
                FileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\"));
                _kei.LoadExcelFile(ofd.FileName);
            }      
        }

        void KEI_ExcelFileLoaded()
        {
            cb_sheet.Items.Clear();
            cb_sheet.Items.AddRange(_kei.GetSheetNames());
            lbl_fileValue.Text = _kei.FilePath.Split('\\')[_kei.FilePath.Split('\\').Length - 1];
            lbl_directoryValue.Text = _kei.FilePath.Replace(lbl_fileValue.Text, "");

            gb_sheet.Enabled = true;
            gb_sheetPreview.Enabled = false;
            gb_columns.Enabled = false;
            dgv_sheetPreview.DataSource = null;
            cb_codeColumn.SelectedIndex = 0;
            cb_descriptionColumn.SelectedIndex = 1;
            cb_priceColumn.SelectedIndex = 2;
            cb_sheet.SelectedIndex = 0;
            btn_import.Enabled = false;
        }

        void KEI_StatusChanged(string status, int percentage, int type)
        {
            Color textColor = Color.Black;
            if (type == -1)
                textColor = Color.DarkRed;
            if (type == 1)
            {
                tspb_progressInfo.Visible = true;
                tspb_progressInfo.Maximum = 100;
                tspb_progressInfo.Minimum = 0;
                tspb_progressInfo.Style = ProgressBarStyle.Blocks;
                tspb_progressInfo.Value = percentage;
            }
            else if (type == 3)
            {
                tspb_progressInfo.Visible = true;
                tspb_progressInfo.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                tspb_progressInfo.Visible = false;
            }
            tssl_statusInfo.ForeColor = textColor;
            tssl_statusInfo.Text = status;
        }

        private void cb_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sheet.SelectedIndex == -1)
                return;

            _kei.GetSheetPreview(cb_sheet.SelectedIndex);
            gb_columns.Enabled = false;
            btn_import.Enabled = false;
            gb_sheetPreview.Enabled = false;
            _kei.PreviewLoaded += KEI_PreviewLoaded;

        }

        void KEI_PreviewLoaded(DataTable previewTable)
        {
            gb_sheetPreview.Enabled = true;
            dgv_sheetPreview.DataSource = previewTable;
            gb_columns.Enabled = true;
            btn_import.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            gb_file.Enabled = false;
            gb_sheet.Enabled = false;
            gb_sheetPreview.Enabled = false;
            gb_columns.Enabled = false;
            btn_cancel.Enabled = false;
            btn_import.Enabled = false;
            int[] targetColumns = { cb_codeColumn.SelectedIndex, cb_descriptionColumn.SelectedIndex, cb_priceColumn.SelectedIndex };
            int targetSheet = cb_sheet.SelectedIndex;
            _kei.ProcessExcelFile(targetSheet, targetColumns);
            _kei.DataTableReady += KEI_DataTableReady;
        }

        void KEI_DataTableReady(DataTable result)
        {
            ImportedExcel = result;
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
