using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.RegistroVentas
{
    partial class Cajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajas));
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.dgv_caja = new System.Windows.Forms.DataGridView();
            this.lbl_dateFrom = new System.Windows.Forms.Label();
            this.lbl_dateTo = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_totalImporte = new System.Windows.Forms.Label();
            this.lbl_totalDescuentos = new System.Windows.Forms.Label();
            this.lbl_porcentajeTotal = new System.Windows.Forms.Label();
            this.lbl_totalImporteValue = new System.Windows.Forms.Label();
            this.lbl_totalDescuentosValue = new System.Windows.Forms.Label();
            this.lbl_porcentajeTotalValue = new System.Windows.Forms.Label();
            this.tlp_statistics = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mediaPorcentajeDescuentos = new System.Windows.Forms.Label();
            this.lbl_mediaPorcentajeDescuentosValue = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_ganacia = new System.Windows.Forms.Label();
            this.lbl_gananciaValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja)).BeginInit();
            this.tlp_statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.Location = new System.Drawing.Point(98, 5);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateFrom.TabIndex = 0;
            this.dtp_dateFrom.ValueChanged += new System.EventHandler(this.dtp_dateFrom_ValueChanged);
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.Location = new System.Drawing.Point(393, 5);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateTo.TabIndex = 1;
            this.dtp_dateTo.ValueChanged += new System.EventHandler(this.dtp_dateTo_ValueChanged);
            // 
            // cb_user
            // 
            this.cb_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(663, 5);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(121, 21);
            this.cb_user.TabIndex = 2;
            this.cb_user.SelectedIndexChanged += new System.EventHandler(this.cb_user_SelectedIndexChanged);
            // 
            // dgv_caja
            // 
            this.dgv_caja.AllowUserToAddRows = false;
            this.dgv_caja.AllowUserToDeleteRows = false;
            this.dgv_caja.AllowUserToResizeRows = false;
            this.dgv_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_caja.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_caja.Location = new System.Drawing.Point(12, 38);
            this.dgv_caja.Name = "dgv_caja";
            this.dgv_caja.ReadOnly = true;
            this.dgv_caja.RowHeadersVisible = false;
            this.dgv_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_caja.Size = new System.Drawing.Size(1130, 392);
            this.dgv_caja.TabIndex = 3;
            this.dgv_caja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_caja_CellDoubleClick);
            this.dgv_caja.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_caja_CellFormatting);
            // 
            // lbl_dateFrom
            // 
            this.lbl_dateFrom.AutoSize = true;
            this.lbl_dateFrom.Location = new System.Drawing.Point(18, 9);
            this.lbl_dateFrom.Name = "lbl_dateFrom";
            this.lbl_dateFrom.Size = new System.Drawing.Size(74, 13);
            this.lbl_dateFrom.TabIndex = 4;
            this.lbl_dateFrom.Text = "Fecha Desde:";
            // 
            // lbl_dateTo
            // 
            this.lbl_dateTo.AutoSize = true;
            this.lbl_dateTo.Location = new System.Drawing.Point(317, 9);
            this.lbl_dateTo.Name = "lbl_dateTo";
            this.lbl_dateTo.Size = new System.Drawing.Size(71, 13);
            this.lbl_dateTo.TabIndex = 5;
            this.lbl_dateTo.Text = "Fecha Hasta:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(611, 9);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(46, 13);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Usuario:";
            // 
            // lbl_totalImporte
            // 
            this.lbl_totalImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalImporte.AutoSize = true;
            this.lbl_totalImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_totalImporte.Location = new System.Drawing.Point(67, 0);
            this.lbl_totalImporte.Name = "lbl_totalImporte";
            this.lbl_totalImporte.Size = new System.Drawing.Size(194, 15);
            this.lbl_totalImporte.TabIndex = 7;
            this.lbl_totalImporte.Text = "Total Importe";
            this.lbl_totalImporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_totalDescuentos
            // 
            this.lbl_totalDescuentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalDescuentos.AutoSize = true;
            this.lbl_totalDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_totalDescuentos.Location = new System.Drawing.Point(267, 0);
            this.lbl_totalDescuentos.Name = "lbl_totalDescuentos";
            this.lbl_totalDescuentos.Size = new System.Drawing.Size(194, 15);
            this.lbl_totalDescuentos.TabIndex = 8;
            this.lbl_totalDescuentos.Text = "Total Descuentos";
            this.lbl_totalDescuentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_porcentajeTotal
            // 
            this.lbl_porcentajeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_porcentajeTotal.AutoSize = true;
            this.lbl_porcentajeTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_porcentajeTotal.Location = new System.Drawing.Point(467, 0);
            this.lbl_porcentajeTotal.Name = "lbl_porcentajeTotal";
            this.lbl_porcentajeTotal.Size = new System.Drawing.Size(194, 15);
            this.lbl_porcentajeTotal.TabIndex = 9;
            this.lbl_porcentajeTotal.Text = "Procentaje Total de Descuentos";
            this.lbl_porcentajeTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_totalImporteValue
            // 
            this.lbl_totalImporteValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalImporteValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_totalImporteValue.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalImporteValue.Location = new System.Drawing.Point(67, 15);
            this.lbl_totalImporteValue.Name = "lbl_totalImporteValue";
            this.lbl_totalImporteValue.Size = new System.Drawing.Size(194, 36);
            this.lbl_totalImporteValue.TabIndex = 10;
            this.lbl_totalImporteValue.Text = "$0.00";
            this.lbl_totalImporteValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalDescuentosValue
            // 
            this.lbl_totalDescuentosValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalDescuentosValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_totalDescuentosValue.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalDescuentosValue.Location = new System.Drawing.Point(267, 15);
            this.lbl_totalDescuentosValue.Name = "lbl_totalDescuentosValue";
            this.lbl_totalDescuentosValue.Size = new System.Drawing.Size(194, 36);
            this.lbl_totalDescuentosValue.TabIndex = 11;
            this.lbl_totalDescuentosValue.Text = "$0.00";
            this.lbl_totalDescuentosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_porcentajeTotalValue
            // 
            this.lbl_porcentajeTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_porcentajeTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_porcentajeTotalValue.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcentajeTotalValue.Location = new System.Drawing.Point(467, 15);
            this.lbl_porcentajeTotalValue.Name = "lbl_porcentajeTotalValue";
            this.lbl_porcentajeTotalValue.Size = new System.Drawing.Size(194, 36);
            this.lbl_porcentajeTotalValue.TabIndex = 12;
            this.lbl_porcentajeTotalValue.Text = "0.00%";
            this.lbl_porcentajeTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_statistics
            // 
            this.tlp_statistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_statistics.ColumnCount = 7;
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_statistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_statistics.Controls.Add(this.lbl_totalDescuentos, 2, 0);
            this.tlp_statistics.Controls.Add(this.lbl_totalImporte, 1, 0);
            this.tlp_statistics.Controls.Add(this.lbl_totalImporteValue, 1, 1);
            this.tlp_statistics.Controls.Add(this.lbl_totalDescuentosValue, 2, 1);
            this.tlp_statistics.Controls.Add(this.lbl_porcentajeTotalValue, 3, 1);
            this.tlp_statistics.Controls.Add(this.lbl_porcentajeTotal, 3, 0);
            this.tlp_statistics.Controls.Add(this.lbl_mediaPorcentajeDescuentos, 4, 0);
            this.tlp_statistics.Controls.Add(this.lbl_mediaPorcentajeDescuentosValue, 4, 1);
            this.tlp_statistics.Controls.Add(this.lbl_ganacia, 5, 0);
            this.tlp_statistics.Controls.Add(this.lbl_gananciaValue, 5, 1);
            this.tlp_statistics.Location = new System.Drawing.Point(13, 436);
            this.tlp_statistics.Name = "tlp_statistics";
            this.tlp_statistics.RowCount = 2;
            this.tlp_statistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_statistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_statistics.Size = new System.Drawing.Size(1129, 51);
            this.tlp_statistics.TabIndex = 13;
            // 
            // lbl_mediaPorcentajeDescuentos
            // 
            this.lbl_mediaPorcentajeDescuentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mediaPorcentajeDescuentos.AutoSize = true;
            this.lbl_mediaPorcentajeDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mediaPorcentajeDescuentos.Location = new System.Drawing.Point(667, 0);
            this.lbl_mediaPorcentajeDescuentos.Name = "lbl_mediaPorcentajeDescuentos";
            this.lbl_mediaPorcentajeDescuentos.Size = new System.Drawing.Size(194, 15);
            this.lbl_mediaPorcentajeDescuentos.TabIndex = 13;
            this.lbl_mediaPorcentajeDescuentos.Text = "Media de Porcentaje en Descuentos";
            this.lbl_mediaPorcentajeDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mediaPorcentajeDescuentosValue
            // 
            this.lbl_mediaPorcentajeDescuentosValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mediaPorcentajeDescuentosValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mediaPorcentajeDescuentosValue.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mediaPorcentajeDescuentosValue.Location = new System.Drawing.Point(667, 15);
            this.lbl_mediaPorcentajeDescuentosValue.Name = "lbl_mediaPorcentajeDescuentosValue";
            this.lbl_mediaPorcentajeDescuentosValue.Size = new System.Drawing.Size(194, 36);
            this.lbl_mediaPorcentajeDescuentosValue.TabIndex = 14;
            this.lbl_mediaPorcentajeDescuentosValue.Text = "0.00%";
            this.lbl_mediaPorcentajeDescuentosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Location = new System.Drawing.Point(12, 493);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_ganacia
            // 
            this.lbl_ganacia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ganacia.AutoSize = true;
            this.lbl_ganacia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ganacia.Location = new System.Drawing.Point(867, 0);
            this.lbl_ganacia.Name = "lbl_ganacia";
            this.lbl_ganacia.Size = new System.Drawing.Size(194, 15);
            this.lbl_ganacia.TabIndex = 15;
            this.lbl_ganacia.Text = "Ganancia (sin descuentos)";
            this.lbl_ganacia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_gananciaValue
            // 
            this.lbl_gananciaValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gananciaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_gananciaValue.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gananciaValue.Location = new System.Drawing.Point(867, 15);
            this.lbl_gananciaValue.Name = "lbl_gananciaValue";
            this.lbl_gananciaValue.Size = new System.Drawing.Size(194, 36);
            this.lbl_gananciaValue.TabIndex = 16;
            this.lbl_gananciaValue.Text = "$0.00";
            this.lbl_gananciaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1154, 525);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tlp_statistics);
            this.Controls.Add(this.lbl_dateFrom);
            this.Controls.Add(this.dtp_dateFrom);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_dateTo);
            this.Controls.Add(this.dgv_caja);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.dtp_dateTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cajas";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caja)).EndInit();
            this.tlp_statistics.ResumeLayout(false);
            this.tlp_statistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_dateFrom;
        private DateTimePicker dtp_dateTo;
        private ComboBox cb_user;
        private DataGridView dgv_caja;
        private Label lbl_dateFrom;
        private Label lbl_dateTo;
        private Label lbl_user;
        private Label lbl_totalImporte;
        private Label lbl_totalDescuentos;
        private Label lbl_porcentajeTotal;
        private Label lbl_totalImporteValue;
        private Label lbl_totalDescuentosValue;
        private Label lbl_porcentajeTotalValue;
        private TableLayoutPanel tlp_statistics;
        private Button btn_close;
        private Label lbl_mediaPorcentajeDescuentos;
        private Label lbl_mediaPorcentajeDescuentosValue;
        private Label lbl_ganacia;
        private Label lbl_gananciaValue;

    }
}