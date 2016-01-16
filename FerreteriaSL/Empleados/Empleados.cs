using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            LoadEmployeListBox();            
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
                gb_employeData.Enabled = true;
                int empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                gb_employeData.Text = "Datos de " + (lb_employe.SelectedItem as DataRowView)["nombre"];

                Bd dbCon = new Bd();
                DataRow data = dbCon.Read("SELECT * FROM empleado WHERE id =" + empId).Rows[0];

                LoadAllUserData(data);
            }
            else
            {
                gb_employeData.Enabled = false;
            }           
        }

        private void ClearAllFields()
        {
            gb_employeData.Text = "";
            tb_employeFirstName.Text = "";
            tb_employeLastName.Text = "";
            tb_employeDni.Text = "";
            tb_employeAddress.Text = "";
            tb_employePhone.Text = "";
            tb_employePosition.Text = "";
            lbl_sellCountValue.Text = "";
            lbl_soldProductsValue.Text = "";
            lbl_amountRecaudedValue.Text = "";
        }

        private void LoadAllUserData(DataRow data)
        {
            tb_employeFirstName.Text = data["nombre"].ToString();
            tb_employeLastName.Text = data["apellido"].ToString();
            tb_employeDni.Text = data["dni"].ToString();
            tb_employeAddress.Text = data["direccion"].ToString();
            tb_employePhone.Text = data["telefono"].ToString();
            tb_employePosition.Text = data["cargo"].ToString();

            LoadEmployeStatistics(int.Parse(data["id"].ToString()));

        }

        private void LoadEmployeStatistics(int empId)
        {
            Bd dbCon = new Bd();

            string query = "SELECT ventas_caja.id as ID,ventas_caja.importe_total as Importe FROM usuario \n" +
                           "LEFT JOIN ventas_caja ON ventas_caja.usuario_id = usuario.id\n" +
                           "WHERE usuario.empleado_id = " + empId;

            DataTable res = dbCon.Read(query);

            int sellCountValue = res.Rows.Count;
            double amountRecauded = 0;
            int soldProducts = 0;

            foreach(DataRow sRow in res.Rows)
            {
                amountRecauded += double.Parse(sRow["Importe"].ToString());
                try
                {
                    soldProducts += int.Parse(dbCon.Read("SELECT SUM(cantidad) FROM venta_producto WHERE ventas_caja_id = "+sRow["ID"]).Rows[0][0].ToString());
                }
                catch(FormatException)
                {
                    
                }
            }
            lbl_sellCountValue.Text = sellCountValue.ToString();
            lbl_amountRecaudedValue.Text = amountRecauded.ToString("$0.00");
            lbl_soldProductsValue.Text = soldProducts.ToString();
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

        private void btn_viewPayments_Click(object sender, EventArgs e)
        {
            int empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
            string empNombre = (lb_employe.SelectedItem as DataRowView)["nombre"].ToString();
            EmpleadosVerPagos evp = new EmpleadosVerPagos(empId, empNombre);
            evp.Show(this);
        }

        private void btn_registerPayment_Click(object sender, EventArgs e)
        {
            RegistrarPago rp = new RegistrarPago();
            if (rp.ShowDialog(this) == DialogResult.OK)
            {
                int empId = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                string empPagFechaPago = rp.dtp_registerDate.Value.ToString("yyyy-MM-dd");
                double empPagMonto = Convert.ToDouble(rp.nud_mountToPay.Value);
                int empPagMes = rp.cb_monthToPay.SelectedIndex;
                int empPagAño = int.Parse(rp.nud_yearToPay.Value.ToString());
                string empPagObservacion = rp.tb_observation.Text.Trim();

                Bd dbCon = new Bd();
 
                const string query = "INSERT INTO empleado_pago (empleado_id,monto,fecha_pago,mes,año,observacion) VALUES ({0},{1},'{2}',{3},{4},'{5}')";
                dbCon.Write(String.Format(query, empId, empPagMonto.ToString("0.00",CultureInfo.InvariantCulture), empPagFechaPago, empPagMes, empPagAño, empPagObservacion));

            }
        }

        private void tb_employeData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_save.PerformClick();
        }

    }
}
