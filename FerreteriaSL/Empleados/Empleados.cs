using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace FerreteriaSL
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            loadEmployeListBox();            
        }

        private void loadEmployeListBox()
        {
            BD DBCon = new BD();

            lb_employe.DataSource = DBCon.Read("SELECT id,CONCAT(nombre,' ',apellido) as nombre FROM empleado WHERE id > 0");
            lb_employe.DisplayMember = "nombre";
            lb_employe.SelectedIndex = -1;
            clearAllFields();
        }

        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_employe.SelectedIndex != -1)
            {
                gb_employeData.Enabled = true;
                int emp_id = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                gb_employeData.Text = "Datos de " + (lb_employe.SelectedItem as DataRowView)["nombre"].ToString();

                BD DBCon = new BD();
                DataRow data = DBCon.Read("SELECT * FROM empleado WHERE id =" + emp_id).Rows[0];

                loadAllUserData(data);
            }
            else
            {
                gb_employeData.Enabled = false;
            }           
        }

        private void clearAllFields()
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

        private void loadAllUserData(DataRow data)
        {
            tb_employeFirstName.Text = data["nombre"].ToString();
            tb_employeLastName.Text = data["apellido"].ToString();
            tb_employeDni.Text = data["dni"].ToString();
            tb_employeAddress.Text = data["direccion"].ToString();
            tb_employePhone.Text = data["telefono"].ToString();
            tb_employePosition.Text = data["cargo"].ToString();

            loadEmployeStatistics(int.Parse(data["id"].ToString()));

        }

        private void loadEmployeStatistics(int emp_id)
        {
            BD DBCon = new BD();

            string query = "SELECT ventas_caja.id as ID,ventas_caja.importe_total as Importe FROM usuario \n" +
                           "LEFT JOIN ventas_caja ON ventas_caja.usuario_id = usuario.id\n" +
                           "WHERE usuario.empleado_id = " + emp_id;

            DataTable res = DBCon.Read(query);

            int sellCountValue = res.Rows.Count;
            double amountRecauded = 0;
            int soldProducts = 0;

            foreach(DataRow sRow in res.Rows)
            {
                amountRecauded += double.Parse(sRow["Importe"].ToString());
                try
                {
                    soldProducts += int.Parse(DBCon.Read("SELECT SUM(cantidad) FROM venta_producto WHERE ventas_caja_id = "+sRow["ID"].ToString()).Rows[0][0].ToString());
                }
                catch(FormatException e)
                {
                    
                }
            }
            lbl_sellCountValue.Text = sellCountValue.ToString();
            lbl_amountRecaudedValue.Text = amountRecauded.ToString("$0.00");
            lbl_soldProductsValue.Text = soldProducts.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_deleteUser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int usuario_id = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                BD DBcon = new BD();
                DBcon.Write("DELETE FROM empleado WHERE id = " + usuario_id);
                loadEmployeListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int emp_id = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
            string emp_nombre = tb_employeFirstName.Text.Trim();
            string emp_apellido = tb_employeLastName.Text.Trim();
            string emp_direccion = tb_employeAddress.Text.Trim();
            string emp_telefono = tb_employePhone.Text.Trim();
            string emp_dni = tb_employeDni.Text.Trim();
            string emp_cargo = tb_employePosition.Text.Trim();

            BD DBCon = new BD();
            string query = "UPDATE empleado SET nombre = '{0}',apellido = '{1}', direccion = '{2}', telefono = '{3}',dni = '{4}',cargo = '{5}' WHERE id = {6}";
            query = String.Format(query, emp_nombre,emp_apellido,emp_direccion,emp_telefono,emp_dni,emp_cargo,emp_id);
            DBCon.Write(query);

            loadEmployeListBox();

        }

        private void btn_addNewEmploye_Click(object sender, EventArgs e)
        {
            AgregarNuevoEmpleado ANE = new AgregarNuevoEmpleado();
            if (ANE.ShowDialog(this) == DialogResult.OK)
            {
                string emp_nombre = ANE.tb_firstName.Text.Trim();
                string emp_apellido = ANE.tb_lastName.Text.Trim();
                BD DBCon = new BD();
                DBCon.Write(String.Format("INSERT INTO empleado (nombre, apellido) VALUES ('{0}','{1}')", emp_nombre, emp_apellido));
                loadEmployeListBox();
            }
        }

        private void tb_employeFirstName_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_employeFirstName.Text.Trim().Length > 3 && tb_employeLastName.Text.Trim().Length > 3;
        }

        private void btn_viewPayments_Click(object sender, EventArgs e)
        {
            int emp_id = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
            string emp_nombre = (lb_employe.SelectedItem as DataRowView)["nombre"].ToString();
            EmpleadosVerPagos EVP = new EmpleadosVerPagos(emp_id, emp_nombre);
            EVP.Show(this);
        }

        private void btn_registerPayment_Click(object sender, EventArgs e)
        {
            RegistrarPago RP = new RegistrarPago();
            if (RP.ShowDialog(this) == DialogResult.OK)
            {
                int emp_id = int.Parse((lb_employe.SelectedItem as DataRowView)["id"].ToString());
                string emp_pag_fecha_pago = RP.dtp_registerDate.Value.ToString("yyyy-MM-dd");
                double emp_pag_monto = Convert.ToDouble(RP.nud_mountToPay.Value);
                int emp_pag_mes = RP.cb_monthToPay.SelectedIndex;
                int emp_pag_año = int.Parse(RP.nud_yearToPay.Value.ToString());
                string emp_pag_observacion = RP.tb_observation.Text.Trim();

                BD DBCon = new BD();
 
                string query = "INSERT INTO empleado_pago (empleado_id,monto,fecha_pago,mes,año,observacion) VALUES ({0},{1},'{2}',{3},{4},'{5}')";
                DBCon.Write(String.Format(query, emp_id, emp_pag_monto.ToString("0.00",CultureInfo.InvariantCulture), emp_pag_fecha_pago, emp_pag_mes, emp_pag_año, emp_pag_observacion));

            }
        }

        private void tb_employeData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_save.PerformClick();
        }

    }
}
