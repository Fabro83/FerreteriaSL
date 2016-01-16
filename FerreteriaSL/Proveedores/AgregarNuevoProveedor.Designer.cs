using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Proveedores
{
    partial class AgregarNuevoProveedor
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_cuit = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(20, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_cuit
            // 
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.Location = new System.Drawing.Point(32, 39);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(35, 13);
            this.lbl_cuit.TabIndex = 7;
            this.lbl_cuit.Text = "CUIT:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(15, 65);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(52, 13);
            this.lbl_phone.TabIndex = 8;
            this.lbl_phone.Text = "Teléfono:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 91);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(55, 13);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Dirección:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(67, 9);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(213, 20);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(67, 61);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(213, 20);
            this.tb_phone.TabIndex = 2;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_cuit
            // 
            this.tb_cuit.Location = new System.Drawing.Point(67, 35);
            this.tb_cuit.Name = "tb_cuit";
            this.tb_cuit.Size = new System.Drawing.Size(213, 20);
            this.tb_cuit.TabIndex = 1;
            this.tb_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(67, 87);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(213, 20);
            this.tb_address.TabIndex = 3;
            this.tb_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(68, 122);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(149, 122);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AgregarNuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(292, 155);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_cuit);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_cuit);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarNuevoProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_name;
        private Label lbl_cuit;
        private Label lbl_phone;
        private Label lbl_address;
        private Button btn_add;
        private Button btn_cancel;
        public TextBox tb_name;
        public TextBox tb_phone;
        public TextBox tb_cuit;
        public TextBox tb_address;
    }
}