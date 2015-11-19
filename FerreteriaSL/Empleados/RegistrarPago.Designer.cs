using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Empleados
{
    partial class RegistrarPago
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
            this.dtp_registerDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_registerDate = new System.Windows.Forms.Label();
            this.lbl_monthToPay = new System.Windows.Forms.Label();
            this.lbl_yearToPay = new System.Windows.Forms.Label();
            this.cb_monthToPay = new System.Windows.Forms.ComboBox();
            this.nud_yearToPay = new System.Windows.Forms.NumericUpDown();
            this.lbl_mountToPay = new System.Windows.Forms.Label();
            this.nud_mountToPay = new System.Windows.Forms.NumericUpDown();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_observation = new System.Windows.Forms.Label();
            this.tb_observation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yearToPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mountToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_registerDate
            // 
            this.dtp_registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_registerDate.Location = new System.Drawing.Point(115, 5);
            this.dtp_registerDate.Name = "dtp_registerDate";
            this.dtp_registerDate.Size = new System.Drawing.Size(82, 20);
            this.dtp_registerDate.TabIndex = 0;
            this.dtp_registerDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // lbl_registerDate
            // 
            this.lbl_registerDate.AutoSize = true;
            this.lbl_registerDate.Location = new System.Drawing.Point(18, 9);
            this.lbl_registerDate.Name = "lbl_registerDate";
            this.lbl_registerDate.Size = new System.Drawing.Size(97, 13);
            this.lbl_registerDate.TabIndex = 7;
            this.lbl_registerDate.Text = "Fecha de Registro:";
            // 
            // lbl_monthToPay
            // 
            this.lbl_monthToPay.AutoSize = true;
            this.lbl_monthToPay.Location = new System.Drawing.Point(45, 34);
            this.lbl_monthToPay.Name = "lbl_monthToPay";
            this.lbl_monthToPay.Size = new System.Drawing.Size(70, 13);
            this.lbl_monthToPay.TabIndex = 8;
            this.lbl_monthToPay.Text = "Mes a Pagar:";
            // 
            // lbl_yearToPay
            // 
            this.lbl_yearToPay.AutoSize = true;
            this.lbl_yearToPay.Location = new System.Drawing.Point(46, 59);
            this.lbl_yearToPay.Name = "lbl_yearToPay";
            this.lbl_yearToPay.Size = new System.Drawing.Size(69, 13);
            this.lbl_yearToPay.TabIndex = 9;
            this.lbl_yearToPay.Text = "Año a Pagar:";
            // 
            // cb_monthToPay
            // 
            this.cb_monthToPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_monthToPay.FormattingEnabled = true;
            this.cb_monthToPay.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cb_monthToPay.Location = new System.Drawing.Point(115, 30);
            this.cb_monthToPay.Name = "cb_monthToPay";
            this.cb_monthToPay.Size = new System.Drawing.Size(120, 21);
            this.cb_monthToPay.TabIndex = 1;
            this.cb_monthToPay.SelectedIndexChanged += new System.EventHandler(this.cb_monthToPay_SelectedIndexChanged);
            // 
            // nud_yearToPay
            // 
            this.nud_yearToPay.Location = new System.Drawing.Point(115, 55);
            this.nud_yearToPay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_yearToPay.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_yearToPay.Name = "nud_yearToPay";
            this.nud_yearToPay.Size = new System.Drawing.Size(69, 20);
            this.nud_yearToPay.TabIndex = 2;
            this.nud_yearToPay.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_yearToPay.ValueChanged += new System.EventHandler(this.nud_yearToPay_ValueChanged);
            // 
            // lbl_mountToPay
            // 
            this.lbl_mountToPay.AutoSize = true;
            this.lbl_mountToPay.Location = new System.Drawing.Point(75, 82);
            this.lbl_mountToPay.Name = "lbl_mountToPay";
            this.lbl_mountToPay.Size = new System.Drawing.Size(40, 13);
            this.lbl_mountToPay.TabIndex = 10;
            this.lbl_mountToPay.Text = "Monto:";
            // 
            // nud_mountToPay
            // 
            this.nud_mountToPay.DecimalPlaces = 2;
            this.nud_mountToPay.Location = new System.Drawing.Point(115, 78);
            this.nud_mountToPay.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_mountToPay.Name = "nud_mountToPay";
            this.nud_mountToPay.Size = new System.Drawing.Size(120, 20);
            this.nud_mountToPay.TabIndex = 3;
            this.nud_mountToPay.ThousandsSeparator = true;
            this.nud_mountToPay.ValueChanged += new System.EventHandler(this.nud_mountToPay_ValueChanged);
            this.nud_mountToPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_mountToPay_KeyPress);
            // 
            // btn_register
            // 
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_register.Enabled = false;
            this.btn_register.Location = new System.Drawing.Point(48, 196);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Registrar";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(130, 196);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_observation
            // 
            this.lbl_observation.AutoSize = true;
            this.lbl_observation.Location = new System.Drawing.Point(45, 105);
            this.lbl_observation.Name = "lbl_observation";
            this.lbl_observation.Size = new System.Drawing.Size(70, 13);
            this.lbl_observation.TabIndex = 11;
            this.lbl_observation.Text = "Observación:";
            // 
            // tb_observation
            // 
            this.tb_observation.Location = new System.Drawing.Point(21, 125);
            this.tb_observation.Multiline = true;
            this.tb_observation.Name = "tb_observation";
            this.tb_observation.Size = new System.Drawing.Size(214, 65);
            this.tb_observation.TabIndex = 4;
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(252, 231);
            this.ControlBox = false;
            this.Controls.Add(this.tb_observation);
            this.Controls.Add(this.lbl_observation);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.nud_mountToPay);
            this.Controls.Add(this.lbl_mountToPay);
            this.Controls.Add(this.nud_yearToPay);
            this.Controls.Add(this.cb_monthToPay);
            this.Controls.Add(this.lbl_yearToPay);
            this.Controls.Add(this.lbl_monthToPay);
            this.Controls.Add(this.lbl_registerDate);
            this.Controls.Add(this.dtp_registerDate);
            this.Name = "RegistrarPago";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Pago";
            ((System.ComponentModel.ISupportInitialize)(this.nud_yearToPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mountToPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_registerDate;
        private Label lbl_monthToPay;
        private Label lbl_yearToPay;
        private Label lbl_mountToPay;
        private Button btn_register;
        private Button btn_cancel;
        public DateTimePicker dtp_registerDate;
        public ComboBox cb_monthToPay;
        public NumericUpDown nud_yearToPay;
        public NumericUpDown nud_mountToPay;
        private Label lbl_observation;
        public TextBox tb_observation;
    }
}