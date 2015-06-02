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
    public partial class Pedidos : Form
    {
        BD DBCon;

        public Pedidos()
        {
            InitializeComponent();
            DBCon = new BD();
            loadProviderListBox();
            cb_tipoPedido.SelectedIndex = 0;
        }

        void loadProviderListBox()
        {
            lb_proveedores.DataSource = DBCon.Read("SELECT id, nombre FROM proveedor");
            lb_proveedores.DisplayMember = "nombre";
            lb_proveedores.SelectedIndex = -1;
            DBCon.CloseConnection();
        }

        private void lb_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_pedidos.DataSource = null;
            dgv_pedido.DataSource = null;
            gb_datosPedido.Enabled = false;
            cb_tipoPedido.Enabled = false;
            lb_pedidos.Enabled = false;
            btn_agregarNuevoPedido.Enabled = false;
            if (lb_proveedores.SelectedIndex != -1)
            {
                cb_tipoPedido.Enabled = true;
                lb_pedidos.Enabled = true;
                btn_agregarNuevoPedido.Enabled = true;
                btn_agregarNuevoPedido.Text = "Agregar Pedido a " + (lb_proveedores.SelectedItem as DataRowView)["nombre"].ToString();
                string pro_id = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                lb_pedidos.SelectedIndexChanged -= lb_pedidos_SelectedIndexChanged;
                lb_pedidos.DataSource = DBCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + pro_id );                               
                lb_pedidos.DisplayMember = "fecha";
                string filtro = cb_tipoPedido.SelectedIndex == 0 ? "fecha_arrivo IS NULL" : "fecha_arrivo IS NOT NULL";
                (lb_pedidos.DataSource as DataTable).DefaultView.RowFilter = filtro;
                lb_pedidos.SelectedIndex = -1;
                lb_pedidos.SelectedIndexChanged += lb_pedidos_SelectedIndexChanged;
            }
            else
            {
                btn_agregarNuevoPedido.Text = "Agregar Pedido";
            }
        }


        private void cb_tipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_pedidos.DataSource != null)
            {
                string filtro = cb_tipoPedido.SelectedIndex == 0 ? "fecha_arrivo IS NULL" : "fecha_arrivo IS NOT NULL";
                (lb_pedidos.DataSource as DataTable).DefaultView.RowFilter = filtro;
                lb_pedidos.SelectedIndex = -1;
            }         
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_pedidos.SelectedIndex != -1)
            {
                gb_datosPedido.Enabled = true;
                string dateString = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString();
                string pedido_id = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
                string proveedor = (lb_proveedores.SelectedItem as DataRowView)["nombre"].ToString();
                string fecha_arrivo = (lb_pedidos.SelectedItem as DataRowView)["fecha_arrivo"].ToString();
                if (fecha_arrivo != "")
                {
                    btn_registrarIngreso.Enabled = false;
                    lbl_fechaArrivoValue.Text = fecha_arrivo.Remove(10);
                }
                else
                {
                    btn_registrarIngreso.Enabled = true;
                    lbl_fechaArrivoValue.Text = "N/A";
                }
                dtp_fechaPedido.Value = DateTime.Parse(dateString);
                gb_datosPedido.Text = "Datos del Pedido " + dtp_fechaPedido.Value.ToString("dd/MM/yyyy") + " a " + proveedor;
                dgv_pedido.DataSource = DBCon.Read("SELECT * FROM vista_pedidoProducto WHERE PedidoID = " + pedido_id);
            }
            else
            {
                gb_datosPedido.Enabled = false;
                dgv_pedido.DataSource = null;
            }
            
                             
        }

        private void dgv_pedido_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_pedido.DataSource != null)
            {
                dgv_pedido.Columns["PedidoID"].Visible = false;
                dgv_pedido.Columns["id"].Visible = false;
                dgv_pedido.Columns["Costo"].DefaultCellStyle.Format = "$0.00";
                
                foreach (DataGridViewColumn sCol in dgv_pedido.Columns)
                {
                    if (sCol.Name != "Articulo")
                        sCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (sCol.Name != "Cantidad")
                        sCol.ReadOnly = true;
                }
                calculateTotal();
            }
            
        }

        private void calculateTotal()
        {
            double costoTotal = 0;
            foreach (DataGridViewRow sRow in dgv_pedido.Rows)
            {
                costoTotal += double.Parse(sRow.Cells["Costo"].Value.ToString().Replace("$", "")) * double.Parse(sRow.Cells["Cantidad"].Value.ToString());
            }
            lbl_costoTotalValue.Text = "$" + costoTotal.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void btn_eliminarPedido_Click(object sender, EventArgs e)
        {
            string ped_id = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            if (MessageBox.Show("¿Está seguro que desea elminar este pedido?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DBCon.Write("DELETE FROM pedido WHERE id = " + ped_id);
                DBCon.Write("DELETE FROM pedido_producto WHERE pedido_id = "+ped_id);
                DBCon.CloseConnection();
                lb_proveedores_SelectedIndexChanged(this,EventArgs.Empty);
            }
        }

        private void btn_agregarProductos_Click(object sender, EventArgs e)
        {
            BusquedaProducto BP = new BusquedaProducto(int.Parse((lb_proveedores.SelectedItem as DataRowView)["id"].ToString()));
            BP.Show();
        }

        public void addItemToCartFromSearchWindow(int producto_id, double cantidad)
        {
            string pedido_id = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            string query = "INSERT INTO pedido_producto (pedido_id, producto_id, cantidad) VALUES ({0},{1},{2})";
            DBCon.Write(String.Format(query,pedido_id,producto_id,cantidad.ToString("0.00",CultureInfo.InvariantCulture)));
            dgv_pedido.DataSource = DBCon.Read("SELECT * FROM vista_pedidoProducto WHERE PedidoID = " + pedido_id);
        }

        private void dgv_pedido_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string ped_pro_id = dgv_pedido["id",e.RowIndex].Value.ToString();
            string ped_pro_cantidad = dgv_pedido["Cantidad", e.RowIndex].Value.ToString().Replace(",",".");
            DBCon.Write("UPDATE pedido_producto SET cantidad = " + ped_pro_cantidad + " WHERE id = " + ped_pro_id);
            calculateTotal();
        }

        private void dgv_pedido_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string ped_pro_id = e.Row.Cells["id"].Value.ToString();
            DBCon.Write("DELETE FROM pedido_producto WHERE id = " + ped_pro_id);
        }

        private void btn_cambiarFecha_Click(object sender, EventArgs e)
        {
            string nuevaFecha = dtp_fechaPedido.Value.ToString("yyyy-MM-dd");
            string ped_id = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            DBCon.Write("UPDATE pedido SET fecha = '" + nuevaFecha + "' WHERE id = " + ped_id);
            string pro_id = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
            lb_pedidos.DataSource = DBCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + pro_id);
            btn_cambiarFecha.Enabled = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString().Remove(10) != dtp_fechaPedido.Value.ToString("dd/MM/yyyy");
        }

        private void btn_agregarNuevoPedido_Click(object sender, EventArgs e)
        {
            AgregarPedido AP = new AgregarPedido();
            if (AP.ShowDialog(this) == DialogResult.OK)
            {
                string pro_id = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                string ped_fecha = AP.dtp_fecha.Value.ToString("yyyy-MM-dd");
                DBCon.Write(String.Format("INSERT INTO pedido (fecha, proveedor_id) VALUES ('{0}',{1})",ped_fecha,pro_id));
                lb_pedidos.DataSource = DBCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + pro_id);
                cb_tipoPedido.SelectedIndex = 0;
            }
        }

        private void btn_registrarIngreso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Éstá seguro de querer registrar el ingreso de este pedido con los datos especificados?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string ped_fecha_arrivo = DateTime.Now.ToString("yyyy-MM-dd");
                string ped_id = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
                string pro_id = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                DBCon.Write("UPDATE pedido SET fecha_arrivo = '" + ped_fecha_arrivo + "' WHERE id = " + ped_id);
                DBCon.Write("CALL sp_updateStock(" + ped_id + ")");
                lb_pedidos.DataSource = DBCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + pro_id);
                cb_tipoPedido.SelectedIndex = 1;
            }
        }

        private void dtp_fechaPedido_ValueChanged(object sender, EventArgs e)
        {
            btn_cambiarFecha.Enabled = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString().Remove(10) != dtp_fechaPedido.Value.ToString("dd/MM/yyyy");
        }

        private void dgv_pedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

    }
}
