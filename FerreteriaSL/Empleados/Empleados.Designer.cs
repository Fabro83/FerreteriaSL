using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.Empleados
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.lb_employe = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addNewEmploye = new System.Windows.Forms.Button();
            this.tc_employee = new System.Windows.Forms.TabControl();
            this.tp_general = new System.Windows.Forms.TabPage();
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
            this.tp_payments = new System.Windows.Forms.TabPage();
            this.lbl_paysTotalValue = new System.Windows.Forms.Label();
            this.lbl_paysTotal = new System.Windows.Forms.Label();
            this.lbl_paysDateTo = new System.Windows.Forms.Label();
            this.lbl_paysDateFrom = new System.Windows.Forms.Label();
            this.dtp_paysDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_paysDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dgv_employeePayments = new System.Windows.Forms.DataGridView();
            this.btn_registerPayment = new System.Windows.Forms.Button();
            this.tp_statistics = new System.Windows.Forms.TabPage();
            this.dgv_estadistica = new System.Windows.Forms.DataGridView();
            this.cb_estadisticaTipo = new System.Windows.Forms.ComboBox();
            this.cb_estadisticaAnio = new System.Windows.Forms.ComboBox();
            this.chk_estadisticaTodos = new System.Windows.Forms.CheckBox();
            this.tc_employee.SuspendLayout();
            this.tp_general.SuspendLayout();
            this.tp_payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeePayments)).BeginInit();
            this.tp_statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_employe
            // 
            this.lb_employe.FormattingEnabled = true;
            this.lb_employe.Location = new System.Drawing.Point(12, 12);
            this.lb_employe.Name = "lb_employe";
            this.lb_employe.Size = new System.Drawing.Size(191, 381);
            this.lb_employe.TabIndex = 0;
            this.lb_employe.SelectedIndexChanged += new System.EventHandler(this.lb_users_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(543, 407);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addNewEmploye
            // 
            this.btn_addNewEmploye.Location = new System.Drawing.Point(12, 407);
            this.btn_addNewEmploye.Name = "btn_addNewEmploye";
            this.btn_addNewEmploye.Size = new System.Drawing.Size(191, 23);
            this.btn_addNewEmploye.TabIndex = 3;
            this.btn_addNewEmploye.Text = "Agregar Nuevo Empleado";
            this.btn_addNewEmploye.UseVisualStyleBackColor = true;
            this.btn_addNewEmploye.Click += new System.EventHandler(this.btn_addNewEmploye_Click);
            // 
            // tc_employee
            // 
            this.tc_employee.Controls.Add(this.tp_general);
            this.tc_employee.Controls.Add(this.tp_payments);
            this.tc_employee.Controls.Add(this.tp_statistics);
            this.tc_employee.Enabled = false;
            this.tc_employee.HotTrack = true;
            this.tc_employee.Location = new System.Drawing.Point(209, 12);
            this.tc_employee.Name = "tc_employee";
            this.tc_employee.SelectedIndex = 0;
            this.tc_employee.Size = new System.Drawing.Size(409, 381);
            this.tc_employee.TabIndex = 4;
            // 
            // tp_general
            // 
            this.tp_general.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_general.Controls.Add(this.tb_employePosition);
            this.tp_general.Controls.Add(this.tb_employePhone);
            this.tp_general.Controls.Add(this.tb_employeAddress);
            this.tp_general.Controls.Add(this.tb_employeDni);
            this.tp_general.Controls.Add(this.tb_employeLastName);
            this.tp_general.Controls.Add(this.lbl_employeLastName);
            this.tp_general.Controls.Add(this.tb_employeFirstName);
            this.tp_general.Controls.Add(this.btn_deleteEmploye);
            this.tp_general.Controls.Add(this.btn_save);
            this.tp_general.Controls.Add(this.lbl_employePosition);
            this.tp_general.Controls.Add(this.lbl_employeDni);
            this.tp_general.Controls.Add(this.lbl_employePhone);
            this.tp_general.Controls.Add(this.lbl_employeAddress);
            this.tp_general.Controls.Add(this.lbl_employeFirstName);
            this.tp_general.Location = new System.Drawing.Point(4, 22);
            this.tp_general.Name = "tp_general";
            this.tp_general.Padding = new System.Windows.Forms.Padding(3);
            this.tp_general.Size = new System.Drawing.Size(401, 355);
            this.tp_general.TabIndex = 0;
            this.tp_general.Text = "General";
            // 
            // tb_employePosition
            // 
            this.tb_employePosition.Location = new System.Drawing.Point(94, 208);
            this.tb_employePosition.Name = "tb_employePosition";
            this.tb_employePosition.Size = new System.Drawing.Size(275, 20);
            this.tb_employePosition.TabIndex = 41;
            // 
            // tb_employePhone
            // 
            this.tb_employePhone.Location = new System.Drawing.Point(94, 186);
            this.tb_employePhone.Name = "tb_employePhone";
            this.tb_employePhone.Size = new System.Drawing.Size(275, 20);
            this.tb_employePhone.TabIndex = 40;
            // 
            // tb_employeAddress
            // 
            this.tb_employeAddress.Location = new System.Drawing.Point(94, 164);
            this.tb_employeAddress.Name = "tb_employeAddress";
            this.tb_employeAddress.Size = new System.Drawing.Size(275, 20);
            this.tb_employeAddress.TabIndex = 39;
            // 
            // tb_employeDni
            // 
            this.tb_employeDni.Location = new System.Drawing.Point(94, 142);
            this.tb_employeDni.Name = "tb_employeDni";
            this.tb_employeDni.Size = new System.Drawing.Size(275, 20);
            this.tb_employeDni.TabIndex = 38;
            // 
            // tb_employeLastName
            // 
            this.tb_employeLastName.Location = new System.Drawing.Point(94, 120);
            this.tb_employeLastName.Name = "tb_employeLastName";
            this.tb_employeLastName.Size = new System.Drawing.Size(275, 20);
            this.tb_employeLastName.TabIndex = 37;
            this.tb_employeLastName.TextChanged += new System.EventHandler(this.tb_employeFirstName_TextChanged);
            // 
            // lbl_employeLastName
            // 
            this.lbl_employeLastName.AutoSize = true;
            this.lbl_employeLastName.Location = new System.Drawing.Point(40, 124);
            this.lbl_employeLastName.Name = "lbl_employeLastName";
            this.lbl_employeLastName.Size = new System.Drawing.Size(47, 13);
            this.lbl_employeLastName.TabIndex = 36;
            this.lbl_employeLastName.Text = "Apellido:";
            // 
            // tb_employeFirstName
            // 
            this.tb_employeFirstName.Location = new System.Drawing.Point(94, 98);
            this.tb_employeFirstName.Name = "tb_employeFirstName";
            this.tb_employeFirstName.Size = new System.Drawing.Size(275, 20);
            this.tb_employeFirstName.TabIndex = 35;
            this.tb_employeFirstName.TextChanged += new System.EventHandler(this.tb_employeFirstName_TextChanged);
            // 
            // btn_deleteEmploye
            // 
            this.btn_deleteEmploye.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_deleteEmploye.Location = new System.Drawing.Point(94, 234);
            this.btn_deleteEmploye.Name = "btn_deleteEmploye";
            this.btn_deleteEmploye.Size = new System.Drawing.Size(106, 23);
            this.btn_deleteEmploye.TabIndex = 34;
            this.btn_deleteEmploye.Text = "Eliminar Empleado";
            this.btn_deleteEmploye.UseVisualStyleBackColor = true;
            this.btn_deleteEmploye.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(206, 234);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 23);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Guardar Cambios";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_employePosition
            // 
            this.lbl_employePosition.AutoSize = true;
            this.lbl_employePosition.Location = new System.Drawing.Point(37, 212);
            this.lbl_employePosition.Name = "lbl_employePosition";
            this.lbl_employePosition.Size = new System.Drawing.Size(50, 13);
            this.lbl_employePosition.TabIndex = 32;
            this.lbl_employePosition.Text = "Posición:";
            // 
            // lbl_employeDni
            // 
            this.lbl_employeDni.AutoSize = true;
            this.lbl_employeDni.Location = new System.Drawing.Point(58, 146);
            this.lbl_employeDni.Name = "lbl_employeDni";
            this.lbl_employeDni.Size = new System.Drawing.Size(29, 13);
            this.lbl_employeDni.TabIndex = 31;
            this.lbl_employeDni.Text = "DNI:";
            // 
            // lbl_employePhone
            // 
            this.lbl_employePhone.AutoSize = true;
            this.lbl_employePhone.Location = new System.Drawing.Point(35, 190);
            this.lbl_employePhone.Name = "lbl_employePhone";
            this.lbl_employePhone.Size = new System.Drawing.Size(52, 13);
            this.lbl_employePhone.TabIndex = 30;
            this.lbl_employePhone.Text = "Teléfono:";
            // 
            // lbl_employeAddress
            // 
            this.lbl_employeAddress.AutoSize = true;
            this.lbl_employeAddress.Location = new System.Drawing.Point(32, 168);
            this.lbl_employeAddress.Name = "lbl_employeAddress";
            this.lbl_employeAddress.Size = new System.Drawing.Size(55, 13);
            this.lbl_employeAddress.TabIndex = 29;
            this.lbl_employeAddress.Text = "Dirección:";
            // 
            // lbl_employeFirstName
            // 
            this.lbl_employeFirstName.AutoSize = true;
            this.lbl_employeFirstName.Location = new System.Drawing.Point(40, 102);
            this.lbl_employeFirstName.Name = "lbl_employeFirstName";
            this.lbl_employeFirstName.Size = new System.Drawing.Size(47, 13);
            this.lbl_employeFirstName.TabIndex = 28;
            this.lbl_employeFirstName.Text = "Nombre:";
            // 
            // tp_payments
            // 
            this.tp_payments.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_payments.Controls.Add(this.lbl_paysTotalValue);
            this.tp_payments.Controls.Add(this.lbl_paysTotal);
            this.tp_payments.Controls.Add(this.lbl_paysDateTo);
            this.tp_payments.Controls.Add(this.lbl_paysDateFrom);
            this.tp_payments.Controls.Add(this.dtp_paysDateTo);
            this.tp_payments.Controls.Add(this.dtp_paysDateFrom);
            this.tp_payments.Controls.Add(this.dgv_employeePayments);
            this.tp_payments.Controls.Add(this.btn_registerPayment);
            this.tp_payments.Location = new System.Drawing.Point(4, 22);
            this.tp_payments.Name = "tp_payments";
            this.tp_payments.Padding = new System.Windows.Forms.Padding(3);
            this.tp_payments.Size = new System.Drawing.Size(401, 355);
            this.tp_payments.TabIndex = 1;
            this.tp_payments.Text = "Pagos";
            // 
            // lbl_paysTotalValue
            // 
            this.lbl_paysTotalValue.AutoEllipsis = true;
            this.lbl_paysTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paysTotalValue.Location = new System.Drawing.Point(51, 329);
            this.lbl_paysTotalValue.Name = "lbl_paysTotalValue";
            this.lbl_paysTotalValue.Size = new System.Drawing.Size(249, 16);
            this.lbl_paysTotalValue.TabIndex = 8;
            this.lbl_paysTotalValue.Text = "$0,0";
            // 
            // lbl_paysTotal
            // 
            this.lbl_paysTotal.AutoSize = true;
            this.lbl_paysTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paysTotal.Location = new System.Drawing.Point(7, 329);
            this.lbl_paysTotal.Name = "lbl_paysTotal";
            this.lbl_paysTotal.Size = new System.Drawing.Size(52, 16);
            this.lbl_paysTotal.TabIndex = 7;
            this.lbl_paysTotal.Text = "Total: ";
            // 
            // lbl_paysDateTo
            // 
            this.lbl_paysDateTo.AutoSize = true;
            this.lbl_paysDateTo.Location = new System.Drawing.Point(210, 9);
            this.lbl_paysDateTo.Name = "lbl_paysDateTo";
            this.lbl_paysDateTo.Size = new System.Drawing.Size(38, 13);
            this.lbl_paysDateTo.TabIndex = 6;
            this.lbl_paysDateTo.Text = "Hasta:";
            // 
            // lbl_paysDateFrom
            // 
            this.lbl_paysDateFrom.AutoSize = true;
            this.lbl_paysDateFrom.Location = new System.Drawing.Point(48, 9);
            this.lbl_paysDateFrom.Name = "lbl_paysDateFrom";
            this.lbl_paysDateFrom.Size = new System.Drawing.Size(41, 13);
            this.lbl_paysDateFrom.TabIndex = 5;
            this.lbl_paysDateFrom.Text = "Desde:";
            // 
            // dtp_paysDateTo
            // 
            this.dtp_paysDateTo.Checked = false;
            this.dtp_paysDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_paysDateTo.Location = new System.Drawing.Point(253, 5);
            this.dtp_paysDateTo.Name = "dtp_paysDateTo";
            this.dtp_paysDateTo.ShowCheckBox = true;
            this.dtp_paysDateTo.Size = new System.Drawing.Size(104, 20);
            this.dtp_paysDateTo.TabIndex = 4;
            this.dtp_paysDateTo.ValueChanged += new System.EventHandler(this.dtp_paysDate_Change);
            // 
            // dtp_paysDateFrom
            // 
            this.dtp_paysDateFrom.Checked = false;
            this.dtp_paysDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_paysDateFrom.Location = new System.Drawing.Point(94, 5);
            this.dtp_paysDateFrom.Name = "dtp_paysDateFrom";
            this.dtp_paysDateFrom.ShowCheckBox = true;
            this.dtp_paysDateFrom.Size = new System.Drawing.Size(100, 20);
            this.dtp_paysDateFrom.TabIndex = 3;
            this.dtp_paysDateFrom.ValueChanged += new System.EventHandler(this.dtp_paysDate_Change);
            // 
            // dgv_employeePayments
            // 
            this.dgv_employeePayments.AllowUserToAddRows = false;
            this.dgv_employeePayments.AllowUserToDeleteRows = false;
            this.dgv_employeePayments.AllowUserToOrderColumns = true;
            this.dgv_employeePayments.AllowUserToResizeRows = false;
            this.dgv_employeePayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeePayments.Location = new System.Drawing.Point(6, 32);
            this.dgv_employeePayments.Name = "dgv_employeePayments";
            this.dgv_employeePayments.ReadOnly = true;
            this.dgv_employeePayments.RowHeadersVisible = false;
            this.dgv_employeePayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeePayments.ShowEditingIcon = false;
            this.dgv_employeePayments.Size = new System.Drawing.Size(389, 288);
            this.dgv_employeePayments.TabIndex = 2;
            this.dgv_employeePayments.SelectionChanged += new System.EventHandler(this.dgv_employeePayments_SelectionChanged);
            // 
            // btn_registerPayment
            // 
            this.btn_registerPayment.Location = new System.Drawing.Point(306, 326);
            this.btn_registerPayment.Name = "btn_registerPayment";
            this.btn_registerPayment.Size = new System.Drawing.Size(92, 23);
            this.btn_registerPayment.TabIndex = 1;
            this.btn_registerPayment.Text = "Registrar Pago";
            this.btn_registerPayment.UseVisualStyleBackColor = true;
            this.btn_registerPayment.Click += new System.EventHandler(this.btn_registerPayment_Click);
            // 
            // tp_statistics
            // 
            this.tp_statistics.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tp_statistics.Controls.Add(this.chk_estadisticaTodos);
            this.tp_statistics.Controls.Add(this.cb_estadisticaAnio);
            this.tp_statistics.Controls.Add(this.cb_estadisticaTipo);
            this.tp_statistics.Controls.Add(this.dgv_estadistica);
            this.tp_statistics.Location = new System.Drawing.Point(4, 22);
            this.tp_statistics.Name = "tp_statistics";
            this.tp_statistics.Padding = new System.Windows.Forms.Padding(3);
            this.tp_statistics.Size = new System.Drawing.Size(401, 355);
            this.tp_statistics.TabIndex = 2;
            this.tp_statistics.Text = "Estadisticas";
            // 
            // dgv_estadistica
            // 
            this.dgv_estadistica.AllowUserToAddRows = false;
            this.dgv_estadistica.AllowUserToDeleteRows = false;
            this.dgv_estadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_estadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadistica.Location = new System.Drawing.Point(6, 34);
            this.dgv_estadistica.Name = "dgv_estadistica";
            this.dgv_estadistica.ReadOnly = true;
            this.dgv_estadistica.RowHeadersVisible = false;
            this.dgv_estadistica.ShowEditingIcon = false;
            this.dgv_estadistica.Size = new System.Drawing.Size(389, 315);
            this.dgv_estadistica.TabIndex = 0;
            // 
            // cb_estadisticaTipo
            // 
            this.cb_estadisticaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadisticaTipo.FormattingEnabled = true;
            this.cb_estadisticaTipo.Items.AddRange(new object[] {
            "Cantdidad de Ventas",
            "Articulos Vendidos",
            "Dinero Recaudado"});
            this.cb_estadisticaTipo.Location = new System.Drawing.Point(7, 7);
            this.cb_estadisticaTipo.Name = "cb_estadisticaTipo";
            this.cb_estadisticaTipo.Size = new System.Drawing.Size(227, 21);
            this.cb_estadisticaTipo.TabIndex = 1;
            this.cb_estadisticaTipo.SelectedIndexChanged += new System.EventHandler(this.LoadEmployeStatistics);
            // 
            // cb_estadisticaAnio
            // 
            this.cb_estadisticaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadisticaAnio.FormattingEnabled = true;
            this.cb_estadisticaAnio.Location = new System.Drawing.Point(242, 7);
            this.cb_estadisticaAnio.Name = "cb_estadisticaAnio";
            this.cb_estadisticaAnio.Size = new System.Drawing.Size(90, 21);
            this.cb_estadisticaAnio.TabIndex = 2;
            this.cb_estadisticaAnio.SelectedIndexChanged += new System.EventHandler(this.LoadEmployeStatistics);
            // 
            // chk_estadisticaTodos
            // 
            this.chk_estadisticaTodos.AutoSize = true;
            this.chk_estadisticaTodos.Enabled = false;
            this.chk_estadisticaTodos.Location = new System.Drawing.Point(339, 9);
            this.chk_estadisticaTodos.Name = "chk_estadisticaTodos";
            this.chk_estadisticaTodos.Size = new System.Drawing.Size(56, 17);
            this.chk_estadisticaTodos.TabIndex = 3;
            this.chk_estadisticaTodos.Text = "Todos";
            this.chk_estadisticaTodos.UseVisualStyleBackColor = true;
            this.chk_estadisticaTodos.Visible = false;
            this.chk_estadisticaTodos.CheckedChanged += new System.EventHandler(this.LoadEmployeStatistics);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(630, 442);
            this.Controls.Add(this.tc_employee);
            this.Controls.Add(this.btn_addNewEmploye);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_employe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Empleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.tc_employee.ResumeLayout(false);
            this.tp_general.ResumeLayout(false);
            this.tp_general.PerformLayout();
            this.tp_payments.ResumeLayout(false);
            this.tp_payments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeePayments)).EndInit();
            this.tp_statistics.ResumeLayout(false);
            this.tp_statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_employe;
        private Button btn_close;
        private Button btn_addNewEmploye;
        private TabControl tc_employee;
        private TabPage tp_general;
        private TextBox tb_employePosition;
        private TextBox tb_employePhone;
        private TextBox tb_employeAddress;
        private TextBox tb_employeDni;
        private TextBox tb_employeLastName;
        private Label lbl_employeLastName;
        private TextBox tb_employeFirstName;
        private Button btn_deleteEmploye;
        private Button btn_save;
        private Label lbl_employePosition;
        private Label lbl_employeDni;
        private Label lbl_employePhone;
        private Label lbl_employeAddress;
        private Label lbl_employeFirstName;
        private TabPage tp_payments;
        private Button btn_registerPayment;
        private TabPage tp_statistics;
        private DataGridView dgv_employeePayments;
        private Label lbl_paysDateTo;
        private Label lbl_paysDateFrom;
        private DateTimePicker dtp_paysDateTo;
        private DateTimePicker dtp_paysDateFrom;
        private Label lbl_paysTotalValue;
        private Label lbl_paysTotal;
        private CheckBox chk_estadisticaTodos;
        private ComboBox cb_estadisticaAnio;
        private ComboBox cb_estadisticaTipo;
        private DataGridView dgv_estadistica;
    }
}