using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Caja_Diaria
{
    partial class CajaDiaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaDiaria));
            this.gb_filterType = new System.Windows.Forms.GroupBox();
            this.cb_filterType = new System.Windows.Forms.ComboBox();
            this.gb_dateRanges = new System.Windows.Forms.GroupBox();
            this.rb_dateRage = new System.Windows.Forms.RadioButton();
            this.dtp_singleDay = new System.Windows.Forms.DateTimePicker();
            this.rb_singleDay = new System.Windows.Forms.RadioButton();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateTo = new System.Windows.Forms.Label();
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateFrom = new System.Windows.Forms.Label();
            this.dgv_caja = new System.Windows.Forms.DataGridView();
            this.tb_caja = new System.Windows.Forms.TabControl();
            this.tp_resumen = new System.Windows.Forms.TabPage();
            this.gb_values = new System.Windows.Forms.GroupBox();
            this.lbl_moneyValuesDiferenceValue = new System.Windows.Forms.Label();
            this.lbl_moneyValuesDiference = new System.Windows.Forms.Label();
            this.lbl_moneyValuesTotalValue = new System.Windows.Forms.Label();
            this.lbl_moneyValuesTotal = new System.Windows.Forms.Label();
            this.dgv_moneyValues = new System.Windows.Forms.DataGridView();
            this.gb_dailyInfo = new System.Windows.Forms.GroupBox();
            this.tb_detalle = new System.Windows.Forms.TabPage();
            this.gb_informacionParcial = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_totalEnCaja = new System.Windows.Forms.Label();
            this.lbl_totalEnCajaValue = new System.Windows.Forms.Label();
            this.lbl_cajaTurnoManana = new System.Windows.Forms.Label();
            this.lbl_cajaTurnoTarde = new System.Windows.Forms.Label();
            this.lbl_cajaTurnoMananaValue = new System.Windows.Forms.Label();
            this.lbl_cajaTurnoTardeValue = new System.Windows.Forms.Label();
            this.gb_filterType.SuspendLayout();
            this.gb_dateRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja)).BeginInit();
            this.tb_caja.SuspendLayout();
            this.tp_resumen.SuspendLayout();
            this.gb_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_moneyValues)).BeginInit();
            this.gb_dailyInfo.SuspendLayout();
            this.tb_detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_filterType
            // 
            this.gb_filterType.Controls.Add(this.cb_filterType);
            this.gb_filterType.Location = new System.Drawing.Point(6, 6);
            this.gb_filterType.Name = "gb_filterType";
            this.gb_filterType.Size = new System.Drawing.Size(142, 59);
            this.gb_filterType.TabIndex = 0;
            this.gb_filterType.TabStop = false;
            this.gb_filterType.Text = "Tipo";
            // 
            // cb_filterType
            // 
            this.cb_filterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filterType.FormattingEnabled = true;
            this.cb_filterType.Items.AddRange(new object[] {
            "Todos",
            "Ingresos",
            "Egresos"});
            this.cb_filterType.Location = new System.Drawing.Point(11, 23);
            this.cb_filterType.Name = "cb_filterType";
            this.cb_filterType.Size = new System.Drawing.Size(121, 21);
            this.cb_filterType.TabIndex = 0;
            this.cb_filterType.SelectedIndexChanged += new System.EventHandler(this.cb_filterType_SelectedIndexChanged);
            // 
            // gb_dateRanges
            // 
            this.gb_dateRanges.Controls.Add(this.rb_dateRage);
            this.gb_dateRanges.Controls.Add(this.dtp_singleDay);
            this.gb_dateRanges.Controls.Add(this.rb_singleDay);
            this.gb_dateRanges.Controls.Add(this.dtp_dateTo);
            this.gb_dateRanges.Controls.Add(this.lbl_dateTo);
            this.gb_dateRanges.Controls.Add(this.dtp_dateFrom);
            this.gb_dateRanges.Controls.Add(this.lbl_dateFrom);
            this.gb_dateRanges.Location = new System.Drawing.Point(154, 6);
            this.gb_dateRanges.Name = "gb_dateRanges";
            this.gb_dateRanges.Size = new System.Drawing.Size(523, 59);
            this.gb_dateRanges.TabIndex = 2;
            this.gb_dateRanges.TabStop = false;
            this.gb_dateRanges.Text = "Rango de Fechas";
            // 
            // rb_dateRage
            // 
            this.rb_dateRage.AutoSize = true;
            this.rb_dateRage.Location = new System.Drawing.Point(197, 24);
            this.rb_dateRage.Name = "rb_dateRage";
            this.rb_dateRage.Size = new System.Drawing.Size(60, 17);
            this.rb_dateRage.TabIndex = 6;
            this.rb_dateRage.Text = "Rango:";
            this.rb_dateRage.UseVisualStyleBackColor = true;
            this.rb_dateRage.CheckedChanged += new System.EventHandler(this.rb_dateRage_CheckedChanged);
            // 
            // dtp_singleDay
            // 
            this.dtp_singleDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_singleDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_singleDay.Location = new System.Drawing.Point(95, 22);
            this.dtp_singleDay.Name = "dtp_singleDay";
            this.dtp_singleDay.Size = new System.Drawing.Size(79, 20);
            this.dtp_singleDay.TabIndex = 5;
            this.dtp_singleDay.ValueChanged += new System.EventHandler(this.dtp_generic_ValueChanged);
            // 
            // rb_singleDay
            // 
            this.rb_singleDay.AutoSize = true;
            this.rb_singleDay.Checked = true;
            this.rb_singleDay.Location = new System.Drawing.Point(16, 24);
            this.rb_singleDay.Name = "rb_singleDay";
            this.rb_singleDay.Size = new System.Drawing.Size(79, 17);
            this.rb_singleDay.TabIndex = 4;
            this.rb_singleDay.TabStop = true;
            this.rb_singleDay.Text = "Solo el día:";
            this.rb_singleDay.UseVisualStyleBackColor = true;
            this.rb_singleDay.CheckedChanged += new System.EventHandler(this.rb_singleDay_CheckedChanged);
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.CustomFormat = "dd/MM/yyyy";
            this.dtp_dateTo.Enabled = false;
            this.dtp_dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateTo.Location = new System.Drawing.Point(428, 22);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.Size = new System.Drawing.Size(79, 20);
            this.dtp_dateTo.TabIndex = 3;
            this.dtp_dateTo.ValueChanged += new System.EventHandler(this.dtp_generic_ValueChanged);
            // 
            // lbl_dateTo
            // 
            this.lbl_dateTo.AutoSize = true;
            this.lbl_dateTo.Location = new System.Drawing.Point(390, 26);
            this.lbl_dateTo.Name = "lbl_dateTo";
            this.lbl_dateTo.Size = new System.Drawing.Size(38, 13);
            this.lbl_dateTo.TabIndex = 2;
            this.lbl_dateTo.Text = "Hasta:";
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtp_dateFrom.Enabled = false;
            this.dtp_dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateFrom.Location = new System.Drawing.Point(298, 22);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.Size = new System.Drawing.Size(79, 20);
            this.dtp_dateFrom.TabIndex = 1;
            this.dtp_dateFrom.ValueChanged += new System.EventHandler(this.dtp_generic_ValueChanged);
            // 
            // lbl_dateFrom
            // 
            this.lbl_dateFrom.AutoSize = true;
            this.lbl_dateFrom.Location = new System.Drawing.Point(257, 26);
            this.lbl_dateFrom.Name = "lbl_dateFrom";
            this.lbl_dateFrom.Size = new System.Drawing.Size(41, 13);
            this.lbl_dateFrom.TabIndex = 0;
            this.lbl_dateFrom.Text = "Desde:";
            // 
            // dgv_caja
            // 
            this.dgv_caja.AllowUserToAddRows = false;
            this.dgv_caja.AllowUserToDeleteRows = false;
            this.dgv_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_caja.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_caja.Location = new System.Drawing.Point(6, 71);
            this.dgv_caja.Name = "dgv_caja";
            this.dgv_caja.ReadOnly = true;
            this.dgv_caja.RowHeadersVisible = false;
            this.dgv_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_caja.Size = new System.Drawing.Size(960, 355);
            this.dgv_caja.TabIndex = 3;
            this.dgv_caja.DataSourceChanged += new System.EventHandler(this.dgv_caja_DataSourceChanged);
            this.dgv_caja.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_caja_CellFormatting);
            // 
            // tb_caja
            // 
            this.tb_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_caja.Controls.Add(this.tp_resumen);
            this.tb_caja.Controls.Add(this.tb_detalle);
            this.tb_caja.Location = new System.Drawing.Point(12, 12);
            this.tb_caja.Name = "tb_caja";
            this.tb_caja.SelectedIndex = 0;
            this.tb_caja.Size = new System.Drawing.Size(980, 559);
            this.tb_caja.TabIndex = 4;
            // 
            // tp_resumen
            // 
            this.tp_resumen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_resumen.Controls.Add(this.gb_values);
            this.tp_resumen.Controls.Add(this.gb_dailyInfo);
            this.tp_resumen.Location = new System.Drawing.Point(4, 22);
            this.tp_resumen.Name = "tp_resumen";
            this.tp_resumen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_resumen.Size = new System.Drawing.Size(972, 533);
            this.tp_resumen.TabIndex = 0;
            this.tp_resumen.Text = "Resumen";
            this.tp_resumen.Enter += new System.EventHandler(this.tp_resumen_Enter);
            // 
            // gb_values
            // 
            this.gb_values.Controls.Add(this.lbl_moneyValuesDiferenceValue);
            this.gb_values.Controls.Add(this.lbl_moneyValuesDiference);
            this.gb_values.Controls.Add(this.lbl_moneyValuesTotalValue);
            this.gb_values.Controls.Add(this.lbl_moneyValuesTotal);
            this.gb_values.Controls.Add(this.dgv_moneyValues);
            this.gb_values.Location = new System.Drawing.Point(492, 6);
            this.gb_values.Name = "gb_values";
            this.gb_values.Size = new System.Drawing.Size(474, 245);
            this.gb_values.TabIndex = 1;
            this.gb_values.TabStop = false;
            this.gb_values.Text = "Billetes y Monedas";
            // 
            // lbl_moneyValuesDiferenceValue
            // 
            this.lbl_moneyValuesDiferenceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneyValuesDiferenceValue.Location = new System.Drawing.Point(247, 154);
            this.lbl_moneyValuesDiferenceValue.Name = "lbl_moneyValuesDiferenceValue";
            this.lbl_moneyValuesDiferenceValue.Size = new System.Drawing.Size(221, 23);
            this.lbl_moneyValuesDiferenceValue.TabIndex = 4;
            this.lbl_moneyValuesDiferenceValue.Text = "$0.00";
            this.lbl_moneyValuesDiferenceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_moneyValuesDiference
            // 
            this.lbl_moneyValuesDiference.AutoSize = true;
            this.lbl_moneyValuesDiference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneyValuesDiference.Location = new System.Drawing.Point(303, 118);
            this.lbl_moneyValuesDiference.Name = "lbl_moneyValuesDiference";
            this.lbl_moneyValuesDiference.Size = new System.Drawing.Size(109, 25);
            this.lbl_moneyValuesDiference.TabIndex = 3;
            this.lbl_moneyValuesDiference.Text = "Diferencia";
            this.lbl_moneyValuesDiference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_moneyValuesTotalValue
            // 
            this.lbl_moneyValuesTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneyValuesTotalValue.Location = new System.Drawing.Point(247, 72);
            this.lbl_moneyValuesTotalValue.Name = "lbl_moneyValuesTotalValue";
            this.lbl_moneyValuesTotalValue.Size = new System.Drawing.Size(221, 23);
            this.lbl_moneyValuesTotalValue.TabIndex = 2;
            this.lbl_moneyValuesTotalValue.Text = "$0.00";
            this.lbl_moneyValuesTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_moneyValuesTotal
            // 
            this.lbl_moneyValuesTotal.AutoSize = true;
            this.lbl_moneyValuesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneyValuesTotal.Location = new System.Drawing.Point(327, 38);
            this.lbl_moneyValuesTotal.Name = "lbl_moneyValuesTotal";
            this.lbl_moneyValuesTotal.Size = new System.Drawing.Size(60, 25);
            this.lbl_moneyValuesTotal.TabIndex = 1;
            this.lbl_moneyValuesTotal.Text = "Total";
            this.lbl_moneyValuesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_moneyValues
            // 
            this.dgv_moneyValues.AllowUserToAddRows = false;
            this.dgv_moneyValues.AllowUserToDeleteRows = false;
            this.dgv_moneyValues.AllowUserToResizeColumns = false;
            this.dgv_moneyValues.AllowUserToResizeRows = false;
            this.dgv_moneyValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_moneyValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_moneyValues.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_moneyValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_moneyValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_moneyValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_moneyValues.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_moneyValues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_moneyValues.Location = new System.Drawing.Point(21, 24);
            this.dgv_moneyValues.MultiSelect = false;
            this.dgv_moneyValues.Name = "dgv_moneyValues";
            this.dgv_moneyValues.RowHeadersVisible = false;
            this.dgv_moneyValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_moneyValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_moneyValues.ShowEditingIcon = false;
            this.dgv_moneyValues.Size = new System.Drawing.Size(220, 203);
            this.dgv_moneyValues.TabIndex = 0;
            // 
            // gb_dailyInfo
            // 
            this.gb_dailyInfo.Controls.Add(this.lbl_cajaTurnoTardeValue);
            this.gb_dailyInfo.Controls.Add(this.lbl_cajaTurnoMananaValue);
            this.gb_dailyInfo.Controls.Add(this.lbl_cajaTurnoTarde);
            this.gb_dailyInfo.Controls.Add(this.lbl_cajaTurnoManana);
            this.gb_dailyInfo.Controls.Add(this.lbl_totalEnCajaValue);
            this.gb_dailyInfo.Controls.Add(this.lbl_totalEnCaja);
            this.gb_dailyInfo.Location = new System.Drawing.Point(6, 6);
            this.gb_dailyInfo.Name = "gb_dailyInfo";
            this.gb_dailyInfo.Size = new System.Drawing.Size(474, 245);
            this.gb_dailyInfo.TabIndex = 0;
            this.gb_dailyInfo.TabStop = false;
            this.gb_dailyInfo.Text = "Información Diaria";
            // 
            // tb_detalle
            // 
            this.tb_detalle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tb_detalle.Controls.Add(this.gb_informacionParcial);
            this.tb_detalle.Controls.Add(this.gb_filterType);
            this.tb_detalle.Controls.Add(this.dgv_caja);
            this.tb_detalle.Controls.Add(this.gb_dateRanges);
            this.tb_detalle.Location = new System.Drawing.Point(4, 22);
            this.tb_detalle.Name = "tb_detalle";
            this.tb_detalle.Padding = new System.Windows.Forms.Padding(3);
            this.tb_detalle.Size = new System.Drawing.Size(972, 533);
            this.tb_detalle.TabIndex = 1;
            this.tb_detalle.Text = "Detalle";
            // 
            // gb_informacionParcial
            // 
            this.gb_informacionParcial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_informacionParcial.Location = new System.Drawing.Point(6, 432);
            this.gb_informacionParcial.Name = "gb_informacionParcial";
            this.gb_informacionParcial.Size = new System.Drawing.Size(960, 95);
            this.gb_informacionParcial.TabIndex = 4;
            this.gb_informacionParcial.TabStop = false;
            this.gb_informacionParcial.Text = "Información Parcial";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Location = new System.Drawing.Point(12, 586);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_totalEnCaja
            // 
            this.lbl_totalEnCaja.AutoSize = true;
            this.lbl_totalEnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalEnCaja.Location = new System.Drawing.Point(157, 38);
            this.lbl_totalEnCaja.Name = "lbl_totalEnCaja";
            this.lbl_totalEnCaja.Size = new System.Drawing.Size(160, 25);
            this.lbl_totalEnCaja.TabIndex = 0;
            this.lbl_totalEnCaja.Text = "Total en Caja:";
            // 
            // lbl_totalEnCajaValue
            // 
            this.lbl_totalEnCajaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalEnCajaValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_totalEnCajaValue.Location = new System.Drawing.Point(6, 72);
            this.lbl_totalEnCajaValue.Name = "lbl_totalEnCajaValue";
            this.lbl_totalEnCajaValue.Size = new System.Drawing.Size(462, 34);
            this.lbl_totalEnCajaValue.TabIndex = 1;
            this.lbl_totalEnCajaValue.Text = "$0.00";
            this.lbl_totalEnCajaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cajaTurnoManana
            // 
            this.lbl_cajaTurnoManana.AutoSize = true;
            this.lbl_cajaTurnoManana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajaTurnoManana.Location = new System.Drawing.Point(7, 141);
            this.lbl_cajaTurnoManana.Name = "lbl_cajaTurnoManana";
            this.lbl_cajaTurnoManana.Size = new System.Drawing.Size(226, 25);
            this.lbl_cajaTurnoManana.TabIndex = 2;
            this.lbl_cajaTurnoManana.Text = "Caja Turno Mañana:";
            // 
            // lbl_cajaTurnoTarde
            // 
            this.lbl_cajaTurnoTarde.AutoSize = true;
            this.lbl_cajaTurnoTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajaTurnoTarde.Location = new System.Drawing.Point(30, 181);
            this.lbl_cajaTurnoTarde.Name = "lbl_cajaTurnoTarde";
            this.lbl_cajaTurnoTarde.Size = new System.Drawing.Size(203, 25);
            this.lbl_cajaTurnoTarde.TabIndex = 3;
            this.lbl_cajaTurnoTarde.Text = "Caja Turno Tarde:";
            // 
            // lbl_cajaTurnoMananaValue
            // 
            this.lbl_cajaTurnoMananaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajaTurnoMananaValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_cajaTurnoMananaValue.Location = new System.Drawing.Point(239, 139);
            this.lbl_cajaTurnoMananaValue.Name = "lbl_cajaTurnoMananaValue";
            this.lbl_cajaTurnoMananaValue.Size = new System.Drawing.Size(226, 28);
            this.lbl_cajaTurnoMananaValue.TabIndex = 4;
            this.lbl_cajaTurnoMananaValue.Text = "$0.00";
            this.lbl_cajaTurnoMananaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cajaTurnoTardeValue
            // 
            this.lbl_cajaTurnoTardeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajaTurnoTardeValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_cajaTurnoTardeValue.Location = new System.Drawing.Point(239, 179);
            this.lbl_cajaTurnoTardeValue.Name = "lbl_cajaTurnoTardeValue";
            this.lbl_cajaTurnoTardeValue.Size = new System.Drawing.Size(226, 28);
            this.lbl_cajaTurnoTardeValue.TabIndex = 5;
            this.lbl_cajaTurnoTardeValue.Text = "$0.00";
            this.lbl_cajaTurnoTardeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CajaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_caja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CajaDiaria";
            this.Text = "Caja";
            this.gb_filterType.ResumeLayout(false);
            this.gb_dateRanges.ResumeLayout(false);
            this.gb_dateRanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja)).EndInit();
            this.tb_caja.ResumeLayout(false);
            this.tp_resumen.ResumeLayout(false);
            this.gb_values.ResumeLayout(false);
            this.gb_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_moneyValues)).EndInit();
            this.gb_dailyInfo.ResumeLayout(false);
            this.gb_dailyInfo.PerformLayout();
            this.tb_detalle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_filterType;
        private ComboBox cb_filterType;
        private GroupBox gb_dateRanges;
        private DateTimePicker dtp_dateFrom;
        private Label lbl_dateFrom;
        private DateTimePicker dtp_dateTo;
        private Label lbl_dateTo;
        private DataGridView dgv_caja;
        private RadioButton rb_dateRage;
        private DateTimePicker dtp_singleDay;
        private RadioButton rb_singleDay;
        private TabControl tb_caja;
        private TabPage tp_resumen;
        private TabPage tb_detalle;
        private Button btn_close;
        private GroupBox gb_informacionParcial;
        private GroupBox gb_values;
        private DataGridView dgv_moneyValues;
        private GroupBox gb_dailyInfo;
        private Label lbl_moneyValuesDiferenceValue;
        private Label lbl_moneyValuesDiference;
        private Label lbl_moneyValuesTotalValue;
        private Label lbl_moneyValuesTotal;
        private Label lbl_cajaTurnoTardeValue;
        private Label lbl_cajaTurnoMananaValue;
        private Label lbl_cajaTurnoTarde;
        private Label lbl_cajaTurnoManana;
        private Label lbl_totalEnCajaValue;
        private Label lbl_totalEnCaja;
    }
}