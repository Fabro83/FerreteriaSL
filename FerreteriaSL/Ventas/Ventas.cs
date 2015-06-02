using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;


namespace FerreteriaSL
{
    public partial class Ventas : Form
    {
        int currentProduct = 0;
        double quantity = 1;

        public Ventas()
        {
            InitializeComponent();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboGrid1_SelectionMade(object sender, int id_producto)
        {
            currentProduct = id_producto;
            nud_cantidad.Enabled = true;
            nud_cantidad.Focus();
        }

        private void addItemToCart()
        {
            BD BDCon = new BD();
            DataRow result = BDCon.Read("SELECT Proveedor,Codigo, Descripcion, Precio,ProveedorID FROM vista_tablaproductosventas WHERE id = " + currentProduct).Rows[0];

            string codigo = result["Codigo"].ToString();
            string descripcion = result["Descripcion"].ToString();
            double precio = double.Parse(result["precio"].ToString());
            string proveedor = result["Proveedor"].ToString();
            int proveedor_id = int.Parse(result["ProveedorID"].ToString());

            int alreadyExist = -1;

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                alreadyExist = singleRow.Cells["descripcion"].Value.ToString() == descripcion ? singleRow.Index : -1;              
            }

            if (alreadyExist != -1)
            {
                dgv_productosIngresados.Rows[alreadyExist].Cells["cantidad"].Value = int.Parse(dgv_productosIngresados.Rows[alreadyExist].Cells["cantidad"].Value.ToString()) + quantity;
                calculateTotal();
            }
            else
            {
                dgv_productosIngresados.Rows.Add(codigo, descripcion, quantity, precio, Convert.ToDouble(Math.Round(precio * quantity, 2)),currentProduct,proveedor,proveedor_id);
            }           
            cg_busqueda.clearTextBox();
        }

        private void nud_cantidad_Enter(object sender, EventArgs e)
        {
            nud_cantidad.Select(0, 1);
        }

        private void nud_cantidad_Leave(object sender, EventArgs e)
        {
            nud_cantidad.Enabled = false;
            nud_cantidad.Value = 1;
            cg_busqueda.clearTextBox();
        }

        private void nud_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] acceptedChars = {'\r',',','\b','.'};

            if (!Char.IsNumber(e.KeyChar) && !acceptedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == acceptedChars[0])
            {
                quantity = Convert.ToDouble(nud_cantidad.Value);      
                addItemToCart();
                cg_busqueda.Focus();
            }
            if (e.KeyChar == acceptedChars[3])
            {
                e.KeyChar = ',';
            }
        }

        private void dgv_productosIngresados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_imprimirTicket.Enabled = btn_disminuir.Enabled = btn_incrementar.Enabled = btn_remover.Enabled = btn_removerTodos.Enabled = dgv_productosIngresados.Rows.Count > 0;
            calculateTotal();           
        }

        private void calculateTotal()
        {
            double total = 0;
            double discount = Convert.ToDouble(nud_discountPercent.Value);

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                total += Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value);
            }

            if (dgv_productosIngresados.Rows.Count == 0)
            {
                lbl_totalMonto.Text = "0,00";
                lbl_ivaValue.Text = "0,00";
                nud_discountPercent.Value = 0;
            }
            else
            {
                total = total - ((total * discount) / 100);
                lbl_totalMonto.Text = String.Format("{0:N2}", total);
                calculateIVA(total);
            }


        }

        private void calculateIVA(double total)
        {
            lbl_ivaValue.Text = ((21 * total) / 100).ToString("0.00");
        }

        private void Ventas_Shown(object sender, EventArgs e)
        {
            cg_busqueda.Focus();
        }

        private void cg_busqueda_Leave(object sender, EventArgs e)
        {
            cg_busqueda.CloseDisplay();
        }

        private void btn_imprimirTicket_Click(object sender, EventArgs e)
        {
            ConfirmacionVenta CF = new ConfirmacionVenta(double.Parse(lbl_totalMonto.Text));

            DialogResult CFDR = CF.ShowDialog(this);

            if (CFDR == DialogResult.OK)
            {
                doSell();
            }
            else if (CFDR == DialogResult.No)
            {
                FormaDePago FdP = new FormaDePago();
                FdP.ShowDialog();
            }
        }

        private void doSell()
        {
            BD DBCon = new BD();
            int ultimoTalonario = -1;
            DataTable res = DBCon.Read("SELECT numero_factura_talonario FROM ventas_caja ORDER BY numero_factura_talonario DESC LIMIT 1");
            if (res.Rows.Count > 0)
            {
                ultimoTalonario = int.Parse(res.Rows[0][0].ToString());
            }

            double total_amount = 0;

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                total_amount += Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value);
            }

            int cliente_id = 0; // IMPLEMENTAR CLIENTE    
            ultimoTalonario += 1;
            double discount_percentage = Convert.ToDouble(nud_discountPercent.Value);
            double discount_amount = (total_amount * discount_percentage) / 100;
            total_amount -= discount_amount;
            int usuario_id = Usuario.ID;

            string query = String.Format("INSERT INTO ventas_caja (numero_factura_talonario,cliente_id,usuario_id,importe_total,descuento_monto,descuento_porcentaje) " +
                                         "VALUES ({0},{1},{2},{3},{4},{5})", ultimoTalonario, cliente_id, usuario_id, total_amount.ToString("0.00", CultureInfo.InvariantCulture), 
                                         discount_amount.ToString("0.00", CultureInfo.InvariantCulture), discount_percentage.ToString("0.00", CultureInfo.InvariantCulture));
            DBCon.Write(query);
            int ventas_caja_id = int.Parse(DBCon.Read("SELECT id FROM ventas_caja WHERE numero_factura_talonario = " + ultimoTalonario).Rows[0][0].ToString());

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {               
                string cantidad = singleRow.Cells["cantidad"].Value.ToString().Replace(",",".");
                string provider = singleRow.Cells["proveedor"].Value.ToString();
                string producto_id = singleRow.Cells["id"].Value.ToString();

                query = String.Format("INSERT INTO venta_producto (ventas_caja_id,cantidad,proveedor,producto_id) VALUES ({0},{1},'{2}',{3})",ventas_caja_id,cantidad,provider,producto_id);
                DBCon.Write(query);
            }

            DBCon.Write("Call sp_substractStock(" + ventas_caja_id + ")");
            DBCon.Write("Call sp_calculateGain(" + ventas_caja_id + ")");

            dgv_productosIngresados.Rows.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
            {
                dgv_productosIngresados.Rows.RemoveAt(singleRow.Index);
            }        
        }

        private void btn_removerTodos_Click(object sender, EventArgs e)
        {
            dgv_productosIngresados.Rows.Clear();
        }

        private void dgv_productosIngresados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            btn_imprimirTicket.Enabled = btn_disminuir.Enabled = btn_incrementar.Enabled = btn_remover.Enabled = btn_removerTodos.Enabled = dgv_productosIngresados.Rows.Count > 0;
            calculateTotal();
        }

        private void tm_fechaHora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_incrementar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
            {
                double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString()) + 1;
                double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                singleRow.Cells["cantidad"].Value = newValue;
                singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
            }
            calculateTotal();
        }

        private void btn_disminuir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
            {
                double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString());
                newValue = newValue > 1 ? newValue - 1 : newValue;
                double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                singleRow.Cells["cantidad"].Value = newValue;
                singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
            }
            calculateTotal();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchPhrase = cg_busqueda.SearchPhrase;
            cg_busqueda.clearTextBox();
            BusquedaProducto BP = null;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is BusquedaProducto)
                {
                    BP = frm as BusquedaProducto;
                }
            }
            BP = BP == null ? new BusquedaProducto(-1,searchPhrase) : BP;
            BP.Show(this);
        }

        public void addItemToCartFromSearchWindow(int producto_id,double cantidad)
        {
            currentProduct = producto_id;
            quantity = cantidad;
            addItemToCart();
        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is BusquedaProducto)
                {
                    frm.Show();
                    frm.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void nud_discountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void nud_discountImport_ValueChanged(object sender, EventArgs e)
        {
            double discountValue = Convert.ToDouble(nud_discountImport.Value);
            double total = 0;
            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                total += Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value);
            }
            if (total == 0)
            {
                return;
            }
            //double eq_discountPercent = Math.Round((discountValue * 100) / total,2,MidpointRounding.AwayFromZero);
            double eq_discountPercent = (discountValue * 100) / total;
            nud_discountPercent.ValueChanged -= nud_discount_ValueChanged;
            nud_discountPercent.Value = Convert.ToDecimal(eq_discountPercent.ToString());
            nud_discountPercent.ValueChanged += nud_discount_ValueChanged;
            calculateTotal();
        }

        private void nud_discount_ValueChanged(object sender, EventArgs e)
        {
            double discountPercentage = Convert.ToDouble(nud_discountPercent.Value);
            double total = 0;

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                total += Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value);
            }

            double eq_discountImport = Math.Round((discountPercentage * total) / 100, 2, MidpointRounding.AwayFromZero);
            nud_discountImport.ValueChanged -= nud_discountImport_ValueChanged;
            nud_discountImport.Value = Convert.ToDecimal(eq_discountImport.ToString());
            nud_discountImport.ValueChanged += nud_discountImport_ValueChanged;
            calculateTotal();
        }

        private void nud_discountImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void dgv_productosIngresados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 107) // + (Signo Mas) en teclado numérico.
            {
                btn_incrementar.PerformClick();
            }
            else if (e.KeyValue == 109) // - (Signo Menos) en teclado numérico.
            {
                btn_disminuir.PerformClick();
            }
            else if (e.KeyValue == 106) // * (Asterisco) en teclado numérico.
            {
                foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
                {
                    double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString()) + 0.1;
                    double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                    singleRow.Cells["cantidad"].Value = newValue;
                    singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
                }
                calculateTotal();
            }
            else if (e.KeyValue == 111) // / (Barra invertida | división) en teclado numérico.
            {
                foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
                {
                    double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString());
                    newValue = newValue > 0.1 ? newValue - 0.1 : newValue;
                    double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                    singleRow.Cells["cantidad"].Value = newValue;
                    singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
                }
                calculateTotal();
            }
                
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
                btn_search.PerformClick();
            if (e.KeyData == Keys.F5)
                btn_imprimirTicket.PerformClick();
        }

        private void btn_help_MouseLeave(object sender, EventArgs e)
        {
            tt_help.Hide(this);
        }

        private void btn_help_MouseEnter(object sender, EventArgs e)
        {
            Button target = sender as Button;
            StringBuilder info = new StringBuilder();
            info.AppendLine("Teclas de acceso rápido dentro de la lista de articulos:");
            info.AppendLine("");
            info.AppendLine("[+] (teclado numérico): Incrementa en una unidad (1) la cantidad de el/los producto/s seleccionado/s.");
            info.AppendLine("[-] (teclado numérico): Reduce en una unidad (1) la cantidad de el/los producto/s seleccionado/s.");
            info.AppendLine("[*] (teclado numérico): Incrementa en 0,1 la cantidad de el/los producto/s seleccionado/s.");
            info.AppendLine("[/] (teclado numérico): Reduce en 0,1 la cantidad de el/los producto/s seleccionado/s.");
            info.AppendLine("[Supr]: Remueve el/los producto/s seleccionado/s.");
            tt_help.Show(info.ToString(), target, target.PointToClient(Cursor.Position));
        }

    }
}
