using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            loadProviderListBox();            
        }


        private void loadProviderListBox()
        {
            BD DBCon = new BD();

            lb_providers.DataSource = DBCon.Read("SELECT id,nombre FROM proveedor");
            lb_providers.DisplayMember = "nombre";
            lb_providers.SelectedIndex = -1;
            clearAllFields();
        }

        private void lb_provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_providers.SelectedIndex != -1)
            {
                gb_providerData.Enabled = true;
                int pro_id = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
                gb_providerData.Text = "Datos de " + (lb_providers.SelectedItem as DataRowView)["nombre"].ToString();

                BD DBCon = new BD();
                DataRow data = DBCon.Read("SELECT * FROM proveedor WHERE id =" + pro_id).Rows[0];

                loadAllProviderData(data);
            }
            else
            {
                gb_providerData.Enabled = false;
            }           
        }

        private void clearAllFields()
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

        private void loadAllProviderData(DataRow data)
        {
            tb_providerName.Text = data["nombre"].ToString();
            tb_providerCuit.Text = data["cuit"].ToString();
            tb_providerPhone.Text = data["telefono"].ToString();
            tb_providerAddress.Text = data["direccion"].ToString();
            loadStatistics(int.Parse(data["id"].ToString()));
        }

        private void loadStatistics(int pro_id)
        {
            BD DBCon = new BD();
            int itemQuantity = int.Parse(DBCon.Read("SELECT Count(id) FROM producto WHERE id_proveedor = " + pro_id).Rows[0][0].ToString());
            int soldItems = int.Parse(DBCon.Read("SELECT Count(id) FROM venta_producto WHERE proveedor_id = " + pro_id).Rows[0][0].ToString());
            int itemQuantityInStock = int.Parse(DBCon.Read("SELECT Count(id) FROM producto WHERE stock > 0 AND id_proveedor = " + pro_id).Rows[0][0].ToString());
            double totalImportValue = 0;
            DataTable res = DBCon.Read("SELECT SUM(precio_unitario * cantidad) FROM venta_producto WHERE proveedor_id = " + pro_id);
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
            this.Close();
        }

        private void btn_deleteProvider_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MessageBox.Show("Al eliminar este proveedor, todos los articulos a su nombre serán eliminados tambien.\n¿Está seguro de querer proseguir?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int pro_id = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
                    BD DBcon = new BD();
                    DBcon.Write("DELETE FROM producto WHERE id_proveedor = " + pro_id);
                    DBcon.Write("DELETE FROM proveedor WHERE id = " + pro_id);
                    loadProviderListBox();
                }           
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int pro_id = int.Parse((lb_providers.SelectedItem as DataRowView)["id"].ToString());
            string pro_nombre = tb_providerName.Text.Trim();
            string pro_cuit = tb_providerCuit.Text.Trim();
            string pro_telefono = tb_providerPhone.Text.Trim();
            string pro_direccion = tb_providerAddress.Text.Trim();

            BD DBCon = new BD();
            string query = "UPDATE proveedor SET cuit = '{0}',nombre = '{1}', telefono = '{2}', direccion = '{3}' WHERE id = {4}";
            query = String.Format(query, pro_cuit, pro_nombre, pro_telefono, pro_direccion, pro_id);
            DBCon.Write(query);

            loadProviderListBox();

        }

        private void btn_addNewProvider_Click(object sender, EventArgs e)
        {
            AgregarNuevoProveedor ANP = new AgregarNuevoProveedor();
            if (ANP.ShowDialog(this) == DialogResult.OK)
            {
                string pro_nombre = ANP.tb_name.Text.Trim();
                string pro_cuit = ANP.tb_cuit.Text.Trim();
                string pro_telefono = ANP.tb_phone.Text.Trim();
                string pro_direccion = ANP.tb_address.Text.Trim();
                BD DBCon = new BD();
                DBCon.Write(String.Format("INSERT INTO proveedor (nombre,cuit,telefono,direccion) VALUES ('{0}','{1}','{2}','{3}')",pro_nombre,pro_cuit,pro_telefono,pro_direccion));
                loadProviderListBox();
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
