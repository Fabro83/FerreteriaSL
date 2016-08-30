using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;
using FerreteriaSL.Clases_Genericas;

namespace FerreteriaSL.Ventas
{
    public partial class Ventas : Form
    {
        int _currentProduct;
        double _quantity = 1;
        private Modelos.Presupuesto _presupuesto;

        public Ventas()
        {
            InitializeComponent();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboGrid1_SelectionMade(object sender, int idProducto)
        {
            _currentProduct = idProducto;
            nud_cantidad.Enabled = true;
            nud_cantidad.Focus();
        }

        private void comboGrid1_EstimateScanned(object sender, string barcode)
        {
            _presupuesto = new Modelos.Presupuesto(barcode);
            LoadEstimate();          
        }

        void CMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Actualizar Todo" || e.ClickedItem.Text == "Actualizar Descripcion")
            {
                foreach (var itemId in from DataGridViewRow selectedRow in dgv_productosIngresados.SelectedRows select int.Parse(selectedRow.Cells["id"].Value.ToString()))
                {
                    _presupuesto.Productos.Single(s => s.Id == itemId).UpdateDescription();
                }
            }
            if (e.ClickedItem.Text == "Actualizar Todo" || e.ClickedItem.Text == "Actualizar Precio")
            {
                foreach (var itemId in from DataGridViewRow selectedRow in dgv_productosIngresados.SelectedRows select int.Parse(selectedRow.Cells["id"].Value.ToString()))
                {
                    _presupuesto.Productos.Single(s => s.Id == itemId).UpdatePrice();
                }
            }
            LoadEstimate();
        }

        private void LoadEstimate()
        {
            dgv_productosIngresados.Rows.Clear();
            foreach (var producto in _presupuesto.Productos)
            {
                dgv_productosIngresados.Rows.Add(
                    producto.Codigo,
                    producto.Descripcion,
                    producto.Cantidad,
                    producto.PrecioUnitario,
                    Convert.ToDouble(Math.Round(producto.PrecioUnitario * producto.Cantidad,2)),
                    producto.Id,
                    "",
                    "",
                    producto.HasNewPrice().ToString(),
                    producto.HasNewDescription().ToString()
                );
            }

            if (_presupuesto.HasNewDescriptions() || _presupuesto.HasNewPrices())
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("Actualizar Todo");
                cms.Items.Add("Actualizar Descripcion");
                cms.Items.Add("Actualizar Precio");

                cms.ItemClicked += CMS_ItemClicked;

                dgv_productosIngresados.ContextMenuStrip = cms;
            }
            else
            {
                dgv_productosIngresados.ContextMenuStrip = null;
            }

        }

        private void dgv_productosIngresados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_productosIngresados["HasNewDescription", e.RowIndex].Value == null &&
                dgv_productosIngresados["HasNewPrice", e.RowIndex].Value == null) return;

            if (dgv_productosIngresados.Columns[e.ColumnIndex].HeaderText == "DESCRIPCION" &&
                Boolean.Parse(dgv_productosIngresados["HasNewDescription", e.RowIndex].Value.ToString()))
            {
                e.CellStyle.ForeColor = Color.DarkOrange;
                var cell = dgv_productosIngresados[e.ColumnIndex, e.RowIndex];
                var formattingId = int.Parse(dgv_productosIngresados["id", e.RowIndex].Value.ToString());
                cell.ToolTipText = "Nueva Descripcion: " + _presupuesto.Productos.Single(s => s.Id == formattingId).DescripcionNueva;
            }

            if (dgv_productosIngresados.Columns[e.ColumnIndex].HeaderText == "PRECIO UNITARIO" &&
                Boolean.Parse(dgv_productosIngresados["HasNewPrice", e.RowIndex].Value.ToString()))
            {
                e.CellStyle.ForeColor = Color.Red;
                var cell = dgv_productosIngresados[e.ColumnIndex, e.RowIndex];
                var formattingId = int.Parse(dgv_productosIngresados["id", e.RowIndex].Value.ToString());
                cell.ToolTipText = "Nuevo Precio: " + _presupuesto.Productos.Single(s => s.Id == formattingId).PrecioNuevo;                
            }
               
        }

        private void AddItemToCart()
        {
            if (_quantity <= 0) return;
            Bd bdCon = new Bd();
            DataRow result = bdCon.Read("SELECT Proveedor,Codigo, Descripcion, Precio,ProveedorID FROM vista_tablaproductosventas WHERE id = " + _currentProduct).Rows[0];

            string addedItemCode = result["Codigo"].ToString();
            string addedItemDescription = result["Descripcion"].ToString();
            double addedItemPrice = double.Parse(result["precio"].ToString());
            string addedItemProvider = result["Proveedor"].ToString();
            int proveedorId = int.Parse(result["ProveedorID"].ToString());

            int alreadyExist = -1;

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {
                alreadyExist = singleRow.Cells["descripcion"].Value.ToString() == addedItemDescription ? singleRow.Index : -1;              
            }

            if (alreadyExist != -1)
            {
                double addedItemQuantity = int.Parse(dgv_productosIngresados.Rows[alreadyExist].Cells["cantidad"].Value.ToString()) + _quantity;
                dgv_productosIngresados.Rows[alreadyExist].Cells["cantidad"].Value = int.Parse(dgv_productosIngresados.Rows[alreadyExist].Cells["cantidad"].Value.ToString()) + _quantity;
                dgv_productosIngresados.Rows[alreadyExist].Cells["precio_subtotal"].Value = addedItemPrice * addedItemQuantity;
                CalculateTotal();
            }
            else
            {
                dgv_productosIngresados.Rows.Add(addedItemCode, addedItemDescription, _quantity, addedItemPrice, Convert.ToDouble(Math.Round(addedItemPrice * _quantity, 2)),_currentProduct,addedItemProvider,proveedorId);
            }           
            cg_busqueda.ClearTextBox();
        }

        private void nud_cantidad_Enter(object sender, EventArgs e)
        {
            nud_cantidad.Select(0, 1);
        }

        private void nud_cantidad_Leave(object sender, EventArgs e)
        {
            nud_cantidad.Enabled = false;
            nud_cantidad.Value = 1;
            cg_busqueda.ClearTextBox();
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
                _quantity = Convert.ToDouble(nud_cantidad.Value);      
                AddItemToCart();
                cg_busqueda.Focus();
            }
            if (e.KeyChar == acceptedChars[3])
            {
                e.KeyChar = ',';
            }
        }

        private void dgv_productosIngresados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_imprimirTicket.Enabled = btn_disminuir.Enabled = btn_incrementar.Enabled = btn_remover.Enabled = btn_removerTodos.Enabled = btn_exportar.Enabled = dgv_productosIngresados.Rows.Count > 0;
            CalculateTotal();           
        }

        private void CalculateTotal()
        {
            double discount = Convert.ToDouble(nud_discountPercent.Value);

            double total = dgv_productosIngresados.Rows.Cast<DataGridViewRow>().Sum(singleRow => Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value));

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
                CalculateIva(total);
            }


        }

        private void CalculateIva(double total)
        {
            lbl_ivaValue.Text = ((21 * total) / 121).ToString("0.00");
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
            DataTable productosIngresados = new DataTable();

            foreach (DataGridViewColumn dataGridViewColumn in dgv_productosIngresados.Columns.Cast<DataGridViewColumn>().Where(dataGridViewColumn => dataGridViewColumn.Visible))
            {
                productosIngresados.Columns.Add(dataGridViewColumn.Name);
            }

            foreach (DataGridViewRow dataGridViewRow in dgv_productosIngresados.Rows)
            {
                DataRow dataRow = productosIngresados.NewRow();
                for (int i = 0; i < productosIngresados.Columns.Count; i++)
                {
                    if (dataGridViewRow.Cells[i].Visible)
                        dataRow[i] = dataGridViewRow.Cells[i].Value;
                    else
                        i--;
                }
                productosIngresados.Rows.Add(dataRow);
            }

            ConfirmacionVenta cf = new ConfirmacionVenta(double.Parse(lbl_totalMonto.Text), productosIngresados);

            DialogResult cfdr = cf.ShowDialog(this);

            switch (cfdr)
            {
                case DialogResult.OK:
                    DoSell();
                    break;
                case DialogResult.No:
                    FormaDePago fdP = new FormaDePago();
                    fdP.ShowDialog();
                    break;
            }
        }

        private void DoSell()
        {
            Bd dbCon = new Bd();
            int ultimoTalonario = -1;
            DataTable res = dbCon.Read("SELECT numero_factura_talonario FROM ventas_caja ORDER BY numero_factura_talonario DESC LIMIT 1");
            if (res.Rows.Count > 0)
            {
                ultimoTalonario = int.Parse(res.Rows[0][0].ToString());
            }

            double totalAmount = dgv_productosIngresados.Rows.Cast<DataGridViewRow>().Sum(singleRow => Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value));

            int clienteId = 0; // TODO: IMPLEMENTAR CLIENTE    
            ultimoTalonario += 1;
            double discountPercentage = Convert.ToDouble(nud_discountPercent.Value);
            double discountAmount = (totalAmount * discountPercentage) / 100;
            totalAmount -= discountAmount;
            int usuarioId = Usuario.Id;

            string query = String.Format("INSERT INTO ventas_caja (numero_factura_talonario,cliente_id,usuario_id,importe_total,descuento_monto,descuento_porcentaje) " +
                                         "VALUES ({0},{1},{2},{3},{4},{5})", ultimoTalonario, clienteId, usuarioId, totalAmount.ToString("0.00", CultureInfo.InvariantCulture), 
                                         discountAmount.ToString("0.00", CultureInfo.InvariantCulture), discountPercentage.ToString("0.00", CultureInfo.InvariantCulture));
            dbCon.Write(query);
            int ventasCajaId = int.Parse(dbCon.Read("SELECT id FROM ventas_caja WHERE numero_factura_talonario = " + ultimoTalonario).Rows[0][0].ToString());

            foreach (DataGridViewRow singleRow in dgv_productosIngresados.Rows)
            {               
                string productQuantity = singleRow.Cells["cantidad"].Value.ToString().Replace(",",".");
                string productProvider = singleRow.Cells["proveedor"].Value.ToString();
                string productoId = singleRow.Cells["id"].Value.ToString();

                query = String.Format("INSERT INTO venta_producto (ventas_caja_id,cantidad,proveedor,producto_id) VALUES ({0},{1},'{2}',{3})",ventasCajaId,productQuantity,productProvider,productoId);
                dbCon.Write(query);
            }

            dbCon.Write("Call sp_substractStock(" + ventasCajaId + ")");
            dbCon.Write("Call sp_calculateGain(" + ventasCajaId + ")");

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
            CalculateTotal();
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
            CalculateTotal();
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
            CalculateTotal();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchPhrase = cg_busqueda.SearchPhrase;
            cg_busqueda.ClearTextBox();
            BusquedaProducto bp = null;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is BusquedaProducto)
                {
                    bp = frm as BusquedaProducto;
                }
            }
            bp = bp ?? new BusquedaProducto(-1,searchPhrase);
            bp.Show(this);
        }

        public void AddItemToCartFromSearchWindow(int addedItemId,double addedItemQuantity)
        {
            _currentProduct = addedItemId;
            _quantity = addedItemQuantity;
            AddItemToCart();
        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (BusquedaProducto frm in Application.OpenForms.OfType<BusquedaProducto>())
            {
                frm.Show();
                frm.Focus();
                e.Cancel = true;
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
            double total = dgv_productosIngresados.Rows.Cast<DataGridViewRow>().Sum(singleRow => Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value));
            if (total == 0)
            {
                return;
            }
            //double eq_discountPercent = Math.Round((discountValue * 100) / total,2,MidpointRounding.AwayFromZero);
            double eqDiscountPercent = (discountValue * 100) / total;
            nud_discountPercent.ValueChanged -= nud_discount_ValueChanged;
            nud_discountPercent.Value = Convert.ToDecimal(eqDiscountPercent.ToString());
            nud_discountPercent.ValueChanged += nud_discount_ValueChanged;
            CalculateTotal();
        }

        private void nud_discount_ValueChanged(object sender, EventArgs e)
        {
            double discountPercentage = Convert.ToDouble(nud_discountPercent.Value);
            double total = dgv_productosIngresados.Rows.Cast<DataGridViewRow>().Sum(singleRow => Convert.ToDouble(singleRow.Cells["precio_subtotal"].Value));

            double eqDiscountImport = Math.Round((discountPercentage * total) / 100, 2, MidpointRounding.AwayFromZero);
            nud_discountImport.ValueChanged -= nud_discountImport_ValueChanged;
            nud_discountImport.Value = Convert.ToDecimal(eqDiscountImport.ToString());
            nud_discountImport.ValueChanged += nud_discountImport_ValueChanged;
            CalculateTotal();
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
            switch (e.KeyValue)
            {
                case 107:
                    btn_incrementar.PerformClick();
                    break;
                case 109:
                    btn_disminuir.PerformClick();
                    break;
                case 106:
                    foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
                    {
                        double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString()) + 0.1;
                        double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                        singleRow.Cells["cantidad"].Value = newValue;
                        singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
                    }
                    CalculateTotal();
                    break;
                case 111:
                    foreach (DataGridViewRow singleRow in dgv_productosIngresados.SelectedRows)
                    {
                        double newValue = double.Parse(singleRow.Cells["cantidad"].Value.ToString());
                        newValue = newValue > 0.1 ? newValue - 0.1 : newValue;
                        double precioUnitario = double.Parse(singleRow.Cells["precio_unitario"].Value.ToString());
                        singleRow.Cells["cantidad"].Value = newValue;
                        singleRow.Cells["precio_subtotal"].Value = precioUnitario * newValue;
                    }
                    CalculateTotal();
                    break;
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
            if (target != null) tt_help.Show(info.ToString(), target, target.PointToClient(Cursor.Position));
        }

        
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            var presupuestoMenuStrip = new ContextMenuStrip();
            presupuestoMenuStrip.Items.Add("Imprimir...").Click += Presupuesto_Imprimir_OnClick;
            presupuestoMenuStrip.Items.Add("Exportar a Excel").Click += Presupuesto_ExportarAExcel_OnClick;

            presupuestoMenuStrip.Show(MousePosition);
        }

        private void Presupuesto_Imprimir_OnClick(object sender, EventArgs e)
        {
            var presupuestoImprimirWindow = new Presupuesto();
            if (presupuestoImprimirWindow.ShowDialog() != DialogResult.OK) return;

            Modelos.Presupuesto nuevoPresupuesto = new Modelos.Presupuesto
            (
                presupuestoImprimirWindow.txb_nombre.Text,
                presupuestoImprimirWindow.txb_domicilio.Text,
                presupuestoImprimirWindow.dtp_fecha.Value,
                DgvHelper.ToDataTable(dgv_productosIngresados)

            );

            if (presupuestoImprimirWindow.chb_guardar.Checked)
                nuevoPresupuesto.Save().Print(Int16.Parse(presupuestoImprimirWindow.nud_copias.Value.ToString()));
            else
                nuevoPresupuesto.Print(Int16.Parse(presupuestoImprimirWindow.nud_copias.Value.ToString()));
            
            //dgv_productosIngresados.Rows.Clear();
            
        }

        private void Presupuesto_ExportarAExcel_OnClick(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel();
        }      

        private void ExportarDataGridViewExcel()
        {
            SaveFileDialog fichero = new SaveFileDialog {Filter = @"Excel (*.xlsx)|*.xlsx"};
            if (fichero.ShowDialog() != DialogResult.OK) return;

            ExcelExporter.ExcelExporter winExcelExporter = new ExcelExporter.ExcelExporter(fichero.FileName, dgv_productosIngresados, "Presupuesto",true);
            winExcelExporter.ShowDialog(this);
        }

        private void dgv_productosIngresados_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || dgv_productosIngresados.SelectedRows.Contains(dgv_productosIngresados.Rows[e.RowIndex])) return;
            dgv_productosIngresados.CurrentCell = dgv_productosIngresados.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dgv_productosIngresados.Rows[e.RowIndex].Selected = true;
        }



        
    }
}
