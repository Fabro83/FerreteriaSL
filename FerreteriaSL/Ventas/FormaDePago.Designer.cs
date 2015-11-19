using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class FormaDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaDePago));
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.col_formaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_payingType = new System.Windows.Forms.ComboBox();
            this.cb_extraParameters = new System.Windows.Forms.ComboBox();
            this.lbl_formaDePago = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_infoExtra = new System.Windows.Forms.Label();
            this.lbl_payingTypesAtUse = new System.Windows.Forms.Label();
            this.btn_addPayment = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_totalValue = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_payments
            // 
            this.dgv_payments.AllowUserToAddRows = false;
            this.dgv_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_formaDePago,
            this.col_info,
            this.col_recargo,
            this.col_monto});
            this.dgv_payments.Location = new System.Drawing.Point(23, 122);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.ReadOnly = true;
            this.dgv_payments.RowHeadersVisible = false;
            this.dgv_payments.Size = new System.Drawing.Size(476, 142);
            this.dgv_payments.TabIndex = 0;
            // 
            // col_formaDePago
            // 
            this.col_formaDePago.HeaderText = "Forma de Pago";
            this.col_formaDePago.Name = "col_formaDePago";
            this.col_formaDePago.ReadOnly = true;
            // 
            // col_info
            // 
            this.col_info.HeaderText = "Información";
            this.col_info.Name = "col_info";
            this.col_info.ReadOnly = true;
            // 
            // col_recargo
            // 
            this.col_recargo.HeaderText = "Recargo";
            this.col_recargo.Name = "col_recargo";
            this.col_recargo.ReadOnly = true;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // cb_payingType
            // 
            this.cb_payingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_payingType.FormattingEnabled = true;
            this.cb_payingType.Location = new System.Drawing.Point(23, 29);
            this.cb_payingType.Name = "cb_payingType";
            this.cb_payingType.Size = new System.Drawing.Size(179, 21);
            this.cb_payingType.TabIndex = 1;
            this.cb_payingType.SelectedIndexChanged += new System.EventHandler(this.cb_payingType_SelectedIndexChanged);
            // 
            // cb_extraParameters
            // 
            this.cb_extraParameters.Enabled = false;
            this.cb_extraParameters.FormattingEnabled = true;
            this.cb_extraParameters.Location = new System.Drawing.Point(23, 71);
            this.cb_extraParameters.Name = "cb_extraParameters";
            this.cb_extraParameters.Size = new System.Drawing.Size(179, 21);
            this.cb_extraParameters.TabIndex = 2;
            // 
            // lbl_formaDePago
            // 
            this.lbl_formaDePago.AutoSize = true;
            this.lbl_formaDePago.Location = new System.Drawing.Point(73, 9);
            this.lbl_formaDePago.Name = "lbl_formaDePago";
            this.lbl_formaDePago.Size = new System.Drawing.Size(79, 13);
            this.lbl_formaDePago.TabIndex = 3;
            this.lbl_formaDePago.Text = "Forma de Pago";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(290, 9);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(37, 13);
            this.lbl_monto.TabIndex = 5;
            this.lbl_monto.Text = "Monto";
            // 
            // lbl_infoExtra
            // 
            this.lbl_infoExtra.Location = new System.Drawing.Point(208, 75);
            this.lbl_infoExtra.Name = "lbl_infoExtra";
            this.lbl_infoExtra.Size = new System.Drawing.Size(204, 13);
            this.lbl_infoExtra.TabIndex = 6;
            this.lbl_infoExtra.Text = "Información adicional.";
            this.lbl_infoExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_payingTypesAtUse
            // 
            this.lbl_payingTypesAtUse.Location = new System.Drawing.Point(200, 106);
            this.lbl_payingTypesAtUse.Name = "lbl_payingTypesAtUse";
            this.lbl_payingTypesAtUse.Size = new System.Drawing.Size(123, 13);
            this.lbl_payingTypesAtUse.TabIndex = 0;
            this.lbl_payingTypesAtUse.Text = "Formas de pago a usar";
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.Location = new System.Drawing.Point(418, 29);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(81, 63);
            this.btn_addPayment.TabIndex = 7;
            this.btn_addPayment.Text = "Agregar Forma de Pago";
            this.btn_addPayment.UseVisualStyleBackColor = true;
            // 
            // btn_continuar
            // 
            this.btn_continuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_continuar.Location = new System.Drawing.Point(424, 318);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_continuar.TabIndex = 8;
            this.btn_continuar.Text = "Continuar >>";
            this.btn_continuar.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(23, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_totalValue
            // 
            this.lbl_totalValue.AutoSize = true;
            this.lbl_totalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalValue.Location = new System.Drawing.Point(241, 0);
            this.lbl_totalValue.Name = "lbl_totalValue";
            this.lbl_totalValue.Size = new System.Drawing.Size(232, 31);
            this.lbl_totalValue.TabIndex = 10;
            this.lbl_totalValue.Text = "$0,00";
            this.lbl_totalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(3, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(232, 31);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "Total:";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_total, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_totalValue, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 281);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 31);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(523, 357);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.btn_addPayment);
            this.Controls.Add(this.lbl_payingTypesAtUse);
            this.Controls.Add(this.lbl_infoExtra);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_formaDePago);
            this.Controls.Add(this.cb_extraParameters);
            this.Controls.Add(this.cb_payingType);
            this.Controls.Add(this.dgv_payments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_payments;
        private ComboBox cb_payingType;
        private ComboBox cb_extraParameters;
        private Label lbl_formaDePago;
        private TextBox textBox1;
        private Label lbl_monto;
        private Label lbl_infoExtra;
        private Label lbl_payingTypesAtUse;
        private Button btn_addPayment;
        private Button btn_continuar;
        private Button btn_cancel;
        private DataGridViewTextBoxColumn col_formaDePago;
        private DataGridViewTextBoxColumn col_info;
        private DataGridViewTextBoxColumn col_recargo;
        private DataGridViewTextBoxColumn col_monto;
        private Label lbl_totalValue;
        private Label lbl_total;
        private TableLayoutPanel tableLayoutPanel1;
    }
}