using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Clientes
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.lb_clients = new System.Windows.Forms.ListBox();
            this.gb_clientData = new System.Windows.Forms.GroupBox();
            this.tb_clientAccount = new System.Windows.Forms.TextBox();
            this.tb_clientPhone = new System.Windows.Forms.TextBox();
            this.tb_clientAddress = new System.Windows.Forms.TextBox();
            this.tb_clientDni = new System.Windows.Forms.TextBox();
            this.btn_deleteClient = new System.Windows.Forms.Button();
            this.lbl_employePositionValue = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_clientAccount = new System.Windows.Forms.Label();
            this.lbl_clientPhone = new System.Windows.Forms.Label();
            this.lbl_clientAddress = new System.Windows.Forms.Label();
            this.tb_clientLastName = new System.Windows.Forms.TextBox();
            this.tb_clientFirstName = new System.Windows.Forms.TextBox();
            this.lbl_clientDni = new System.Windows.Forms.Label();
            this.lbl_clientLastName = new System.Windows.Forms.Label();
            this.lbl_clientFirstName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addNewClient = new System.Windows.Forms.Button();
            this.gb_clientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_clients
            // 
            this.lb_clients.FormattingEnabled = true;
            this.lb_clients.Location = new System.Drawing.Point(12, 12);
            this.lb_clients.Name = "lb_clients";
            this.lb_clients.Size = new System.Drawing.Size(191, 290);
            this.lb_clients.TabIndex = 0;
            this.lb_clients.SelectedIndexChanged += new System.EventHandler(this.lb_clients_SelectedIndexChanged);
            // 
            // gb_clientData
            // 
            this.gb_clientData.Controls.Add(this.tb_clientAccount);
            this.gb_clientData.Controls.Add(this.tb_clientPhone);
            this.gb_clientData.Controls.Add(this.tb_clientAddress);
            this.gb_clientData.Controls.Add(this.tb_clientDni);
            this.gb_clientData.Controls.Add(this.btn_deleteClient);
            this.gb_clientData.Controls.Add(this.lbl_employePositionValue);
            this.gb_clientData.Controls.Add(this.btn_save);
            this.gb_clientData.Controls.Add(this.lbl_clientAccount);
            this.gb_clientData.Controls.Add(this.lbl_clientPhone);
            this.gb_clientData.Controls.Add(this.lbl_clientAddress);
            this.gb_clientData.Controls.Add(this.tb_clientLastName);
            this.gb_clientData.Controls.Add(this.tb_clientFirstName);
            this.gb_clientData.Controls.Add(this.lbl_clientDni);
            this.gb_clientData.Controls.Add(this.lbl_clientLastName);
            this.gb_clientData.Controls.Add(this.lbl_clientFirstName);
            this.gb_clientData.Enabled = false;
            this.gb_clientData.Location = new System.Drawing.Point(209, 12);
            this.gb_clientData.Name = "gb_clientData";
            this.gb_clientData.Size = new System.Drawing.Size(367, 290);
            this.gb_clientData.TabIndex = 1;
            this.gb_clientData.TabStop = false;
            this.gb_clientData.Text = "Datos de";
            // 
            // tb_clientAccount
            // 
            this.tb_clientAccount.Location = new System.Drawing.Point(69, 129);
            this.tb_clientAccount.Name = "tb_clientAccount";
            this.tb_clientAccount.Size = new System.Drawing.Size(283, 20);
            this.tb_clientAccount.TabIndex = 5;
            this.tb_clientAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_clientAccount_KeyPress);
            // 
            // tb_clientPhone
            // 
            this.tb_clientPhone.Location = new System.Drawing.Point(69, 108);
            this.tb_clientPhone.Name = "tb_clientPhone";
            this.tb_clientPhone.Size = new System.Drawing.Size(283, 20);
            this.tb_clientPhone.TabIndex = 4;
            this.tb_clientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_generic_KeyPress);
            // 
            // tb_clientAddress
            // 
            this.tb_clientAddress.Location = new System.Drawing.Point(69, 87);
            this.tb_clientAddress.Name = "tb_clientAddress";
            this.tb_clientAddress.Size = new System.Drawing.Size(283, 20);
            this.tb_clientAddress.TabIndex = 3;
            this.tb_clientAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_generic_KeyPress);
            // 
            // tb_clientDni
            // 
            this.tb_clientDni.Location = new System.Drawing.Point(69, 66);
            this.tb_clientDni.Name = "tb_clientDni";
            this.tb_clientDni.Size = new System.Drawing.Size(283, 20);
            this.tb_clientDni.TabIndex = 2;
            this.tb_clientDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_generic_KeyPress);
            // 
            // btn_deleteClient
            // 
            this.btn_deleteClient.Location = new System.Drawing.Point(188, 261);
            this.btn_deleteClient.Name = "btn_deleteClient";
            this.btn_deleteClient.Size = new System.Drawing.Size(92, 23);
            this.btn_deleteClient.TabIndex = 20;
            this.btn_deleteClient.Text = "Eliminar Cliente";
            this.btn_deleteClient.UseVisualStyleBackColor = true;
            this.btn_deleteClient.Click += new System.EventHandler(this.btn_deleteclient_Click);
            // 
            // lbl_employePositionValue
            // 
            this.lbl_employePositionValue.Location = new System.Drawing.Point(69, 242);
            this.lbl_employePositionValue.Name = "lbl_employePositionValue";
            this.lbl_employePositionValue.Size = new System.Drawing.Size(283, 13);
            this.lbl_employePositionValue.TabIndex = 19;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(286, 261);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_clientAccount
            // 
            this.lbl_clientAccount.AutoSize = true;
            this.lbl_clientAccount.Location = new System.Drawing.Point(29, 132);
            this.lbl_clientAccount.Name = "lbl_clientAccount";
            this.lbl_clientAccount.Size = new System.Drawing.Size(37, 13);
            this.lbl_clientAccount.TabIndex = 13;
            this.lbl_clientAccount.Text = "Saldo:";
            // 
            // lbl_clientPhone
            // 
            this.lbl_clientPhone.AutoSize = true;
            this.lbl_clientPhone.Location = new System.Drawing.Point(14, 111);
            this.lbl_clientPhone.Name = "lbl_clientPhone";
            this.lbl_clientPhone.Size = new System.Drawing.Size(52, 13);
            this.lbl_clientPhone.TabIndex = 11;
            this.lbl_clientPhone.Text = "Teléfono:";
            // 
            // lbl_clientAddress
            // 
            this.lbl_clientAddress.AutoSize = true;
            this.lbl_clientAddress.Location = new System.Drawing.Point(11, 90);
            this.lbl_clientAddress.Name = "lbl_clientAddress";
            this.lbl_clientAddress.Size = new System.Drawing.Size(55, 13);
            this.lbl_clientAddress.TabIndex = 10;
            this.lbl_clientAddress.Text = "Dirección:";
            // 
            // tb_clientLastName
            // 
            this.tb_clientLastName.Location = new System.Drawing.Point(69, 45);
            this.tb_clientLastName.Name = "tb_clientLastName";
            this.tb_clientLastName.Size = new System.Drawing.Size(283, 20);
            this.tb_clientLastName.TabIndex = 1;
            this.tb_clientLastName.TextChanged += new System.EventHandler(this.tb_clientName_TextChanged);
            this.tb_clientLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_generic_KeyPress);
            // 
            // tb_clientFirstName
            // 
            this.tb_clientFirstName.Location = new System.Drawing.Point(69, 24);
            this.tb_clientFirstName.Name = "tb_clientFirstName";
            this.tb_clientFirstName.Size = new System.Drawing.Size(283, 20);
            this.tb_clientFirstName.TabIndex = 0;
            this.tb_clientFirstName.TextChanged += new System.EventHandler(this.tb_clientName_TextChanged);
            this.tb_clientFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_generic_KeyPress);
            // 
            // lbl_clientDni
            // 
            this.lbl_clientDni.AutoSize = true;
            this.lbl_clientDni.Location = new System.Drawing.Point(37, 69);
            this.lbl_clientDni.Name = "lbl_clientDni";
            this.lbl_clientDni.Size = new System.Drawing.Size(29, 13);
            this.lbl_clientDni.TabIndex = 2;
            this.lbl_clientDni.Text = "DNI:";
            // 
            // lbl_clientLastName
            // 
            this.lbl_clientLastName.AutoSize = true;
            this.lbl_clientLastName.Location = new System.Drawing.Point(19, 48);
            this.lbl_clientLastName.Name = "lbl_clientLastName";
            this.lbl_clientLastName.Size = new System.Drawing.Size(47, 13);
            this.lbl_clientLastName.TabIndex = 1;
            this.lbl_clientLastName.Text = "Apellido:";
            // 
            // lbl_clientFirstName
            // 
            this.lbl_clientFirstName.AutoSize = true;
            this.lbl_clientFirstName.Location = new System.Drawing.Point(19, 27);
            this.lbl_clientFirstName.Name = "lbl_clientFirstName";
            this.lbl_clientFirstName.Size = new System.Drawing.Size(47, 13);
            this.lbl_clientFirstName.TabIndex = 0;
            this.lbl_clientFirstName.Text = "Nombre:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(257, 308);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addNewClient
            // 
            this.btn_addNewClient.Location = new System.Drawing.Point(12, 306);
            this.btn_addNewClient.Name = "btn_addNewClient";
            this.btn_addNewClient.Size = new System.Drawing.Size(191, 23);
            this.btn_addNewClient.TabIndex = 3;
            this.btn_addNewClient.Text = "Agregar Nuevo Cliente";
            this.btn_addNewClient.UseVisualStyleBackColor = true;
            this.btn_addNewClient.Click += new System.EventHandler(this.btn_addNewclient_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.btn_addNewClient);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_clientData);
            this.Controls.Add(this.lb_clients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes";
            this.gb_clientData.ResumeLayout(false);
            this.gb_clientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_clients;
        private GroupBox gb_clientData;
        private Label lbl_employePositionValue;
        private Button btn_save;
        private Label lbl_clientAccount;
        private Label lbl_clientPhone;
        private Label lbl_clientAddress;
        private TextBox tb_clientLastName;
        private TextBox tb_clientFirstName;
        private Label lbl_clientDni;
        private Label lbl_clientLastName;
        private Label lbl_clientFirstName;
        private Button btn_close;
        private Button btn_deleteClient;
        private Button btn_addNewClient;
        private TextBox tb_clientDni;
        private TextBox tb_clientAccount;
        private TextBox tb_clientPhone;
        private TextBox tb_clientAddress;
    }
}