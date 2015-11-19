using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Ubicación
{
    partial class NombreSeccion
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_abb = new System.Windows.Forms.Label();
            this.txb_abb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(57, 74);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(138, 74);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(90, 11);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(161, 20);
            this.txb_name.TabIndex = 0;
            this.txb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_name_KeyPress);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(38, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_abb
            // 
            this.lbl_abb.AutoSize = true;
            this.lbl_abb.Location = new System.Drawing.Point(19, 41);
            this.lbl_abb.Name = "lbl_abb";
            this.lbl_abb.Size = new System.Drawing.Size(66, 13);
            this.lbl_abb.TabIndex = 5;
            this.lbl_abb.Text = "Abreviación:";
            // 
            // txb_abb
            // 
            this.txb_abb.Location = new System.Drawing.Point(90, 37);
            this.txb_abb.Name = "txb_abb";
            this.txb_abb.Size = new System.Drawing.Size(80, 20);
            this.txb_abb.TabIndex = 1;
            this.txb_abb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_name_KeyPress);
            // 
            // Nombre_Seccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 108);
            this.ControlBox = false;
            this.Controls.Add(this.txb_abb);
            this.Controls.Add(this.lbl_abb);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NombreSeccion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nombrar Sección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ok;
        private Button btn_cancel;
        public TextBox txb_name;
        private Label lbl_name;
        private Label lbl_abb;
        public TextBox txb_abb;
    }
}