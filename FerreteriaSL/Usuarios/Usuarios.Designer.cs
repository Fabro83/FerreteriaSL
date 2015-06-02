namespace FerreteriaSL
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.lb_users = new System.Windows.Forms.ListBox();
            this.gb_userData = new System.Windows.Forms.GroupBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.lbl_employePositionValue = new System.Windows.Forms.Label();
            this.lbl_employePhoneValue = new System.Windows.Forms.Label();
            this.lbl_employeAddressValue = new System.Windows.Forms.Label();
            this.lbl_employeDNIValue = new System.Windows.Forms.Label();
            this.lbl_employeNameValue = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_employePosition = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_employePhone = new System.Windows.Forms.Label();
            this.lbl_employeAddress = new System.Windows.Forms.Label();
            this.lbl_employeName = new System.Windows.Forms.Label();
            this.cb_employe = new System.Windows.Forms.ComboBox();
            this.lbl_employe = new System.Windows.Forms.Label();
            this.btn_togglePassword = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lbl_permissions = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addNewUSer = new System.Windows.Forms.Button();
            this.clb_permissions = new System.Windows.Forms.CheckedListBox();
            this.gb_userData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_users
            // 
            this.lb_users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_users.FormattingEnabled = true;
            this.lb_users.Location = new System.Drawing.Point(12, 12);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(191, 394);
            this.lb_users.TabIndex = 0;
            this.lb_users.SelectedIndexChanged += new System.EventHandler(this.lb_users_SelectedIndexChanged);
            // 
            // gb_userData
            // 
            this.gb_userData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_userData.Controls.Add(this.clb_permissions);
            this.gb_userData.Controls.Add(this.btn_deleteUser);
            this.gb_userData.Controls.Add(this.lbl_employePositionValue);
            this.gb_userData.Controls.Add(this.lbl_employePhoneValue);
            this.gb_userData.Controls.Add(this.lbl_employeAddressValue);
            this.gb_userData.Controls.Add(this.lbl_employeDNIValue);
            this.gb_userData.Controls.Add(this.lbl_employeNameValue);
            this.gb_userData.Controls.Add(this.btn_save);
            this.gb_userData.Controls.Add(this.lbl_employePosition);
            this.gb_userData.Controls.Add(this.lbl_dni);
            this.gb_userData.Controls.Add(this.lbl_employePhone);
            this.gb_userData.Controls.Add(this.lbl_employeAddress);
            this.gb_userData.Controls.Add(this.lbl_employeName);
            this.gb_userData.Controls.Add(this.cb_employe);
            this.gb_userData.Controls.Add(this.lbl_employe);
            this.gb_userData.Controls.Add(this.btn_togglePassword);
            this.gb_userData.Controls.Add(this.tb_password);
            this.gb_userData.Controls.Add(this.tb_userName);
            this.gb_userData.Controls.Add(this.lbl_permissions);
            this.gb_userData.Controls.Add(this.lbl_password);
            this.gb_userData.Controls.Add(this.lbl_userName);
            this.gb_userData.Enabled = false;
            this.gb_userData.Location = new System.Drawing.Point(209, 12);
            this.gb_userData.Name = "gb_userData";
            this.gb_userData.Size = new System.Drawing.Size(367, 394);
            this.gb_userData.TabIndex = 1;
            this.gb_userData.TabStop = false;
            this.gb_userData.Text = "Datos de";
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteUser.Location = new System.Drawing.Point(188, 365);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(92, 23);
            this.btn_deleteUser.TabIndex = 20;
            this.btn_deleteUser.Text = "Eliminar Usuario";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // lbl_employePositionValue
            // 
            this.lbl_employePositionValue.Location = new System.Drawing.Point(69, 329);
            this.lbl_employePositionValue.Name = "lbl_employePositionValue";
            this.lbl_employePositionValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employePositionValue.TabIndex = 19;
            // 
            // lbl_employePhoneValue
            // 
            this.lbl_employePhoneValue.Location = new System.Drawing.Point(69, 306);
            this.lbl_employePhoneValue.Name = "lbl_employePhoneValue";
            this.lbl_employePhoneValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employePhoneValue.TabIndex = 18;
            // 
            // lbl_employeAddressValue
            // 
            this.lbl_employeAddressValue.Location = new System.Drawing.Point(69, 283);
            this.lbl_employeAddressValue.Name = "lbl_employeAddressValue";
            this.lbl_employeAddressValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employeAddressValue.TabIndex = 17;
            // 
            // lbl_employeDNIValue
            // 
            this.lbl_employeDNIValue.Location = new System.Drawing.Point(69, 260);
            this.lbl_employeDNIValue.Name = "lbl_employeDNIValue";
            this.lbl_employeDNIValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employeDNIValue.TabIndex = 16;
            // 
            // lbl_employeNameValue
            // 
            this.lbl_employeNameValue.Location = new System.Drawing.Point(69, 237);
            this.lbl_employeNameValue.Name = "lbl_employeNameValue";
            this.lbl_employeNameValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employeNameValue.TabIndex = 15;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(286, 365);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_employePosition
            // 
            this.lbl_employePosition.AutoSize = true;
            this.lbl_employePosition.Location = new System.Drawing.Point(13, 329);
            this.lbl_employePosition.Name = "lbl_employePosition";
            this.lbl_employePosition.Size = new System.Drawing.Size(50, 13);
            this.lbl_employePosition.TabIndex = 13;
            this.lbl_employePosition.Text = "Posición:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(34, 260);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 12;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_employePhone
            // 
            this.lbl_employePhone.AutoSize = true;
            this.lbl_employePhone.Location = new System.Drawing.Point(11, 306);
            this.lbl_employePhone.Name = "lbl_employePhone";
            this.lbl_employePhone.Size = new System.Drawing.Size(52, 13);
            this.lbl_employePhone.TabIndex = 11;
            this.lbl_employePhone.Text = "Teléfono:";
            // 
            // lbl_employeAddress
            // 
            this.lbl_employeAddress.AutoSize = true;
            this.lbl_employeAddress.Location = new System.Drawing.Point(8, 283);
            this.lbl_employeAddress.Name = "lbl_employeAddress";
            this.lbl_employeAddress.Size = new System.Drawing.Size(55, 13);
            this.lbl_employeAddress.TabIndex = 10;
            this.lbl_employeAddress.Text = "Dirección:";
            // 
            // lbl_employeName
            // 
            this.lbl_employeName.AutoSize = true;
            this.lbl_employeName.Location = new System.Drawing.Point(16, 237);
            this.lbl_employeName.Name = "lbl_employeName";
            this.lbl_employeName.Size = new System.Drawing.Size(47, 13);
            this.lbl_employeName.TabIndex = 9;
            this.lbl_employeName.Text = "Nombre:";
            // 
            // cb_employe
            // 
            this.cb_employe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_employe.FormattingEnabled = true;
            this.cb_employe.Location = new System.Drawing.Point(69, 208);
            this.cb_employe.Name = "cb_employe";
            this.cb_employe.Size = new System.Drawing.Size(283, 21);
            this.cb_employe.TabIndex = 3;
            this.cb_employe.SelectedIndexChanged += new System.EventHandler(this.cb_employe_SelectedIndexChanged);
            this.cb_employe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // lbl_employe
            // 
            this.lbl_employe.AutoSize = true;
            this.lbl_employe.Location = new System.Drawing.Point(6, 211);
            this.lbl_employe.Name = "lbl_employe";
            this.lbl_employe.Size = new System.Drawing.Size(57, 13);
            this.lbl_employe.TabIndex = 7;
            this.lbl_employe.Text = "Empleado:";
            // 
            // btn_togglePassword
            // 
            this.btn_togglePassword.Location = new System.Drawing.Point(277, 43);
            this.btn_togglePassword.Name = "btn_togglePassword";
            this.btn_togglePassword.Size = new System.Drawing.Size(75, 23);
            this.btn_togglePassword.TabIndex = 6;
            this.btn_togglePassword.Text = "Mostrar";
            this.btn_togglePassword.UseVisualStyleBackColor = true;
            this.btn_togglePassword.Click += new System.EventHandler(this.btn_togglePassword_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(113, 44);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(158, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.RequiredFields_TextChanged);
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(113, 23);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(158, 20);
            this.tb_userName.TabIndex = 0;
            this.tb_userName.TextChanged += new System.EventHandler(this.RequiredFields_TextChanged);
            this.tb_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generic_KeyPress);
            // 
            // lbl_permissions
            // 
            this.lbl_permissions.AutoSize = true;
            this.lbl_permissions.Location = new System.Drawing.Point(55, 70);
            this.lbl_permissions.Name = "lbl_permissions";
            this.lbl_permissions.Size = new System.Drawing.Size(52, 13);
            this.lbl_permissions.TabIndex = 2;
            this.lbl_permissions.Text = "Permisos:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(43, 48);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Contraseña:";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(6, 27);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(101, 13);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Nombre de Usuario:";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Location = new System.Drawing.Point(257, 415);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addNewUSer
            // 
            this.btn_addNewUSer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addNewUSer.Location = new System.Drawing.Point(12, 415);
            this.btn_addNewUSer.Name = "btn_addNewUSer";
            this.btn_addNewUSer.Size = new System.Drawing.Size(191, 23);
            this.btn_addNewUSer.TabIndex = 3;
            this.btn_addNewUSer.Text = "Agregar Nuevo Usuario";
            this.btn_addNewUSer.UseVisualStyleBackColor = true;
            this.btn_addNewUSer.Click += new System.EventHandler(this.btn_addNewUSer_Click);
            // 
            // clb_permissions
            // 
            this.clb_permissions.CheckOnClick = true;
            this.clb_permissions.FormattingEnabled = true;
            this.clb_permissions.Location = new System.Drawing.Point(113, 70);
            this.clb_permissions.Name = "clb_permissions";
            this.clb_permissions.Size = new System.Drawing.Size(239, 124);
            this.clb_permissions.TabIndex = 21;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(588, 448);
            this.Controls.Add(this.btn_addNewUSer);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_userData);
            this.Controls.Add(this.lb_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.gb_userData.ResumeLayout(false);
            this.gb_userData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.GroupBox gb_userData;
        private System.Windows.Forms.Label lbl_employePositionValue;
        private System.Windows.Forms.Label lbl_employePhoneValue;
        private System.Windows.Forms.Label lbl_employeAddressValue;
        private System.Windows.Forms.Label lbl_employeDNIValue;
        private System.Windows.Forms.Label lbl_employeNameValue;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_employePosition;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_employePhone;
        private System.Windows.Forms.Label lbl_employeAddress;
        private System.Windows.Forms.Label lbl_employeName;
        private System.Windows.Forms.ComboBox cb_employe;
        private System.Windows.Forms.Label lbl_employe;
        private System.Windows.Forms.Button btn_togglePassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lbl_permissions;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_addNewUSer;
        private System.Windows.Forms.CheckedListBox clb_permissions;
    }
}