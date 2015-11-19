using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    partial class ImportWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ss_statusInfo = new System.Windows.Forms.StatusStrip();
            this.tssl_statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_separator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspb_progressInfo = new System.Windows.Forms.ToolStripProgressBar();
            this.gb_file = new System.Windows.Forms.GroupBox();
            this.lbl_directoryValue = new System.Windows.Forms.Label();
            this.lbl_fileValue = new System.Windows.Forms.Label();
            this.lbl_directoryInfo = new System.Windows.Forms.Label();
            this.lbl_fileInfo = new System.Windows.Forms.Label();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.gb_sheet = new System.Windows.Forms.GroupBox();
            this.cb_sheet = new System.Windows.Forms.ComboBox();
            this.lbl_sheetInfo = new System.Windows.Forms.Label();
            this.gb_sheetPreview = new System.Windows.Forms.GroupBox();
            this.dgv_sheetPreview = new System.Windows.Forms.DataGridView();
            this.gb_columns = new System.Windows.Forms.GroupBox();
            this.cb_priceColumn = new System.Windows.Forms.ComboBox();
            this.cb_descriptionColumn = new System.Windows.Forms.ComboBox();
            this.cb_codeColumn = new System.Windows.Forms.ComboBox();
            this.lbl_priceColumnInfo = new System.Windows.Forms.Label();
            this.lbl_descriptionColumnInfo = new System.Windows.Forms.Label();
            this.lbl_codeColumnInfo = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.ss_statusInfo.SuspendLayout();
            this.gb_file.SuspendLayout();
            this.gb_sheet.SuspendLayout();
            this.gb_sheetPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sheetPreview)).BeginInit();
            this.gb_columns.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_statusInfo
            // 
            this.ss_statusInfo.BackColor = System.Drawing.SystemColors.Control;
            this.ss_statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_statusInfo,
            this.tssl_separator,
            this.tspb_progressInfo});
            this.ss_statusInfo.Location = new System.Drawing.Point(0, 536);
            this.ss_statusInfo.Name = "ss_statusInfo";
            this.ss_statusInfo.Size = new System.Drawing.Size(725, 22);
            this.ss_statusInfo.SizingGrip = false;
            this.ss_statusInfo.TabIndex = 0;
            // 
            // tssl_statusInfo
            // 
            this.tssl_statusInfo.Name = "tssl_statusInfo";
            this.tssl_statusInfo.Size = new System.Drawing.Size(62, 17);
            this.tssl_statusInfo.Text = "Información";
            // 
            // tssl_separator
            // 
            this.tssl_separator.Name = "tssl_separator";
            this.tssl_separator.Size = new System.Drawing.Size(648, 17);
            this.tssl_separator.Spring = true;
            // 
            // tspb_progressInfo
            // 
            this.tspb_progressInfo.Name = "tspb_progressInfo";
            this.tspb_progressInfo.Size = new System.Drawing.Size(100, 16);
            this.tspb_progressInfo.Visible = false;
            // 
            // gb_file
            // 
            this.gb_file.Controls.Add(this.lbl_directoryValue);
            this.gb_file.Controls.Add(this.lbl_fileValue);
            this.gb_file.Controls.Add(this.lbl_directoryInfo);
            this.gb_file.Controls.Add(this.lbl_fileInfo);
            this.gb_file.Controls.Add(this.btn_openFile);
            this.gb_file.Location = new System.Drawing.Point(12, 12);
            this.gb_file.Name = "gb_file";
            this.gb_file.Size = new System.Drawing.Size(701, 84);
            this.gb_file.TabIndex = 1;
            this.gb_file.TabStop = false;
            this.gb_file.Text = "Archivo";
            // 
            // lbl_directoryValue
            // 
            this.lbl_directoryValue.AutoSize = true;
            this.lbl_directoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directoryValue.Location = new System.Drawing.Point(209, 50);
            this.lbl_directoryValue.Name = "lbl_directoryValue";
            this.lbl_directoryValue.Size = new System.Drawing.Size(29, 15);
            this.lbl_directoryValue.TabIndex = 4;
            this.lbl_directoryValue.Text = "N/A";
            // 
            // lbl_fileValue
            // 
            this.lbl_fileValue.AutoSize = true;
            this.lbl_fileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileValue.Location = new System.Drawing.Point(209, 23);
            this.lbl_fileValue.Name = "lbl_fileValue";
            this.lbl_fileValue.Size = new System.Drawing.Size(29, 15);
            this.lbl_fileValue.TabIndex = 3;
            this.lbl_fileValue.Text = "N/A";
            // 
            // lbl_directoryInfo
            // 
            this.lbl_directoryInfo.AutoSize = true;
            this.lbl_directoryInfo.Location = new System.Drawing.Point(92, 51);
            this.lbl_directoryInfo.Name = "lbl_directoryInfo";
            this.lbl_directoryInfo.Size = new System.Drawing.Size(111, 13);
            this.lbl_directoryInfo.TabIndex = 2;
            this.lbl_directoryInfo.Text = "Directorio del Archivo:";
            // 
            // lbl_fileInfo
            // 
            this.lbl_fileInfo.AutoSize = true;
            this.lbl_fileInfo.Location = new System.Drawing.Point(89, 24);
            this.lbl_fileInfo.Name = "lbl_fileInfo";
            this.lbl_fileInfo.Size = new System.Drawing.Size(114, 13);
            this.lbl_fileInfo.TabIndex = 1;
            this.lbl_fileInfo.Text = "Archivo Seleccionado:";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(6, 19);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 55);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Seleccionar Archivo";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // gb_sheet
            // 
            this.gb_sheet.Controls.Add(this.cb_sheet);
            this.gb_sheet.Controls.Add(this.lbl_sheetInfo);
            this.gb_sheet.Enabled = false;
            this.gb_sheet.Location = new System.Drawing.Point(12, 102);
            this.gb_sheet.Name = "gb_sheet";
            this.gb_sheet.Size = new System.Drawing.Size(701, 55);
            this.gb_sheet.TabIndex = 2;
            this.gb_sheet.TabStop = false;
            this.gb_sheet.Text = "Hoja";
            // 
            // cb_sheet
            // 
            this.cb_sheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sheet.FormattingEnabled = true;
            this.cb_sheet.Location = new System.Drawing.Point(289, 21);
            this.cb_sheet.Name = "cb_sheet";
            this.cb_sheet.Size = new System.Drawing.Size(208, 21);
            this.cb_sheet.TabIndex = 1;
            this.cb_sheet.SelectedIndexChanged += new System.EventHandler(this.cb_sheet_SelectedIndexChanged);
            // 
            // lbl_sheetInfo
            // 
            this.lbl_sheetInfo.AutoSize = true;
            this.lbl_sheetInfo.Location = new System.Drawing.Point(203, 25);
            this.lbl_sheetInfo.Name = "lbl_sheetInfo";
            this.lbl_sheetInfo.Size = new System.Drawing.Size(82, 13);
            this.lbl_sheetInfo.TabIndex = 0;
            this.lbl_sheetInfo.Text = "Hoja a Importar:";
            // 
            // gb_sheetPreview
            // 
            this.gb_sheetPreview.Controls.Add(this.dgv_sheetPreview);
            this.gb_sheetPreview.Enabled = false;
            this.gb_sheetPreview.Location = new System.Drawing.Point(12, 163);
            this.gb_sheetPreview.Name = "gb_sheetPreview";
            this.gb_sheetPreview.Size = new System.Drawing.Size(701, 278);
            this.gb_sheetPreview.TabIndex = 3;
            this.gb_sheetPreview.TabStop = false;
            this.gb_sheetPreview.Text = "Vista previa de la hoja";
            // 
            // dgv_sheetPreview
            // 
            this.dgv_sheetPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sheetPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sheetPreview.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_sheetPreview.Location = new System.Drawing.Point(6, 19);
            this.dgv_sheetPreview.Name = "dgv_sheetPreview";
            this.dgv_sheetPreview.ReadOnly = true;
            this.dgv_sheetPreview.RowHeadersVisible = false;
            this.dgv_sheetPreview.ShowEditingIcon = false;
            this.dgv_sheetPreview.Size = new System.Drawing.Size(689, 253);
            this.dgv_sheetPreview.TabIndex = 0;
            // 
            // gb_columns
            // 
            this.gb_columns.Controls.Add(this.cb_priceColumn);
            this.gb_columns.Controls.Add(this.cb_descriptionColumn);
            this.gb_columns.Controls.Add(this.cb_codeColumn);
            this.gb_columns.Controls.Add(this.lbl_priceColumnInfo);
            this.gb_columns.Controls.Add(this.lbl_descriptionColumnInfo);
            this.gb_columns.Controls.Add(this.lbl_codeColumnInfo);
            this.gb_columns.Enabled = false;
            this.gb_columns.Location = new System.Drawing.Point(12, 447);
            this.gb_columns.Name = "gb_columns";
            this.gb_columns.Size = new System.Drawing.Size(701, 49);
            this.gb_columns.TabIndex = 4;
            this.gb_columns.TabStop = false;
            this.gb_columns.Text = "Columnas";
            // 
            // cb_priceColumn
            // 
            this.cb_priceColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_priceColumn.FormattingEnabled = true;
            this.cb_priceColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_priceColumn.Location = new System.Drawing.Point(554, 17);
            this.cb_priceColumn.Name = "cb_priceColumn";
            this.cb_priceColumn.Size = new System.Drawing.Size(35, 21);
            this.cb_priceColumn.TabIndex = 5;
            // 
            // cb_descriptionColumn
            // 
            this.cb_descriptionColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_descriptionColumn.FormattingEnabled = true;
            this.cb_descriptionColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_descriptionColumn.Location = new System.Drawing.Point(329, 17);
            this.cb_descriptionColumn.Name = "cb_descriptionColumn";
            this.cb_descriptionColumn.Size = new System.Drawing.Size(35, 21);
            this.cb_descriptionColumn.TabIndex = 4;
            // 
            // cb_codeColumn
            // 
            this.cb_codeColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_codeColumn.FormattingEnabled = true;
            this.cb_codeColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb_codeColumn.Location = new System.Drawing.Point(107, 17);
            this.cb_codeColumn.Name = "cb_codeColumn";
            this.cb_codeColumn.Size = new System.Drawing.Size(35, 21);
            this.cb_codeColumn.TabIndex = 3;
            // 
            // lbl_priceColumnInfo
            // 
            this.lbl_priceColumnInfo.AutoSize = true;
            this.lbl_priceColumnInfo.Location = new System.Drawing.Point(514, 21);
            this.lbl_priceColumnInfo.Name = "lbl_priceColumnInfo";
            this.lbl_priceColumnInfo.Size = new System.Drawing.Size(40, 13);
            this.lbl_priceColumnInfo.TabIndex = 2;
            this.lbl_priceColumnInfo.Text = "Precio:";
            // 
            // lbl_descriptionColumnInfo
            // 
            this.lbl_descriptionColumnInfo.AutoSize = true;
            this.lbl_descriptionColumnInfo.Location = new System.Drawing.Point(263, 21);
            this.lbl_descriptionColumnInfo.Name = "lbl_descriptionColumnInfo";
            this.lbl_descriptionColumnInfo.Size = new System.Drawing.Size(66, 13);
            this.lbl_descriptionColumnInfo.TabIndex = 1;
            this.lbl_descriptionColumnInfo.Text = "Descripción:";
            // 
            // lbl_codeColumnInfo
            // 
            this.lbl_codeColumnInfo.AutoSize = true;
            this.lbl_codeColumnInfo.Location = new System.Drawing.Point(64, 21);
            this.lbl_codeColumnInfo.Name = "lbl_codeColumnInfo";
            this.lbl_codeColumnInfo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codeColumnInfo.TabIndex = 0;
            this.lbl_codeColumnInfo.Text = "Codigo:";
            // 
            // btn_import
            // 
            this.btn_import.Enabled = false;
            this.btn_import.Location = new System.Drawing.Point(638, 504);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Importar";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 504);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ImportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(725, 558);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.gb_columns);
            this.Controls.Add(this.gb_sheetPreview);
            this.Controls.Add(this.gb_sheet);
            this.Controls.Add(this.gb_file);
            this.Controls.Add(this.ss_statusInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImportWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Archivo";
            this.ss_statusInfo.ResumeLayout(false);
            this.ss_statusInfo.PerformLayout();
            this.gb_file.ResumeLayout(false);
            this.gb_file.PerformLayout();
            this.gb_sheet.ResumeLayout(false);
            this.gb_sheet.PerformLayout();
            this.gb_sheetPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sheetPreview)).EndInit();
            this.gb_columns.ResumeLayout(false);
            this.gb_columns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip ss_statusInfo;
        private ToolStripStatusLabel tssl_statusInfo;
        private ToolStripStatusLabel tssl_separator;
        private ToolStripProgressBar tspb_progressInfo;
        private GroupBox gb_file;
        private Label lbl_directoryValue;
        private Label lbl_fileValue;
        private Label lbl_directoryInfo;
        private Label lbl_fileInfo;
        private Button btn_openFile;
        private GroupBox gb_sheet;
        private ComboBox cb_sheet;
        private Label lbl_sheetInfo;
        private GroupBox gb_sheetPreview;
        private DataGridView dgv_sheetPreview;
        private GroupBox gb_columns;
        private ComboBox cb_priceColumn;
        private ComboBox cb_descriptionColumn;
        private ComboBox cb_codeColumn;
        private Label lbl_priceColumnInfo;
        private Label lbl_descriptionColumnInfo;
        private Label lbl_codeColumnInfo;
        private Button btn_import;
        private Button btn_cancel;
    }
}