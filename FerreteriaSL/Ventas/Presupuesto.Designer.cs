namespace FerreteriaSL.Ventas
{
    partial class Presupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_domicilio = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.chb_guardar = new System.Windows.Forms.CheckBox();
            this.lbl_copias = new System.Windows.Forms.Label();
            this.nud_copias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_copias)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_imprimir.Location = new System.Drawing.Point(170, 159);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(251, 159);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(79, 24);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(74, 52);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(49, 13);
            this.lbl_domicilio.TabIndex = 3;
            this.lbl_domicilio.Text = "Domicilio";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(86, 80);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(128, 20);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(177, 20);
            this.txb_nombre.TabIndex = 6;
            // 
            // txb_domicilio
            // 
            this.txb_domicilio.Location = new System.Drawing.Point(128, 48);
            this.txb_domicilio.Name = "txb_domicilio";
            this.txb_domicilio.Size = new System.Drawing.Size(311, 20);
            this.txb_domicilio.TabIndex = 7;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(128, 76);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha.TabIndex = 8;
            // 
            // chb_guardar
            // 
            this.chb_guardar.AutoSize = true;
            this.chb_guardar.Checked = true;
            this.chb_guardar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_guardar.Location = new System.Drawing.Point(146, 132);
            this.chb_guardar.Name = "chb_guardar";
            this.chb_guardar.Size = new System.Drawing.Size(205, 17);
            this.chb_guardar.TabIndex = 9;
            this.chb_guardar.Text = "¿Guardar y generar codigo de barras?";
            this.chb_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_copias
            // 
            this.lbl_copias.AutoSize = true;
            this.lbl_copias.Location = new System.Drawing.Point(37, 108);
            this.lbl_copias.Name = "lbl_copias";
            this.lbl_copias.Size = new System.Drawing.Size(86, 13);
            this.lbl_copias.TabIndex = 10;
            this.lbl_copias.Text = "Copias a Imprimir";
            // 
            // nud_copias
            // 
            this.nud_copias.Location = new System.Drawing.Point(128, 104);
            this.nud_copias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_copias.Name = "nud_copias";
            this.nud_copias.Size = new System.Drawing.Size(48, 20);
            this.nud_copias.TabIndex = 11;
            this.nud_copias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Presupuesto
            // 
            this.AcceptButton = this.btn_imprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(497, 197);
            this.ControlBox = false;
            this.Controls.Add(this.nud_copias);
            this.Controls.Add(this.lbl_copias);
            this.Controls.Add(this.chb_guardar);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txb_domicilio);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Name = "Presupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.nud_copias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox txb_nombre;
        public System.Windows.Forms.TextBox txb_domicilio;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
        public System.Windows.Forms.CheckBox chb_guardar;
        private System.Windows.Forms.Label lbl_copias;
        public System.Windows.Forms.NumericUpDown nud_copias;
    }
}