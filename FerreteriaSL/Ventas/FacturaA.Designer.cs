using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    partial class FacturaA
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_domicilio = new System.Windows.Forms.TextBox();
            this.txb_cuit = new System.Windows.Forms.TextBox();
            this.txb_condiciones = new System.Windows.Forms.TextBox();
            this.txb_remito = new System.Windows.Forms.TextBox();
            this.txb_impuestos = new System.Windows.Forms.TextBox();
            this.txb_subtotal2 = new System.Windows.Forms.TextBox();
            this.txb_iva = new System.Windows.Forms.TextBox();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal2 = new System.Windows.Forms.Label();
            this.lbl_impuestos = new System.Windows.Forms.Label();
            this.lbl_remito = new System.Windows.Forms.Label();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_condiciones = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_print.Location = new System.Drawing.Point(222, 123);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Imprimir";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(303, 123);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(126, 9);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(168, 20);
            this.txb_nombre.TabIndex = 2;
            // 
            // txb_domicilio
            // 
            this.txb_domicilio.Location = new System.Drawing.Point(387, 9);
            this.txb_domicilio.Name = "txb_domicilio";
            this.txb_domicilio.Size = new System.Drawing.Size(203, 20);
            this.txb_domicilio.TabIndex = 3;
            // 
            // txb_cuit
            // 
            this.txb_cuit.Location = new System.Drawing.Point(387, 35);
            this.txb_cuit.Name = "txb_cuit";
            this.txb_cuit.Size = new System.Drawing.Size(100, 20);
            this.txb_cuit.TabIndex = 4;
            // 
            // txb_condiciones
            // 
            this.txb_condiciones.Location = new System.Drawing.Point(126, 61);
            this.txb_condiciones.Name = "txb_condiciones";
            this.txb_condiciones.Size = new System.Drawing.Size(168, 20);
            this.txb_condiciones.TabIndex = 5;
            this.txb_condiciones.Text = "Efectivo";
            // 
            // txb_remito
            // 
            this.txb_remito.Location = new System.Drawing.Point(387, 61);
            this.txb_remito.Name = "txb_remito";
            this.txb_remito.Size = new System.Drawing.Size(100, 20);
            this.txb_remito.TabIndex = 6;
            // 
            // txb_impuestos
            // 
            this.txb_impuestos.Location = new System.Drawing.Point(126, 87);
            this.txb_impuestos.Name = "txb_impuestos";
            this.txb_impuestos.Size = new System.Drawing.Size(62, 20);
            this.txb_impuestos.TabIndex = 7;
            this.txb_impuestos.Text = "-";
            // 
            // txb_subtotal2
            // 
            this.txb_subtotal2.Location = new System.Drawing.Point(387, 87);
            this.txb_subtotal2.Name = "txb_subtotal2";
            this.txb_subtotal2.Size = new System.Drawing.Size(100, 20);
            this.txb_subtotal2.TabIndex = 8;
            this.txb_subtotal2.Text = "-";
            // 
            // txb_iva
            // 
            this.txb_iva.Location = new System.Drawing.Point(126, 35);
            this.txb_iva.Name = "txb_iva";
            this.txb_iva.Size = new System.Drawing.Size(62, 20);
            this.txb_iva.TabIndex = 9;
            this.txb_iva.Text = "21%";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(98, 39);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(27, 13);
            this.lbl_iva.TabIndex = 10;
            this.lbl_iva.Text = "IVA:";
            // 
            // lbl_subtotal2
            // 
            this.lbl_subtotal2.AutoSize = true;
            this.lbl_subtotal2.Location = new System.Drawing.Point(332, 91);
            this.lbl_subtotal2.Name = "lbl_subtotal2";
            this.lbl_subtotal2.Size = new System.Drawing.Size(49, 13);
            this.lbl_subtotal2.TabIndex = 11;
            this.lbl_subtotal2.Text = "Subtotal:";
            // 
            // lbl_impuestos
            // 
            this.lbl_impuestos.AutoSize = true;
            this.lbl_impuestos.Location = new System.Drawing.Point(67, 91);
            this.lbl_impuestos.Name = "lbl_impuestos";
            this.lbl_impuestos.Size = new System.Drawing.Size(58, 13);
            this.lbl_impuestos.TabIndex = 12;
            this.lbl_impuestos.Text = "Impuestos:";
            // 
            // lbl_remito
            // 
            this.lbl_remito.AutoSize = true;
            this.lbl_remito.Location = new System.Drawing.Point(323, 65);
            this.lbl_remito.Name = "lbl_remito";
            this.lbl_remito.Size = new System.Drawing.Size(58, 13);
            this.lbl_remito.TabIndex = 13;
            this.lbl_remito.Text = "Remito Nº:";
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Location = new System.Drawing.Point(346, 39);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(35, 13);
            this.lbl_cuit.TabIndex = 14;
            this.lbl_cuit.Text = "CUIT:";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(329, 13);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(52, 13);
            this.lbl_domicilio.TabIndex = 15;
            this.lbl_domicilio.Text = "Domicilio:";
            // 
            // lbl_condiciones
            // 
            this.lbl_condiciones.AutoSize = true;
            this.lbl_condiciones.Location = new System.Drawing.Point(11, 65);
            this.lbl_condiciones.Name = "lbl_condiciones";
            this.lbl_condiciones.Size = new System.Drawing.Size(114, 13);
            this.lbl_condiciones.TabIndex = 16;
            this.lbl_condiciones.Text = "Condiciones de Venta:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(71, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 17;
            this.lbl_nombre.Text = "Señor/es:";
            // 
            // FacturaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(601, 167);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_condiciones);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.lbl_cuit);
            this.Controls.Add(this.lbl_remito);
            this.Controls.Add(this.lbl_impuestos);
            this.Controls.Add(this.lbl_subtotal2);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.txb_iva);
            this.Controls.Add(this.txb_subtotal2);
            this.Controls.Add(this.txb_impuestos);
            this.Controls.Add(this.txb_remito);
            this.Controls.Add(this.txb_condiciones);
            this.Controls.Add(this.txb_cuit);
            this.Controls.Add(this.txb_domicilio);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_print);
            this.Name = "FacturaA";
            this.Text = "Datos de Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_print;
        private Button btn_cancel;
        private Label lbl_iva;
        private Label lbl_subtotal2;
        private Label lbl_impuestos;
        private Label lbl_remito;
        private Label lbl_cuit;
        private Label lbl_domicilio;
        private Label lbl_condiciones;
        private Label lbl_nombre;
        public TextBox txb_nombre;
        public TextBox txb_domicilio;
        public TextBox txb_cuit;
        public TextBox txb_condiciones;
        public TextBox txb_remito;
        public TextBox txb_impuestos;
        public TextBox txb_subtotal2;
        public TextBox txb_iva;
    }
}