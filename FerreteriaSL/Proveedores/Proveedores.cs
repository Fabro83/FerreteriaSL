using System;
using System.Data;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            LoadProviderListBox();            
        }


        private void LoadProviderListBox()
        {
            Bd dbCon = new Bd();

            lb_providers.DataSource = dbCon.Read("SELECT id,nombre FROM proveedor");
            lb_providers.DisplayMember = "nombre";
            lb_providers.SelectedIndex = -1;
            ClearAllFields();
        }

        private void lb_provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_providers.SelectedIndex != -1)
            {
                gb_providerData.Enabled = true;
                int proId = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
                gb_providerData.Text = "Datos de " + (lb_providers.SelectedItem as DataRowView)["nombre"].ToString();

                Bd dbCon = new Bd();
                DataRow data = dbCon.Read("SELECT * FROM proveedor WHERE id =" + proId).Rows[0];

                LoadAllProviderData(data);
            }
            else
            {
                gb_providerData.Enabled = false;
            }           
        }

        private void ClearAllFields()
        {
            gb_providerData.Text = "";
            tb_providerName.Text = "";
            tb_providerCuit.Text = "";
            tb_providerAddress.Text = "";
            tb_providerPhone.Text = "";
            lbl_itemQuantityValue.Text = "N/A";
            lbl_soldItemsValue.Text = "N/A";
            lbl_totalImportValue.Text = "N/A";
            lbl_itemQuantityInStockValue.Text = "N/A";
        }

        private void LoadAllProviderData(DataRow data)
        {
            tb_providerName.Text = data["nombre"].ToString();
            tb_providerCuit.Text = data["cuit"].ToString();
            tb_providerPhone.Text = data["telefono"].ToString();
            tb_providerAddress.Text = data["direccion"].ToString();
            LoadStatistics(int.Parse(data["id"].ToString()));
        }

        private void LoadStatistics(int proId)
        {
            Bd dbCon = new Bd();
            int itemQuantity = int.Parse(dbCon.Read("SELECT Count(id) FROM producto WHERE id_proveedor = " + proId).Rows[0][0].ToString());
            int soldItems = int.Parse(dbCon.Read("SELECT Count(id) FROM venta_producto WHERE proveedor_id = " + proId).Rows[0][0].ToString());
            int itemQuantityInStock = int.Parse(dbCon.Read("SELECT Count(id) FROM producto WHERE stock > 0 AND id_proveedor = " + proId).Rows[0][0].ToString());
            double totalImportValue = 0;
            DataTable res = dbCon.Read("SELECT SUM(precio_unitario * cantidad) FROM venta_producto WHERE proveedor_id = " + proId);
            if (res.Rows.Count > 0)
            {
                try
                {
                    totalImportValue = double.Parse(res.Rows[0][0].ToString());
                }
                catch (FormatException e)
                { 
                    
                }
                
            }

            lbl_itemQuantityValue.Text = itemQuantity.ToString();
            lbl_itemQuantityInStockValue.Text = itemQuantityInStock.ToString();
            lbl_soldItemsValue.Text = soldItems.ToString();
            lbl_totalImportValue.Text = totalImportValue.ToString("$0.00");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_deleteProvider_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MessageBox.Show("Al eliminar este proveedor, todos los articulos a su nombre serán eliminados tambien.\n¿Está seguro de querer proseguir?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int proId = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
                    Bd dBcon = new Bd();
                    dBcon.Write("DELETE FROM producto WHERE id_proveedor = " + proId);
                    dBcon.Write("DELETE FROM proveedor WHERE id = " + proId);
                    LoadProviderListBox();
                }           
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int proId = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
            string proNombre = tb_providerName.Text.Trim();
            string proCuit = tb_providerCuit.Text.Trim();
            string proTelefono = tb_providerPhone.Text.Trim();
            string proDireccion = tb_providerAddress.Text.Trim();

            Bd dbCon = new Bd();
            string query = "UPDATE proveedor SET cuit = '{0}',nombre = '{1}', telefono = '{2}', direccion = '{3}' WHERE id = {4}";
            query = String.Format(query, proCuit, proNombre, proTelefono, proDireccion, proId);
            dbCon.Write(query);

            LoadProviderListBox();

        }

        private void btn_addNewProvider_Click(object sender, EventArgs e)
        {
            AgregarNuevoProveedor anp = new AgregarNuevoProveedor();
            if (anp.ShowDialog(this) == DialogResult.OK)
            {
                string proNombre = anp.tb_name.Text.Trim();
                string proCuit = anp.tb_cuit.Text.Trim();
                string proTelefono = anp.tb_phone.Text.Trim();
                string proDireccion = anp.tb_address.Text.Trim();
                Bd dbCon = new Bd();
                dbCon.Write(String.Format("INSERT INTO proveedor (nombre,cuit,telefono,direccion) VALUES ('{0}','{1}','{2}','{3}')",proNombre,proCuit,proTelefono,proDireccion));
                LoadProviderListBox();
            }
        }

        private void tb_providerName_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = tb_providerName.Text.Trim().Length > 3;
        }

        private void generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_save.PerformClick();
        }
    }
}
