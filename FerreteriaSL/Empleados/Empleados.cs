using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Empleados
{
    public partial class Empleados : Form
    {
        private int _empId = -1;

        private static readonly string[] statisticsTypes = {
            "Ventas",
            "Articulos",
            "Recaudacion"
        };


        public Empleados()
        {
            InitializeComponent();
            LoadEmployeListBox();
            FillStatisticsYearComboBox();
            SetTextBoxEvent();
        }

        private void FillStatisticsYearComboBox()
        {
            int currentYear = DateTime.Today.Year;
            for (int i = currentYear; i >= 2013; i--)
            {
                cb_estadisticaAnio.Items.Add(i);
            }
        }

        private void SetTextBoxEvent()
        {
            foreach (TextBox control in tp_general.Controls.OfType<TextBox>())
            {
                control.KeyPress += tb_employeData_KeyPress;
            }
        }

        private void LoadEmployeListBox()
        {
            Bd dbCon = new Bd();

            lb_employe.DataSource = dbCon.Read("SELECT id,CONCAT(nombre,' ',apellido) as nombre FROM empleado WHERE id > 0");
            lb_employe.DisplayMember = "nombre";
            lb_employe.SelectedIndex = -1;
            ClearAllFields();
        }

        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_employe.SelectedIndex != -1)
            {
                tc_employee.Enabled = true;
                _empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());

                Bd dbCon = new Bd();
                DataRow data = dbCon.Read("SELECT * FROM empleado WHERE id =" + _empId).Rows[0];

                LoadAllUserData(data);
            }
            else
            {
                tc_employee.Enabled = false;
            }           
        }

        private void ClearAllFields()
        {
            tb_employeFirstName.Text = "";
            tb_employeLastName.Text = "";
            tb_employeDni.Text = "";
            tb_employeAddress.Text = "";
            tb_employePhone.Text = "";
            tb_employePosition.Text = "";
        }

        private void LoadAllUserData(DataRow data)
        {
            tb_employeFirstName.Text = data["nombre"].ToString();
            tb_employeLastName.Text = data["apellido"].ToString();
            tb_employeDni.Text = data["dni"].ToString();
            tb_employeAddress.Text = data["direccion"].ToString();
            tb_employePhone.Text = data["telefono"].ToString();
            tb_employePosition.Text = data["cargo"].ToString();
            LoadEmployeePays();
        }

        private string BuildPaymentFilters()
        {
            var dateFrom = dtp_paysDateFrom.Checked ? String.Format("fecha_pago >= '{0:yyyy-MM-dd}'", dtp_paysDateFrom.Value) : "";
            var dateTo = dtp_paysDateTo.Checked ? String.Format("fecha_pago <= '{0:yyyy-MM-dd}'", dtp_paysDateTo.Value) : "";
            var connector = dateFrom != "" && dateTo != "" ? " AND " : "";
            return (dateFrom != "" || dateTo != "" ? " AND " : " ") + dateFrom + connector + dateTo + " ";
        }



        private void LoadEmployeePays()
        {


            Bd dbCon = new Bd();
            DataTable res = dbCon.Read("SELECT fecha_pago as Fecha,año as ano, type_mes.mes as Mes, monto as Monto, observacion as obs,empleado_pago.mes as ocultar " +
                                       "FROM empleado_pago LEFT JOIN type_mes ON empleado_pago.mes = type_mes.id WHERE empleado_id = " + _empId + BuildPaymentFilters() +
                                       " ORDER BY ano, empleado_pago.mes, empleado_pago.id DESC");

            dgv_employeePayments.DataSource = res;
            dgv_employeePayments.Columns["Monto"].DefaultCellStyle.Format = "$0.00";
            dgv_employeePayments.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_employeePayments.Columns["ano"].HeaderText = "Año";
            dgv_employeePayments.Columns["obs"].HeaderText = "Observación";
            dgv_employeePayments.Columns["ocultar"].Visible = false;
            foreach (var sColumn in dgv_employeePayments.Columns.Cast<DataGridViewColumn>().Where(sColumn => sColumn.Name != "obs"))
            {
                sColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            lbl_paysTotalValue.Text = String.Format("${0:N2}",
                dgv_employeePayments.Rows.Cast<DataGridViewRow>()
                    .Sum(s => double.Parse(s.Cells["Monto"].Value.ToString())));
        }

        private void LoadEmployeStatistics(object sender, EventArgs e)
        {
            if (cb_estadisticaTipo.SelectedIndex == -1 || cb_estadisticaAnio.SelectedIndex == -1) return;
            string type = statisticsTypes[cb_estadisticaTipo.SelectedIndex];
            int year = (int)cb_estadisticaAnio.SelectedItem;
            bool allYears = chk_estadisticaTodos.Checked && chk_estadisticaTodos.Enabled; // Not used yet, to be implemented with another statistics
            
            Bd dbCon = new Bd();
            var query = "SELECT Mes, Total FROM vista_estadisticaEmpleado_{0} WHERE empleado_id = {1} {2} ORDER BY y desc, m desc";
            query = String.Format(query, type, _empId, allYears ? "" : "AND y = " + year);
            DataTable res = dbCon.Read(query);

            dgv_estadistica.DataSource = res;
            dgv_estadistica.Columns["Total"].DefaultCellStyle.Format = type == statisticsTypes[2] ? "$0.00" : "0";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_deleteUser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int usuarioId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                Bd dBcon = new Bd();
                dBcon.Write("DELETE FROM empleado WHERE id = " + usuarioId);
                LoadEmployeListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
            string empNombre = tb_employeFirstName.Text.Trim();
            string empApellido = tb_employeLastName.Text.Trim();
            string empDireccion = tb_employeAddress.Text.Trim();
            string empTelefono = tb_employePhone.Text.Trim();
            string empDni = tb_employeDni.Text.Trim();
            string empCargo = tb_employePosition.Text.Trim();

            Bd dbCon = new Bd();
            string query = "UPDATE empleado SET nombre = '{0}',apellido = '{1}', direccion = '{2}', telefono = '{3}',dni = '{4}',cargo = '{5}' WHERE id = {6}";
            query = String.Format(query, empNombre,empApellido,empDireccion,empTelefono,empDni,empCargo,empId);
            dbCon.Write(query);

            LoadEmployeListBox();

        }

        private void btn_addNewEmploye_Click(object sender, EventArgs e)
        {
            AgregarNuevoEmpleado ane = new AgregarNuevoEmpleado();
            if (ane.ShowDialog(this) == DialogResult.OK)
            {
                string empNombre = ane.tb_firstName.Text.Trim();
                string empApellido = ane.tb_lastName.Text.Trim();
                Bd dbCon = new Bd();
                dbCon.Write(String.Format("INSERT INTO empleado (nombre, apellido) VALUES ('{0}','{1}')", empNombre, empApellido));
                LoadEmployeListBox();
            }
        }

        private void tb_employeFirstName_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_employeFirstName.Text.Trim().Length > 3 && tb_employeLastName.Text.Trim().Length > 3;
        }

        private void btn_registerPayment_Click(object sender, EventArgs e)
        {
            RegistrarPago rp = new RegistrarPago();
            if (rp.ShowDialog(this) != DialogResult.OK) return;
            int empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
            string empPagFechaPago = rp.dtp_registerDate.Value.ToString("yyyy-MM-dd");
            double empPagMonto = Convert.ToDouble(rp.nud_mountToPay.Value);
            int empPagMes = rp.cb_monthToPay.SelectedIndex;
            int empPagAño = int.Parse(rp.nud_yearToPay.Value.ToString());
            string empPagObservacion = rp.tb_observation.Text.Trim();

            Bd dbCon = new Bd();
 
            const string query = "INSERT INTO empleado_pago (empleado_id,monto,fecha_pago,mes,año,observacion) VALUES ({0},{1},'{2}',{3},{4},'{5}')";
            dbCon.Write(String.Format(query, empId, empPagMonto.ToString("0.00",CultureInfo.InvariantCulture), empPagFechaPago, empPagMes, empPagAño, empPagObservacion));
            LoadEmployeePays();
        }

        private void tb_employeData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_save.PerformClick();
        }

        private void dtp_paysDate_Change(object sender, EventArgs e)
        {
            LoadEmployeePays();
        }

        private void dgv_employeePayments_SelectionChanged(object sender, EventArgs e)
        {         
            if (dgv_employeePayments.SelectedRows.Count <= 1) return;
            lbl_paysTotalValue.Text = String.Format("${0:F}", dgv_employeePayments.SelectedRows.Cast<DataGridViewRow>().Sum(s => float.Parse(s.Cells["Monto"].Value.ToString())));
        }

    }
}
