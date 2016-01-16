using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LoadclientListBox();            
        }

        private void LoadclientListBox()
        {
            Bd dbCon = new Bd();

            lb_clients.DataSource = dbCon.Read("SELECT id,CONCAT(nombre,' ',apellido) as nombre FROM cliente WHERE id > 0");
            lb_clients.DisplayMember = "nombre";
            lb_clients.SelectedIndex = -1;
            ClearAllFields();
        }

        private void lb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_clients.SelectedIndex != -1)
            {
                gb_clientData.Enabled = true;
                int clienteId = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
                gb_clientData.Text = "Datos de " + (lb_clients.SelectedItem as DataRowView)["nombre"];

                Bd dbCon = new Bd();
                DataRow data = dbCon.Read("SELECT * FROM cliente WHERE id =" + clienteId).Rows[0];

                LoadAllclientData(data);
            }
            else
            {
                gb_clientData.Enabled = false;
            }           
        }

        private void ClearAllFields()
        {
            gb_clientData.Text = "";
            tb_clientFirstName.Clear();
            tb_clientLastName.Clear();
            tb_clientDni.Clear();
            tb_clientPhone.Clear();
            tb_clientAddress.Clear();
            tb_clientAccount.Clear();
        }

        private void LoadAllclientData(DataRow data)
        {
            tb_clientFirstName.Text = data["nombre"].ToString();
            tb_clientLastName.Text = data["apellido"].ToString();
            tb_clientDni.Text = data["dni"].ToString();
            tb_clientAddress.Text = data["direccion"].ToString();
            tb_clientPhone.Text = data["telefono"].ToString();
            tb_clientAccount.Text = data["saldo"].ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_deleteclient_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int clienteId = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
                Bd dBcon = new Bd();
                dBcon.Write("DELETE FROM cliente WHERE id = " + clienteId);
                LoadclientListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int cliId = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
            string cliFirstName = tb_clientFirstName.Text.Trim();
            string cliLastName= tb_clientLastName.Text.Trim();
            string cliAddress = tb_clientAddress.Text.Trim();
            string cliPhone = tb_clientPhone.Text.Trim();
            double saldo = double.Parse(tb_clientAccount.Text.Trim());
            string cliDni = tb_clientDni.Text.Trim();

            Bd dbCon = new Bd();
            string query = "UPDATE cliente SET nombre = '{0}',apellido = '{1}', dni = '{2}', direccion = '{3}', telefono = '{4}',saldo = {5} WHERE id = {6}";           
            query = String.Format(query, cliFirstName, cliLastName, cliDni, cliAddress, cliPhone, saldo.ToString("0.00",CultureInfo.InvariantCulture),cliId);
            dbCon.Write(query);

            LoadclientListBox();

        }

        private void btn_addNewclient_Click(object sender, EventArgs e)
        {
            AgregarNuevoCliente anc = new AgregarNuevoCliente();
            if (anc.ShowDialog(this) == DialogResult.OK)
            {
                string cliFirstName = anc.tb_firstName.Text.Trim();
                string cliLastName = anc.tb_lastName.Text.Trim();
                Bd dbCon = new Bd();
                dbCon.Write(String.Format("INSERT INTO cliente (nombre, apellido) VALUES ('{0}','{1}')", cliFirstName, cliLastName));
                LoadclientListBox();
            }
        }

        private void tb_clientName_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_clientFirstName.Text.Trim().Length > 3 && tb_clientLastName.Text.Trim().Length > 3;
        }

        private void tb_clientAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '\b') return;
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            else
            {
                tb_generic_KeyPress(sender, e);
            }
        }

        private void tb_generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r') return;
            btn_save.PerformClick();
            e.Handled = true;
        }

    }
}
