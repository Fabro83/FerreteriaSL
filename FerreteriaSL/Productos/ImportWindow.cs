using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public partial class ImportWindow : Form
    {
        KoograExcelImporter KEI;
        DataTable importedExcel;
        string fileName;

        public string FileName
        {
            get { return fileName; }
        }

        public DataTable ImportedExcel
        {
            get { return importedExcel; }
        }

        public ImportWindow()
        {
            InitializeComponent();
            cb_codeColumn.SelectedIndex = 0;
            cb_descriptionColumn.SelectedIndex = 1;
            cb_priceColumn.SelectedIndex = 2;
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Archivos Excel|*.xls;*.xlsx";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                KEI = new KoograExcelImporter();
                KEI.StatusChanged += new StatusChangedHandler(KEI_StatusChanged);
                KEI.ExcelFileLoaded += new ExcelFileLoadedHandler(KEI_ExcelFileLoaded);
                this.fileName = OFD.FileName.Substring(OFD.FileName.LastIndexOf("\\"));
                KEI.loadExcelFile(OFD.FileName);
            }      
        }

        void KEI_ExcelFileLoaded()
        {
            cb_sheet.Items.Clear();
            cb_sheet.Items.AddRange(KEI.getSheetNames());
            lbl_fileValue.Text = KEI.FilePath.Split('\\')[KEI.FilePath.Split('\\').Length - 1];
            lbl_directoryValue.Text = KEI.FilePath.Replace(lbl_fileValue.Text, "");

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

            KEI.getSheetPreview(cb_sheet.SelectedIndex);
            gb_columns.Enabled = false;
            btn_import.Enabled = false;
            gb_sheetPreview.Enabled = false;
            KEI.PreviewLoaded += new PreviewLoadedhandler(KEI_PreviewLoaded);

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            KEI.processExcelFile(targetSheet, targetColumns);
            KEI.DataTableReady += new DataTableReadyHandler(KEI_DataTableReady);
        }

        void KEI_DataTableReady(DataTable result)
        {
            importedExcel = result;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
