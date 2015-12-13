namespace FerreteriaSL
{
    partial class AgregarNuevoUsuario
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_userPassword = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_userPassword = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(17, 16);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(101, 13);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "Nombre de Usuario:";
            // 
            // lbl_userPassword
            // 
            this.lbl_userPassword.AutoSize = true;
            this.lbl_userPassword.Location = new System.Drawing.Point(54, 42);
            this.lbl_userPassword.Name = "lbl_userPassword";
            this.lbl_userPassword.Size = new System.Drawing.Size(64, 13);
            this.lbl_userPassword.TabIndex = 5;
            this.lbl_userPassword.Text = "Contraseña:";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(124, 12);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(146, 20);
            this.tb_userName.TabIndex = 0;
            this.tb_userName.TextChanged += new System.EventHandler(this.tb_userName_TextChanged);
            this.tb_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_userPassword
            // 
            this.tb_userPassword.Location = new System.Drawing.Point(124, 38);
            this.tb_userPassword.Name = "tb_userPassword";
            this.tb_userPassword.Size = new System.Drawing.Size(146, 20);
            this.tb_userPassword.TabIndex = 1;
            this.tb_userPassword.TextChanged += new System.EventHandler(this.tb_userPassword_TextChanged);
            this.tb_userPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(65, 75);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(146, 75);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // AgregarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(286, 111);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_userPassword);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lbl_userPassword);
            this.Controls.Add(this.lbl_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarNuevoUsuario";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_userPassword;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_userName;
        public System.Windows.Forms.TextBox tb_userPassword;
    }
}