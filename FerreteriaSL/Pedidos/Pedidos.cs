using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;
using FerreteriaSL.Ventas;

namespace FerreteriaSL.Pedidos
{
    public partial class Pedidos : Form
    {
        readonly Bd _dbCon;

        public Pedidos()
        {
            InitializeComponent();
            _dbCon = new Bd();
            LoadProviderListBox();
            cb_tipoPedido.SelectedIndex = 0;
        }

        void LoadProviderListBox()
        {
            lb_proveedores.DataSource = _dbCon.Read("SELECT id, nombre FROM proveedor");
            lb_proveedores.DisplayMember = "nombre";
            lb_proveedores.SelectedIndex = -1;
            _dbCon.CloseConnection();
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
                btn_agregarNuevoPedido.Text = "Agregar Pedido a " + (lb_proveedores.SelectedItem as DataRowView)["nombre"];
                string proId = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                lb_pedidos.SelectedIndexChanged -= lb_pedidos_SelectedIndexChanged;
                lb_pedidos.DataSource = _dbCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + proId );                               
                lb_pedidos.DisplayMember = "fecha";
                string filtro = cb_tipoPedido.SelectedIndex == 0 ? "fecha_arrivo IS NULL" : "fecha_arrivo IS NOT NULL";
                ((DataTable) lb_pedidos.DataSource).DefaultView.RowFilter = filtro;
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
            Close();
        }

        private void lb_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_pedidos.SelectedIndex != -1)
            {
                gb_datosPedido.Enabled = true;
                string dateString = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString();
                string pedidoId = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
                string proveedor = (lb_proveedores.SelectedItem as DataRowView)["nombre"].ToString();
                string fechaArrivo = (lb_pedidos.SelectedItem as DataRowView)["fecha_arrivo"].ToString();
                if (fechaArrivo != "")
                {
                    btn_registrarIngreso.Enabled = false;
                    lbl_fechaArrivoValue.Text = fechaArrivo.Remove(10);
                }
                else
                {
                    btn_registrarIngreso.Enabled = true;
                    lbl_fechaArrivoValue.Text = "N/A";
                }
                dtp_fechaPedido.Value = DateTime.Parse(dateString);
                gb_datosPedido.Text = "Datos del Pedido " + dtp_fechaPedido.Value.ToString("dd/MM/yyyy") + " a " + proveedor;
                dgv_pedido.DataSource = _dbCon.Read("SELECT * FROM vista_pedidoProducto WHERE PedidoID = " + pedidoId);
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
                CalculateTotal();
            }
            
        }

        private void CalculateTotal()
        {
            double costoTotal = dgv_pedido.Rows.Cast<DataGridViewRow>().Sum(sRow => double.Parse(sRow.Cells["Costo"].Value.ToString().Replace("$", ""))*double.Parse(sRow.Cells["Cantidad"].Value.ToString()));
            lbl_costoTotalValue.Text = "$" + costoTotal.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void btn_eliminarPedido_Click(object sender, EventArgs e)
        {
            string pedId = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            if (MessageBox.Show("¿Está seguro que desea elminar este pedido?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _dbCon.Write("DELETE FROM pedido WHERE id = " + pedId);
                _dbCon.Write("DELETE FROM pedido_producto WHERE pedido_id = "+pedId);
                _dbCon.CloseConnection();
                lb_proveedores_SelectedIndexChanged(this,EventArgs.Empty);
            }
        }

        private void btn_agregarProductos_Click(object sender, EventArgs e)
        {
            BusquedaProducto bp = new BusquedaProducto(int.Parse((lb_proveedores.SelectedItem as DataRowView)["id"].ToString()));
            bp.Show();
        }

        public void AddItemToCartFromSearchWindow(int productoId, double cantidad)
        {
            string pedidoId = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            const string query = "INSERT INTO pedido_producto (pedido_id, producto_id, cantidad) VALUES ({0},{1},{2})";
            _dbCon.Write(String.Format(query,pedidoId,productoId,cantidad.ToString("0.00",CultureInfo.InvariantCulture)));
            dgv_pedido.DataSource = _dbCon.Read("SELECT * FROM vista_pedidoProducto WHERE PedidoID = " + pedidoId);
        }

        private void dgv_pedido_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string pedProId = dgv_pedido["id",e.RowIndex].Value.ToString();
            string pedProCantidad = dgv_pedido["Cantidad", e.RowIndex].Value.ToString().Replace(",",".");
            _dbCon.Write("UPDATE pedido_producto SET cantidad = " + pedProCantidad + " WHERE id = " + pedProId);
            CalculateTotal();
        }

        private void dgv_pedido_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string pedProId = e.Row.Cells["id"].Value.ToString();
            _dbCon.Write("DELETE FROM pedido_producto WHERE id = " + pedProId);
        }

        private void btn_cambiarFecha_Click(object sender, EventArgs e)
        {
            string nuevaFecha = dtp_fechaPedido.Value.ToString("yyyy-MM-dd");
            string pedId = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
            _dbCon.Write("UPDATE pedido SET fecha = '" + nuevaFecha + "' WHERE id = " + pedId);
            string proId = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
            lb_pedidos.DataSource = _dbCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + proId);
            btn_cambiarFecha.Enabled = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString().Remove(10) != dtp_fechaPedido.Value.ToString("dd/MM/yyyy");
        }

        private void btn_agregarNuevoPedido_Click(object sender, EventArgs e)
        {
            AgregarPedido ap = new AgregarPedido();
            if (ap.ShowDialog(this) == DialogResult.OK)
            {
                string proId = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                string pedFecha = ap.dtp_fecha.Value.ToString("yyyy-MM-dd");
                _dbCon.Write(String.Format("INSERT INTO pedido (fecha, proveedor_id) VALUES ('{0}',{1})",pedFecha,proId));
                lb_pedidos.DataSource = _dbCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + proId);
                cb_tipoPedido.SelectedIndex = 0;
            }
        }

        private void btn_registrarIngreso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Éstá seguro de querer registrar el ingreso de este pedido con los datos especificados?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string pedFechaArrivo = DateTime.Now.ToString("yyyy-MM-dd");
                string pedId = (lb_pedidos.SelectedItem as DataRowView)["id"].ToString();
                string proId = (lb_proveedores.SelectedItem as DataRowView)["id"].ToString();
                _dbCon.Write("UPDATE pedido SET fecha_arrivo = '" + pedFechaArrivo + "' WHERE id = " + pedId);
                _dbCon.Write("CALL sp_updateStock(" + pedId + ")");
                lb_pedidos.DataSource = _dbCon.Read("SELECT id, fecha,fecha_arrivo FROM pedido WHERE proveedor_id = " + proId);
                cb_tipoPedido.SelectedIndex = 1;
            }
        }

        private void dtp_fechaPedido_ValueChanged(object sender, EventArgs e)
        {
            btn_cambiarFecha.Enabled = (lb_pedidos.SelectedItem as DataRowView)["fecha"].ToString().Remove(10) != dtp_fechaPedido.Value.ToString("dd/MM/yyyy");
        }

        private void dgv_pedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += Control_KeyPress;
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

    }
}
