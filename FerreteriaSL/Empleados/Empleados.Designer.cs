namespace FerreteriaSL
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.lb_employe = new System.Windows.Forms.ListBox();
            this.gb_employeData = new System.Windows.Forms.GroupBox();
            this.gb_payments = new System.Windows.Forms.GroupBox();
            this.btn_registerPayment = new System.Windows.Forms.Button();
            this.btn_viewPayments = new System.Windows.Forms.Button();
            this.gb_statistics = new System.Windows.Forms.GroupBox();
            this.lbl_amountRecaudedValue = new System.Windows.Forms.Label();
            this.lbl_soldProductsValue = new System.Windows.Forms.Label();
            this.lbl_sellCountValue = new System.Windows.Forms.Label();
            this.lbl_amountRecauded = new System.Windows.Forms.Label();
            this.lbl_soldProducts = new System.Windows.Forms.Label();
            this.lbl_sellCount = new System.Windows.Forms.Label();
            this.tb_employePosition = new System.Windows.Forms.TextBox();
            this.tb_employePhone = new System.Windows.Forms.TextBox();
            this.tb_employeAddress = new System.Windows.Forms.TextBox();
            this.tb_employeDni = new System.Windows.Forms.TextBox();
            this.tb_employeLastName = new System.Windows.Forms.TextBox();
            this.lbl_employeLastName = new System.Windows.Forms.Label();
            this.tb_employeFirstName = new System.Windows.Forms.TextBox();
            this.btn_deleteEmploye = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_employePosition = new System.Windows.Forms.Label();
            this.lbl_employeDni = new System.Windows.Forms.Label();
            this.lbl_employePhone = new System.Windows.Forms.Label();
            this.lbl_employeAddress = new System.Windows.Forms.Label();
            this.lbl_employeFirstName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addNewEmploye = new System.Windows.Forms.Button();
            this.gb_employeData.SuspendLayout();
            this.gb_payments.SuspendLayout();
            this.gb_statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_employe
            // 
            this.lb_employe.FormattingEnabled = true;
            this.lb_employe.Location = new System.Drawing.Point(12, 12);
            this.lb_employe.Name = "lb_employe";
            this.lb_employe.Size = new System.Drawing.Size(191, 342);
            this.lb_employe.TabIndex = 0;
            this.lb_employe.SelectedIndexChanged += new System.EventHandler(this.lb_users_SelectedIndexChanged);
            // 
            // gb_employeData
            // 
            this.gb_employeData.Controls.Add(this.gb_payments);
            this.gb_employeData.Controls.Add(this.gb_statistics);
            this.gb_employeData.Controls.Add(this.tb_employePosition);
            this.gb_employeData.Controls.Add(this.tb_employePhone);
            this.gb_employeData.Controls.Add(this.tb_employeAddress);
            this.gb_employeData.Controls.Add(this.tb_employeDni);
            this.gb_employeData.Controls.Add(this.tb_employeLastName);
            this.gb_employeData.Controls.Add(this.lbl_employeLastName);
            this.gb_employeData.Controls.Add(this.tb_employeFirstName);
            this.gb_employeData.Controls.Add(this.btn_deleteEmploye);
            this.gb_employeData.Controls.Add(this.btn_save);
            this.gb_employeData.Controls.Add(this.lbl_employePosition);
            this.gb_employeData.Controls.Add(this.lbl_employeDni);
            this.gb_employeData.Controls.Add(this.lbl_employePhone);
            this.gb_employeData.Controls.Add(this.lbl_employeAddress);
            this.gb_employeData.Controls.Add(this.lbl_employeFirstName);
            this.gb_employeData.Enabled = false;
            this.gb_employeData.Location = new System.Drawing.Point(209, 12);
            this.gb_employeData.Name = "gb_employeData";
            this.gb_employeData.Size = new System.Drawing.Size(367, 341);
            this.gb_employeData.TabIndex = 1;
            this.gb_employeData.TabStop = false;
            this.gb_employeData.Text = "Datos de";
            // 
            // gb_payments
            // 
            this.gb_payments.Controls.Add(this.btn_registerPayment);
            this.gb_payments.Controls.Add(this.btn_viewPayments);
            this.gb_payments.Location = new System.Drawing.Point(12, 250);
            this.gb_payments.Name = "gb_payments";
            this.gb_payments.Size = new System.Drawing.Size(349, 55);
            this.gb_payments.TabIndex = 29;
            this.gb_payments.TabStop = false;
            this.gb_payments.Text = "Pagos";
            // 
            // btn_registerPayment
            // 
            this.btn_registerPayment.Location = new System.Drawing.Point(193, 19);
            this.btn_registerPayment.Name = "btn_registerPayment";
            this.btn_registerPayment.Size = new System.Drawing.Size(92, 23);
            this.btn_registerPayment.TabIndex = 1;
            this.btn_registerPayment.Text = "Registrar Pago";
            this.btn_registerPayment.UseVisualStyleBackColor = true;
            this.btn_registerPayment.Click += new System.EventHandler(this.btn_registerPayment_Click);
            // 
            // btn_viewPayments
            // 
            this.btn_viewPayments.Location = new System.Drawing.Point(63, 19);
            this.btn_viewPayments.Name = "btn_viewPayments";
            this.btn_viewPayments.Size = new System.Drawing.Size(124, 23);
            this.btn_viewPayments.TabIndex = 0;
            this.btn_viewPayments.Text = "Ver Pagos Realizados";
            this.btn_viewPayments.UseVisualStyleBackColor = true;
            this.btn_viewPayments.Click += new System.EventHandler(this.btn_viewPayments_Click);
            // 
            // gb_statistics
            // 
            this.gb_statistics.Controls.Add(this.lbl_amountRecaudedValue);
            this.gb_statistics.Controls.Add(this.lbl_soldProductsValue);
            this.gb_statistics.Controls.Add(this.lbl_sellCountValue);
            this.gb_statistics.Controls.Add(this.lbl_amountRecauded);
            this.gb_statistics.Controls.Add(this.lbl_soldProducts);
            this.gb_statistics.Controls.Add(this.lbl_sellCount);
            this.gb_statistics.Location = new System.Drawing.Point(12, 159);
            this.gb_statistics.Name = "gb_statistics";
            this.gb_statistics.Size = new System.Drawing.Size(349, 85);
            this.gb_statistics.TabIndex = 28;
            this.gb_statistics.TabStop = false;
            this.gb_statistics.Text = "Estadísticas";
            // 
            // lbl_amountRecaudedValue
            // 
            this.lbl_amountRecaudedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountRecaudedValue.Location = new System.Drawing.Point(173, 61);
            this.lbl_amountRecaudedValue.Name = "lbl_amountRecaudedValue";
            this.lbl_amountRecaudedValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_amountRecaudedValue.TabIndex = 5;
            // 
            // lbl_soldProductsValue
            // 
            this.lbl_soldProductsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soldProductsValue.Location = new System.Drawing.Point(173, 40);
            this.lbl_soldProductsValue.Name = "lbl_soldProductsValue";
            this.lbl_soldProductsValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_soldProductsValue.TabIndex = 4;
            // 
            // lbl_sellCountValue
            // 
            this.lbl_sellCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellCountValue.Location = new System.Drawing.Point(173, 19);
            this.lbl_sellCountValue.Name = "lbl_sellCountValue";
            this.lbl_sellCountValue.Size = new System.Drawing.Size(166, 13);
            this.lbl_sellCountValue.TabIndex = 3;
            // 
            // lbl_amountRecauded
            // 
            this.lbl_amountRecauded.AutoSize = true;
            this.lbl_amountRecauded.Location = new System.Drawing.Point(11, 61);
            this.lbl_amountRecauded.Name = "lbl_amountRecauded";
            this.lbl_amountRecauded.Size = new System.Drawing.Size(160, 13);
            this.lbl_amountRecauded.TabIndex = 2;
            this.lbl_amountRecauded.Text = "Cantidad de Dinero Recaudado:";
            // 
            // lbl_soldProducts
            // 
            this.lbl_soldProducts.AutoSize = true;
            this.lbl_soldProducts.Location = new System.Drawing.Point(12, 40);
            this.lbl_soldProducts.Name = "lbl_soldProducts";
            this.lbl_soldProducts.Size = new System.Drawing.Size(159, 13);
            this.lbl_soldProducts.TabIndex = 1;
            this.lbl_soldProducts.Text = "Cantidad de Artículos Vendidos:";
            // 
            // lbl_sellCount
            // 
            this.lbl_sellCount.AutoSize = true;
            this.lbl_sellCount.Location = new System.Drawing.Point(13, 19);
            this.lbl_sellCount.Name = "lbl_sellCount";
            this.lbl_sellCount.Size = new System.Drawing.Size(158, 13);
            this.lbl_sellCount.TabIndex = 0;
            this.lbl_sellCount.Text = "Cantidad de Ventas Realizadas:";
            // 
            // tb_employePosition
            // 
            this.tb_employePosition.Location = new System.Drawing.Point(70, 130);
            this.tb_employePosition.Name = "tb_employePosition";
            this.tb_employePosition.Size = new System.Drawing.Size(292, 20);
            this.tb_employePosition.TabIndex = 27;
            this.tb_employePosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // tb_employePhone
            // 
            this.tb_employePhone.Location = new System.Drawing.Point(70, 108);
            this.tb_employePhone.Name = "tb_employePhone";
            this.tb_employePhone.Size = new System.Drawing.Size(292, 20);
            this.tb_employePhone.TabIndex = 26;
            this.tb_employePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // tb_employeAddress
            // 
            this.tb_employeAddress.Location = new System.Drawing.Point(70, 86);
            this.tb_employeAddress.Name = "tb_employeAddress";
            this.tb_employeAddress.Size = new System.Drawing.Size(292, 20);
            this.tb_employeAddress.TabIndex = 25;
            this.tb_employeAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // tb_employeDni
            // 
            this.tb_employeDni.Location = new System.Drawing.Point(70, 64);
            this.tb_employeDni.Name = "tb_employeDni";
            this.tb_employeDni.Size = new System.Drawing.Size(292, 20);
            this.tb_employeDni.TabIndex = 24;
            this.tb_employeDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // tb_employeLastName
            // 
            this.tb_employeLastName.Location = new System.Drawing.Point(70, 42);
            this.tb_employeLastName.Name = "tb_employeLastName";
            this.tb_employeLastName.Size = new System.Drawing.Size(292, 20);
            this.tb_employeLastName.TabIndex = 23;
            this.tb_employeLastName.TextChanged += new System.EventHandler(this.tb_employeFirstName_TextChanged);
            this.tb_employeLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // lbl_employeLastName
            // 
            this.lbl_employeLastName.AutoSize = true;
            this.lbl_employeLastName.Location = new System.Drawing.Point(16, 46);
            this.lbl_employeLastName.Name = "lbl_employeLastName";
            this.lbl_employeLastName.Size = new System.Drawing.Size(47, 13);
            this.lbl_employeLastName.TabIndex = 22;
            this.lbl_employeLastName.Text = "Apellido:";
            // 
            // tb_employeFirstName
            // 
            this.tb_employeFirstName.Location = new System.Drawing.Point(70, 20);
            this.tb_employeFirstName.Name = "tb_employeFirstName";
            this.tb_employeFirstName.Size = new System.Drawing.Size(292, 20);
            this.tb_employeFirstName.TabIndex = 21;
            this.tb_employeFirstName.TextChanged += new System.EventHandler(this.tb_employeFirstName_TextChanged);
            this.tb_employeFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_employeData_KeyPress);
            // 
            // btn_deleteEmploye
            // 
            this.btn_deleteEmploye.Location = new System.Drawing.Point(174, 311);
            this.btn_deleteEmploye.Name = "btn_deleteEmploye";
            this.btn_deleteEmploye.Size = new System.Drawing.Size(106, 23);
            this.btn_deleteEmploye.TabIndex = 20;
            this.btn_deleteEmploye.Text = "Eliminar Empleado";
            this.btn_deleteEmploye.UseVisualStyleBackColor = true;
            this.btn_deleteEmploye.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(286, 311);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_employePosition
            // 
            this.lbl_employePosition.AutoSize = true;
            this.lbl_employePosition.Location = new System.Drawing.Point(13, 134);
            this.lbl_employePosition.Name = "lbl_employePosition";
            this.lbl_employePosition.Size = new System.Drawing.Size(50, 13);
            this.lbl_employePosition.TabIndex = 13;
            this.lbl_employePosition.Text = "Posición:";
            // 
            // lbl_employeDni
            // 
            this.lbl_employeDni.AutoSize = true;
            this.lbl_employeDni.Location = new System.Drawing.Point(34, 68);
            this.lbl_employeDni.Name = "lbl_employeDni";
            this.lbl_employeDni.Size = new System.Drawing.Size(29, 13);
            this.lbl_employeDni.TabIndex = 12;
            this.lbl_employeDni.Text = "DNI:";
            // 
            // lbl_employePhone
            // 
            this.lbl_employePhone.AutoSize = true;
            this.lbl_employePhone.Location = new System.Drawing.Point(11, 112);
            this.lbl_employePhone.Name = "lbl_employePhone";
            this.lbl_employePhone.Size = new System.Drawing.Size(52, 13);
            this.lbl_employePhone.TabIndex = 11;
            this.lbl_employePhone.Text = "Teléfono:";
            // 
            // lbl_employeAddress
            // 
            this.lbl_employeAddress.AutoSize = true;
            this.lbl_employeAddress.Location = new System.Drawing.Point(8, 90);
            this.lbl_employeAddress.Name = "lbl_employeAddress";
            this.lbl_employeAddress.Size = new System.Drawing.Size(55, 13);
            this.lbl_employeAddress.TabIndex = 10;
            this.lbl_employeAddress.Text = "Dirección:";
            // 
            // lbl_employeFirstName
            // 
            this.lbl_employeFirstName.AutoSize = true;
            this.lbl_employeFirstName.Location = new System.Drawing.Point(16, 24);
            this.lbl_employeFirstName.Name = "lbl_employeFirstName";
            this.lbl_employeFirstName.Size = new System.Drawing.Size(47, 13);
            this.lbl_employeFirstName.TabIndex = 9;
            this.lbl_employeFirstName.Text = "Nombre:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(257, 359);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addNewEmploye
            // 
            this.btn_addNewEmploye.Location = new System.Drawing.Point(12, 359);
            this.btn_addNewEmploye.Name = "btn_addNewEmploye";
            this.btn_addNewEmploye.Size = new System.Drawing.Size(191, 23);
            this.btn_addNewEmploye.TabIndex = 3;
            this.btn_addNewEmploye.Text = "Agregar Nuevo Empleado";
            this.btn_addNewEmploye.UseVisualStyleBackColor = true;
            this.btn_addNewEmploye.Click += new System.EventHandler(this.btn_addNewEmploye_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(592, 400);
            this.Controls.Add(this.btn_addNewEmploye);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_employeData);
            this.Controls.Add(this.lb_employe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Empleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.gb_employeData.ResumeLayout(false);
            this.gb_employeData.PerformLayout();
            this.gb_payments.ResumeLayout(false);
            this.gb_statistics.ResumeLayout(false);
            this.gb_statistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_employe;
        private System.Windows.Forms.GroupBox gb_employeData;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_employePosition;
        private System.Windows.Forms.Label lbl_employeDni;
        private System.Windows.Forms.Label lbl_employePhone;
        private System.Windows.Forms.Label lbl_employeAddress;
        private System.Windows.Forms.Label lbl_employeFirstName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_deleteEmploye;
        private System.Windows.Forms.Button btn_addNewEmploye;
        private System.Windows.Forms.Label lbl_employeLastName;
        private System.Windows.Forms.TextBox tb_employeFirstName;
        private System.Windows.Forms.TextBox tb_employeLastName;
        private System.Windows.Forms.GroupBox gb_statistics;
        private System.Windows.Forms.TextBox tb_employePosition;
        private System.Windows.Forms.TextBox tb_employePhone;
        private System.Windows.Forms.TextBox tb_employeAddress;
        private System.Windows.Forms.TextBox tb_employeDni;
        private System.Windows.Forms.GroupBox gb_payments;
        private System.Windows.Forms.Button btn_registerPayment;
        private System.Windows.Forms.Button btn_viewPayments;
        private System.Windows.Forms.Label lbl_amountRecaudedValue;
        private System.Windows.Forms.Label lbl_soldProductsValue;
        private System.Windows.Forms.Label lbl_sellCountValue;
        private System.Windows.Forms.Label lbl_amountRecauded;
        private System.Windows.Forms.Label lbl_soldProducts;
        private System.Windows.Forms.Label lbl_sellCount;
    }
}