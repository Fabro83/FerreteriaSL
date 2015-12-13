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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            loadclientListBox();            
        }

        private void loadclientListBox()
        {
            BD DBCon = new BD();

            lb_clients.DataSource = DBCon.Read("SELECT id,CONCAT(nombre,' ',apellido) as nombre FROM cliente WHERE id > 0");
            lb_clients.DisplayMember = "nombre";
            lb_clients.SelectedIndex = -1;
            clearAllFields();
        }

        private void lb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_clients.SelectedIndex != -1)
            {
                gb_clientData.Enabled = true;
                int cliente_id = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
                gb_clientData.Text = "Datos de " + (lb_clients.SelectedItem as DataRowView)["nombre"].ToString();

                BD DBCon = new BD();
                DataRow data = DBCon.Read("SELECT * FROM cliente WHERE id =" + cliente_id).Rows[0];

                loadAllclientData(data);
            }
            else
            {
                gb_clientData.Enabled = false;
            }           
        }

        private void clearAllFields()
        {
            gb_clientData.Text = "";
            tb_clientFirstName.Clear();
            tb_clientLastName.Clear();
            tb_clientDni.Clear();
            tb_clientPhone.Clear();
            tb_clientAddress.Clear();
            tb_clientAccount.Clear();
        }

        private void loadAllclientData(DataRow data)
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
            this.Close();
        }

        private void btn_deleteclient_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int cliente_id = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
                BD DBcon = new BD();
                DBcon.Write("DELETE FROM cliente WHERE id = " + cliente_id);
                loadclientListBox();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int cli_id = int.Parse((lb_clients.SelectedItem as DataRowView)["id"].ToString());
            string cli_firstName = tb_clientFirstName.Text.Trim();
            string cli_lastName= tb_clientLastName.Text.Trim();
            string cli_address = tb_clientAddress.Text.Trim();
            string cli_phone = tb_clientPhone.Text.Trim();
            double saldo = double.Parse(tb_clientAccount.Text.Trim());
            string cli_dni = tb_clientDni.Text.Trim();

            BD DBCon = new BD();
            string query = "UPDATE cliente SET nombre = '{0}',apellido = '{1}', dni = '{2}', direccion = '{3}', telefono = '{4}',saldo = {5} WHERE id = {6}";           
            query = String.Format(query, cli_firstName, cli_lastName, cli_dni, cli_address, cli_phone, saldo.ToString("0.00",CultureInfo.InvariantCulture),cli_id);
            DBCon.Write(query);

            loadclientListBox();

        }

        private void btn_addNewclient_Click(object sender, EventArgs e)
        {
            AgregarNuevoCliente ANC = new AgregarNuevoCliente();
            if (ANC.ShowDialog(this) == DialogResult.OK)
            {
                string cli_firstName = ANC.tb_firstName.Text.Trim();
                string cli_LastName = ANC.tb_lastName.Text.Trim();
                BD DBCon = new BD();
                DBCon.Write(String.Format("INSERT INTO cliente (nombre, apellido) VALUES ('{0}','{1}')", cli_firstName, cli_LastName));
                loadclientListBox();
            }
        }

        private void tb_clientName_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_clientFirstName.Text.Trim().Length > 3 && tb_clientLastName.Text.Trim().Length > 3;
        }

        private void tb_clientAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == '\b'))
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                else
                {
                    tb_generic_KeyPress(sender, e);
                }
            }       
        }

        private void tb_generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btn_save.PerformClick();
                e.Handled = true;
            }
        }

    }
}
