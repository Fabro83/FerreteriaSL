using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Diagnostics;
using System.Threading;


namespace FerreteriaSL
{
    public partial class Administrar_Stock : Form
    {

        private int winLastWidth = 1200;
        private int winLastHeight = 450;
        FormWindowState winLastState = FormWindowState.Normal;

              
        public Administrar_Stock()
        {       
            InitializeComponent();
            dtp_filtrosFechaCreacionAntes.Checked = false;
            dtp_filtrosFechaCreacionDespues.Checked = false;
            dtp_filtrosFechaModificacionAntes.Checked = false;
            dtp_filtrosFechaModificacionDespues.Checked = false;
            //loadLastConfig();
        }

        private void loadProviderComboBox(string firstItem, string condition, ComboBox cb_target)
        {
            BD DBCon = new BD();
            DataTable ProviderTable = DBCon.Read("SELECT id,nombre FROM proveedor WHERE " + condition);
            DataRow defaultRow = ProviderTable.NewRow();
            defaultRow[0] = "-1";
            defaultRow[1] = " " + firstItem;
            ProviderTable.Rows.Add(defaultRow);
            ProviderTable.DefaultView.Sort = "nombre asc";
            cb_target.DataSource = ProviderTable;
            cb_target.DisplayMember = "nombre";
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            if ((bgw_actualizarProducto != null && bgw_actualizarProducto.IsBusy) || (bgw_transferToDB != null && bgw_transferToDB.IsBusy))
                MessageBox.Show("Hay una operación ejecutandose, aguarde a que finalice.", "Operacion en progreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                this.Close();       
        }

        private void Administrar_Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((bgw_actualizarProducto != null && bgw_actualizarProducto.IsBusy) || (bgw_transferToDB != null && bgw_transferToDB.IsBusy))
            {
                MessageBox.Show("Hay una operación ejecutandose, aguarde a que finalice.", "Operacion en progreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        #region Tab Agregar Producto

        private void btn_ap_agregar_Click(object sender, EventArgs e)
        {
            BD DBCon = new BD();
            string query = "INSERT INTO producto (codigo, id_proveedor, nombre, stock, precio, codigo_barra, porcentaje) VALUES ('{0}',{1},'{2}',{3},{4},'{5}',{6})";
            
            string codigo = tb_ap_codigo.Text.Trim().Replace("'", "\\'");
            int id_proveedor = int.Parse((cb_ap_proveedor.SelectedItem as DataRowView)["id"].ToString());
            string nombre = tb_ap_nombre.Text.Trim().Replace("'", "\\'");
            int stock = int.Parse(nud_ap_stock.Value.ToString());
            string precio = nud_ap_precio.Value.ToString("0.00", CultureInfo.InvariantCulture);
            string codigo_barra = tb_ap_codigoDeBarras.Text.Trim().Replace("'", "\\'");
            string porcentaje = nud_ap_porcentajeDeUtilidad.Value.ToString("0.00",CultureInfo.InvariantCulture);

            query = String.Format(query,codigo,id_proveedor,nombre,stock,precio,codigo_barra,porcentaje);
            int result = DBCon.Write(query);
            if (result > 0)
            {
                lbl_ap_info.ForeColor = Color.DarkGreen;
                lbl_ap_info.Text = String.Format("El articulo {0} ({1}) fué agregado correctamente.",nombre,codigo);
            }
            else
            {
                lbl_ap_info.ForeColor = Color.DarkRed;
                lbl_ap_info.Text = "Ha ocurrido un error al intentar agregar el articulo.";
            }
            btn_ap_limpiar_Click(this, EventArgs.Empty);
        }

        void validateProductCode()
        {
            if (tb_ap_codigo.Text.Length > 0 && cb_ap_proveedor.SelectedIndex > 0)
            {
                BD DBCon = new BD();
                string codigo = tb_ap_codigo.Text.Trim().Replace("'", "\\'");
                int id_proveedor = int.Parse((cb_ap_proveedor.SelectedItem as DataRowView)["id"].ToString());
                int check = int.Parse(DBCon.Read(String.Format("SELECT Count(*) FROM producto WHERE codigo = '{0}' AND id_proveedor = {1}",codigo,id_proveedor)).Rows[0][0].ToString());
                if (check > 0)
                {
                    lbl_ap_info.ForeColor = Color.DarkRed;
                    string proveedor = (cb_ap_proveedor.SelectedItem as DataRowView)["nombre"].ToString();
                    lbl_ap_info.Text = "\""+ proveedor +"\" ya poseé un articulo con codigo \"" + codigo + "\"";
                }
                else
                {
                    lbl_ap_info.Text = String.Empty;
                }
            }
        }

        private void btn_ap_limpiar_Click(object sender, EventArgs e)
        {
            tb_ap_codigo.Clear();
            tb_ap_codigoDeBarras.Clear();
            tb_ap_nombre.Clear();
            nud_ap_precio.Value = 0.00M;
            nud_ap_stock.Value = 0;
        }

        private void tp_agregarProductos_Enter(object sender, EventArgs e)
        {
            winLastState = this.WindowState != FormWindowState.Normal ? this.WindowState : winLastState;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            winLastWidth = this.Width != 1200 ? this.Width : winLastWidth;
            winLastHeight = this.Height != 450 ? this.Height : winLastHeight;
            this.Size = new Size(575, 425);
            this.MaximizeBox = false;
            loadProviderComboBox("Seleccione un Proveedor", "nombre IS NOT NULL", cb_ap_proveedor);

            foreach (Control sControl in tp_agregarProductos.Controls)
            {
                if (sControl is TextBox)
                {
                    (sControl as TextBox).KeyPress += agregarProducto_KeyPress;
                }
                else if (sControl is NumericUpDown)
                {
                    (sControl as NumericUpDown).KeyPress += agregarProducto_KeyPress;
                }
                else if (sControl is ComboBox)
                {
                    (sControl as ComboBox).KeyPress += agregarProducto_KeyPress;
                }
            }
        }

        private void tb_ap_nombre_TextChanged(object sender, EventArgs e)
        {
            btn_ap_agregar.Enabled = tb_ap_nombre.Text.Trim().Length > 3 && cb_ap_proveedor.SelectedIndex > 0 && !lbl_ap_info.Text.Contains("poseé");
        }

        private void cb_ap_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ap_agregar.Enabled = tb_ap_nombre.Text.Trim().Length > 3 && cb_ap_proveedor.SelectedIndex > 0 && !lbl_ap_info.Text.Contains("poseé");
        }

        private void agregarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_ap_agregar.PerformClick();
        }

        private void nud_ap_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_ap_agregar.PerformClick();
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void tb_ap_codigo_Leave(object sender, EventArgs e)
        {
            validateProductCode();
            if (tb_ap_codigo.Text.Length > 0 && tb_ap_codigoDeBarras.Text.Length == 0)
                tb_ap_codigoDeBarras.Text = tb_ap_codigo.Text;
        }

        private void cb_ap_proveedor_Leave(object sender, EventArgs e)
        {
            validateProductCode();
        }

        #endregion

        #region Tab Ver/Modificar Productos

        string currentQuery = "SELECT * FROM vista_administrarStock";
        int curPage = -1;
        BackgroundWorker bgw_actualizarProducto;
        BusquedaGenerica BG;
        BackgroundWorker bgw_waitFilter;

        private void tb_listarProductos_Enter(object sender, EventArgs e)
        {
            BG = new BusquedaGenerica();
            BG.SearchEnded += new SearchEndedHandler(BG_SearchEnded);
            BG.SearchInProgress += new SearchInProgressHandler(BG_SearchInProgress);

            bgw_waitFilter = new BackgroundWorker();
            bgw_waitFilter.DoWork += new DoWorkEventHandler(bgw_waitFilter_DoWork);
            bgw_waitFilter.WorkerSupportsCancellation = true;
            bgw_waitFilter.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_waitFilter_RunWorkerCompleted);

            if (dgv_listaProductos.DataSource == null)
            {
                BD DBCon = new BD();
                runQuery();
            }
            if (cb_filtroProveedor.DataSource == null)
            {
                loadProviderComboBox("Todos los Proveedores", "nombre IS NOT NULL", cb_filtroProveedor);
            }

            cb_itemsPerPage.SelectedIndex = cb_itemsPerPage.SelectedIndex == -1 ? 0 : cb_itemsPerPage.SelectedIndex;
            cb_filtroArticulosAMostrar.SelectedIndex = cb_filtroArticulosAMostrar.SelectedIndex == -1 ? 0 : cb_filtroArticulosAMostrar.SelectedIndex;

            this.WindowState = winLastState;
            this.Size = new Size(winLastWidth, winLastHeight);
            this.MaximizeBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            
        }

        void bgw_waitFilter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                afldbg.log(this, "WaitFilter passed without interruption, running query.","green");
                runQuery(true, false);
            }
            else
            {
                afldbg.log(this, "WaitFilter cancelled, waiting for new query.");
                bgw_waitFilter.RunWorkerAsync();
            }
        }

        void bgw_waitFilter_DoWork(object sender, DoWorkEventArgs e)
        {
            afldbg.log(this, "Wait Filter triggered");
            Thread.Sleep(500);
            e.Cancel = (sender as BackgroundWorker).CancellationPending;
        }

        void BG_SearchInProgress()
        {
            pb_productProgress.Style = ProgressBarStyle.Marquee;
            pb_productProgress.Visible = true;
        }

        void BG_SearchEnded(DataTable Result)
        {
            dgv_listaProductos.DataSource = Result;
            setPages(BG.TotalPages, BG.CurrentPage);
            pb_productProgress.Style = ProgressBarStyle.Continuous;
            pb_productProgress.Visible = false;
            lbl_estado.Text = BG.SearchTotalItemCount + " articulos en lista.";
            try
            {
                dgv_listaProductos.CurrentCell = dgv_listaProductos[BG.LastSelectedColumnIndex, BG.LastSelectedRowIndex];
            }
            catch { }
        }

        private int getItemsPerPage()
        {
            if (cb_itemsPerPage.Text == "Todos")
            {
                return -1;
            }

            if (cb_itemsPerPage.SelectedIndex == -1)
            {
                cb_itemsPerPage.SelectedIndex = 0;
            }

            return int.Parse(cb_itemsPerPage.Text);
        }

        private void setPages(int totalPages, int currentPage)
        {
            curPage = totalPages > 0 ? currentPage : 0;
            lbl_pages.Text = (totalPages > 0 ? (currentPage + 1) : 0) + "/" + totalPages;
        }

        public void ParseDataGrid()
        {
            if (dgv_listaProductos.DataSource == null)
                return;
            dgv_listaProductos.CellValueChanged -= dgv_listaProductos_CellValueChanged;
            dgv_listaProductos.Columns["pro_seccion_id"].Visible = dgv_listaProductos.Columns["id"].Visible = dgv_listaProductos.Columns["oculto"].Visible = dgv_listaProductos.Columns["id_proveedor"].Visible = false;
            dgv_listaProductos.Columns["proveedor"].ReadOnly = true;
            dgv_listaProductos.Columns["fecha_creacion"].ReadOnly = true;
            dgv_listaProductos.Columns["fecha_modificacion"].ReadOnly = true;
            dgv_listaProductos.Columns["precio_final"].ReadOnly = true;
            dgv_listaProductos.Columns["codigo"].ReadOnly = true;

            dgv_listaProductos.Columns["proveedor"].HeaderText = "Proveedor";
            dgv_listaProductos.Columns["codigo"].HeaderText = "Código";
            dgv_listaProductos.Columns["nombre"].HeaderText = "Descripción";
            dgv_listaProductos.Columns["stock"].HeaderText = "Stock";
            dgv_listaProductos.Columns["precio"].HeaderText = "Precio";
            dgv_listaProductos.Columns["porcentaje"].HeaderText = "% de Utilidad";
            dgv_listaProductos.Columns["precio_final"].HeaderText = "Precio Final";
            dgv_listaProductos.Columns["fecha_creacion"].HeaderText = "Creado";
            dgv_listaProductos.Columns["fecha_modificacion"].HeaderText = "Ultima Modificación";
            dgv_listaProductos.Columns["codigo_barra"].HeaderText = "Codigo de Barras";
            dgv_listaProductos.Columns["full_abb"].HeaderText = "Ubicación";

            dgv_listaProductos.Columns["precio_final"].DefaultCellStyle.Format = "$0.00";
            dgv_listaProductos.Columns["precio"].DefaultCellStyle.Format = "$0.00";
            dgv_listaProductos.Columns["porcentaje"].DefaultCellStyle.Format = "0.00\\%";
            dgv_listaProductos.Columns["porcentaje"].ValueType = typeof(double);

            if (dgv_listaProductos.Columns["nombre"].Visible)
            {
                foreach (DataGridViewColumn sCol in dgv_listaProductos.Columns)
                {
                    if (sCol.Name != "nombre")
                        sCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            else
            {
                foreach (DataGridViewColumn sCol in dgv_listaProductos.Columns)
                {
                    if (sCol.Visible)
                    {
                        sCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }

                //dgv_listaProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            }

            
            dgv_listaProductos.AllowUserToResizeColumns = true;
            dgv_listaProductos.CellValueChanged += dgv_listaProductos_CellValueChanged;
        }

        string buildFilters()
        {
            string filters = "";
            //if(tb_filtroNombre.Text.Length > 2)
            //{
                string[] separateWords = tb_filtroNombre.Text.Trim().Split(' '); 
                string filtroNombre = "";
                for (int i = 0; i < separateWords.Length; i++)
                {
                    filtroNombre += "nombre LIKE ";
                    filtroNombre += "'%" + separateWords[i].Replace("'", "\\'") +"%'";
                    filtroNombre += i == separateWords.Length - 1 ? "" : " AND ";
                }

                if (separateWords.Length > 1)
                {
                    filters = "(" + filtroNombre + ")";
                }
                else
                {
                    string filtroCodigo = "codigo LIKE '%" + tb_filtroNombre.Text.Trim().Replace("'", "\\'") + "%'";
                    filters = "((" + filtroNombre + ") OR " + filtroCodigo + ")";
                }           
            //}

            if (cb_filtroProveedor.SelectedItem != null && int.Parse((cb_filtroProveedor.SelectedItem as DataRowView)["id"].ToString()) != -1)
            {
                string filtroProveedor = "id_proveedor = " + (cb_filtroProveedor.SelectedItem as DataRowView)["id"].ToString();
                filters += filters != "" ? " AND " + filtroProveedor : filtroProveedor;
            }

            foreach (Control sGroupBox in tb_listarProductos.Controls)
            {
                if (sGroupBox is GroupBox)
                {
                    GroupBox targetGroupBox = sGroupBox as GroupBox;
                    if (!targetGroupBox.Name.Contains("Filtros"))
                    {
                        string columnName =  "";
                        switch (targetGroupBox.Name)
                        {
                            case "gb_filtrosPrecio": columnName = "precio"; break;
                            case "gb_filtrosPrecioFinal": columnName = "precio_final"; break;
                            case "gb_filtroStock": columnName = "stock"; break;
                            case "gb_filtrosFechaCreacion": columnName = "fecha_creacion"; break;
                            case "gb_filtrosFechaModificacion": columnName = "fecha_modificacion"; break;                                 
                        }
                       
                        foreach (Control sControl in targetGroupBox.Controls)
                        {
                            if (sControl is NumericUpDown && (sControl as NumericUpDown).Value > 0)
                            {
                                string fOperator = sControl.Name.Contains("Mayor") ? " >= " : " <= ";
                                string value = (sControl as NumericUpDown).Value.ToString().Replace(",", ".");
                                filters += filters != "" ? " AND " + columnName + fOperator + value : columnName + fOperator + value; 
                            }
                            else if (sControl is DateTimePicker && (sControl as DateTimePicker).Checked)
                            {
                                string fOperator = sControl.Name.Contains("Despues") ? " >= " : " <= ";
                                string value = "'" + (sControl as DateTimePicker).Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                                filters += filters != "" ? " AND " + columnName + fOperator + value : columnName + fOperator + value; 
                            }
                        }
                    }
                }
            }

            if (cb_filtroArticulosAMostrar.SelectedIndex != 2)
            {
                filters += filters != "" ? " AND oculto = " + cb_filtroArticulosAMostrar.SelectedIndex  : "oculto = " + cb_filtroArticulosAMostrar.SelectedIndex; 
            }

            return filters;
        }

        private void dgv_listaProductos_DataSourceChanged(object sender, EventArgs e)
        {
            ParseDataGrid();
        }

        private void cms_menuProductos_Opening(object sender, CancelEventArgs e)
        {
            int selectedRowsNumber = dgv_listaProductos.SelectedRows.Count;
            string itemText = String.Format("{0} {1}", selectedRowsNumber, selectedRowsNumber > 1 ? "Filas Seleccionadas" : "Fila Selecionada");
            tsmi_filasSeleccionadas.Text = itemText;

            tsmi_addToLocation.Visible = false;
            tsmi_locationName.Visible = false;
            tss_locationSeparator.Visible = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Ubicacion)
                {
                    tsmi_addToLocation.Visible = true;
                    tsmi_locationName.Visible = true;
                    tsmi_locationName.Text = (frm as Ubicacion).selectedLocationName();
                    tss_locationSeparator.Visible = true;
                }
            }
        }

        private void dgv_listaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                if (dgv_listaProductos.SelectedRows.Count > 1 && dgv_listaProductos.SelectedRows.Contains(dgv_listaProductos.Rows[e.RowIndex]))
                {
                    cms_menuProductos.Show(dgv_listaProductos, dgv_listaProductos.PointToClient(Cursor.Position));
                }
                else
                {
                    for (int cell = 0; cell < dgv_listaProductos.Rows[0].Cells.Count; cell++)
                    {
                        if (dgv_listaProductos.Columns[cell].Visible)
                        {
                            dgv_listaProductos.CurrentCell = dgv_listaProductos.Rows[e.RowIndex].Cells[cell];
                            break;
                        }
                    }
                    cms_menuProductos.Show(dgv_listaProductos, dgv_listaProductos.PointToClient(Cursor.Position));
                }
            }
        }

        private void runQuery(bool filterChanged = false, bool changePage = false)
        {
            if (bgw_actualizarProducto != null && bgw_actualizarProducto.IsBusy)
            {
                return;
            }

            int rIdx = 0, cIdx = 0;
            if (dgv_listaProductos.DataSource != null && dgv_listaProductos.Rows.Count > 0 && !changePage)
            {
                rIdx = dgv_listaProductos.CurrentCell.RowIndex;
                cIdx = dgv_listaProductos.CurrentCell.ColumnIndex;
            }         

            if (filterChanged)
            {
                string filters = buildFilters();
                if (currentQuery.Contains("WHERE"))
                {
                    currentQuery = currentQuery.Remove(currentQuery.IndexOf(" WHERE"));
                }
                currentQuery = filters != "" ? currentQuery + " WHERE " + filters : currentQuery;
                rIdx = cIdx = 0;
            }

            BG.LastSelectedRowIndex = rIdx;
            BG.LastSelectedColumnIndex = cIdx;

            if (BG.IsSearchInProgress)
                BG.CancelSearch();
           
            BG.StartSearch(currentQuery);
        }

        private void cb_itemsPerPage_TextChanged(object sender, EventArgs e)
        {
            BG.ItemsPerPage = getItemsPerPage();
            BG.CurrentPage = 0;
        }

        private void btn_prevPage_Click(object sender, EventArgs e)
        {
            BG.CurrentPage--;
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            BG.CurrentPage++;
        }

        private void dgv_listaProductos_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyData == Keys.Right){
               btn_nextPage.PerformClick();
            }
            if (e.KeyData == Keys.Left) {
                btn_prevPage.PerformClick();
            }
            if (e.KeyData.ToString() == "D, Control")
            {
                tsmi_marcar_Click(tsmi_marcarOculto, EventArgs.Empty);
            }
            if (e.KeyData.ToString() == "S, Control")
            {
                tsmi_marcar_Click(tsmi_marcarVisible, EventArgs.Empty);
            }
        }

        private void dgv_listaProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string colName = dgv_listaProductos.Columns[dgv_listaProductos.CurrentCell.ColumnIndex].Name;

            if (colName == "precio")
            {
                e.Control.Text = e.Control.Text.Replace("$", "");
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }

            if (colName == "porcentaje")
            {
                e.Control.Text = e.Control.Text.Replace("%", "");
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        void filterTrigger(object sender, EventArgs e)
        {
            //runQuery(true);
            if (bgw_waitFilter.IsBusy)
            {
                afldbg.log(this, "filterTrigger Called. Cancelling Wait Filter. Caller: [" + sender.ToString()+"]");
                bgw_waitFilter.CancelAsync();
            }
            else
            {
                afldbg.log(this, "filterTrigger Called. Starting Wait Filter. Caller: ["+sender.ToString()+"]");
                bgw_waitFilter.RunWorkerAsync();
            }
        }

        void calcularPorcentaje(int rIdx)
        {
            double precio = Convert.ToDouble(dgv_listaProductos["precio", rIdx].Value.ToString());
            double porcentaje = Convert.ToDouble(dgv_listaProductos["porcentaje", rIdx].Value.ToString());
            double plus = (precio * porcentaje) / 100;
            double precio_final = Math.Round((precio + plus), 2, MidpointRounding.AwayFromZero);
            dgv_listaProductos.CellValueChanged -= dgv_listaProductos_CellValueChanged;
            dgv_listaProductos["precio_final", rIdx].Value = precio_final;
            dgv_listaProductos.CellValueChanged += dgv_listaProductos_CellValueChanged;
        }

        private void dgv_listaProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("El valor ingresado no es correcto para el tipo de dato de la columna.", "Fomato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dgv_listaProductos.CancelEdit();
        }

        private void dgv_listaProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_listaProductos.Rows.Count == 0 || e.RowIndex == -1)
                return;
            int rIdx = e.RowIndex;

            calcularPorcentaje(rIdx);

            BD DBCon = new BD();
            string query = "UPDATE producto SET codigo_barra = '{0}', nombre = '{1}', stock = {2}, precio = {3}, porcentaje = {4}, precio_final = {5},oculto = {6}, pro_seccion_id = {7} WHERE id = {8}";
            
            string id = dgv_listaProductos["id", rIdx].Value.ToString();
            string codigo_barra = dgv_listaProductos["codigo_barra", rIdx].Value.ToString();
            string nombre = dgv_listaProductos["nombre", rIdx].Value.ToString().Replace("'", "\\'"); ;
            string stock = dgv_listaProductos["stock", rIdx].Value.ToString().Replace(",",".");
            string precio = dgv_listaProductos["precio", rIdx].Value.ToString().Replace(",", ".");
            string porcentaje = dgv_listaProductos["porcentaje", rIdx].Value.ToString().Replace(",", ".");
            string precio_final = dgv_listaProductos["precio_final", rIdx].Value.ToString().Replace(",", ".");
            string oculto = dgv_listaProductos["oculto", rIdx].Value.ToString();
            string pro_seccion_id = dgv_listaProductos["pro_seccion_id", rIdx].Value.ToString();

            query = String.Format(query, codigo_barra, nombre, stock, precio, porcentaje, precio_final, oculto, pro_seccion_id, id);
            DBCon.Write(query);
        }

        private void tsmi_marcar_Click(object sender, EventArgs e)
        {
            int value = (sender as ToolStripMenuItem).Name.Contains("Visible") ? 0 : 1;
            DataGridViewSelectedRowCollection selectedRows = dgv_listaProductos.SelectedRows;
            
            bgw_actualizarProducto = new BackgroundWorker();
            bgw_actualizarProducto.DoWork += new DoWorkEventHandler(bgw_actualizarProducto_DoWork);
            bgw_actualizarProducto.WorkerReportsProgress = true;
            bgw_actualizarProducto.ProgressChanged += new ProgressChangedEventHandler(bgw_actualizarProducto_ProgressChanged);
            bgw_actualizarProducto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_actualizarProducto_RunWorkerCompleted);

            object[] argument = {selectedRows,value, "oculto",""};
            toggleDataGridInteraction(dgv_listaProductos, false);
            pb_productProgress.Visible = true;
            bgw_actualizarProducto.RunWorkerAsync(argument);
        }

        void toggleDataGridInteraction(DataGridView target,bool enabled)
        {
            if (enabled)
            {
                target.DefaultCellStyle.BackColor = SystemColors.Window;
                target.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                target.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                target.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.WindowText;
                target.ReadOnly = false;
                target.EnableHeadersVisualStyles = true;
                target.Enabled = true;              
            }
            else
            {
                target.DefaultCellStyle.BackColor = SystemColors.Control;
                target.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                target.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                target.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                target.ReadOnly = true;
                target.EnableHeadersVisualStyles = false;
                target.Enabled = false;             
            }
        }

        void bgw_actualizarProducto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb_productProgress.Value = 0;
            pb_productProgress.Visible = false;
            runQuery();
            toggleDataGridInteraction(dgv_listaProductos, true);         
        }

        void bgw_actualizarProducto_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_estado.Text = e.UserState.ToString();
            //if (pb_productProgress.Width > tlp_productProgressInfo.GetColumnWidths()[1])
            //    pb_productProgress.Width = tlp_productProgressInfo.GetColumnWidths()[1];
            pb_productProgress.Value = e.ProgressPercentage;
        }

        void bgw_actualizarProducto_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] parametros = e.Argument as object[];
            BackgroundWorker bgw = sender as BackgroundWorker;

            DataGridViewSelectedRowCollection selectedRows = parametros[0] as DataGridViewSelectedRowCollection;
            var value = parametros[1];
            string columnName = parametros[2].ToString();
            string percentMode = parametros[3].ToString();
            int cont = 0;
            int cap = selectedRows.Count;

            if (columnName == "porcentaje" && percentMode == "sumar")
            {
                foreach (DataGridViewRow sRow in selectedRows)
                {
                    sRow.Cells[columnName].Value =  double.Parse(sRow.Cells[columnName].Value.ToString()) + Convert.ToDouble(value);
                    cont++;
                    bgw.ReportProgress( (cont * 100) / cap, "Guardando cambios: " + cont + " de " + cap);
                }
            }
            else if (columnName == "precio")
            {
                foreach (DataGridViewRow sRow in selectedRows)
                {
                    double oldValue = double.Parse(sRow.Cells[columnName].Value.ToString().Replace("$",""));
                    double newValue = oldValue + ( (Convert.ToDouble(value) * oldValue) / 100 );
                    sRow.Cells[columnName].Value = newValue;
                    cont++;
                    bgw.ReportProgress((cont * 100) / cap, "Guardando cambios: " + cont + " de " + cap);
                }
            }
            else if (columnName == "id")
            {
                BD DBCon = new BD();
                string query = "DELETE FROM producto WHERE id = {0}";
                foreach (DataGridViewRow sRow in selectedRows)
                {
                    string pro_id = sRow.Cells[columnName].Value.ToString();
                    DBCon.Write(String.Format(query, pro_id));
                    cont++;
                    bgw.ReportProgress((cont * 100) / cap, "Guardando cambios: " + cont + " de " + cap);
                }
            }
            else
            {
                foreach (DataGridViewRow sRow in selectedRows)
                {
                    sRow.Cells[columnName].Value = Convert.ToDouble(value);
                    cont++;
                    bgw.ReportProgress((cont * 100) / cap, "Guardando cambios: " + cont + " de " + cap);
                }
            }         
        }

        private void tsmi_Porcentaje_Click(object sender, EventArgs e)
        {
            
            string percentMode = "";
            string columnName = "porcentaje";

            if ((sender as ToolStripMenuItem).Name.Contains("Precio"))
            {
                percentMode = "incrementar sobre el precio";
                columnName = "precio";
            }
            else
            {
                percentMode = (sender as ToolStripMenuItem).Name.Contains("sumar") ? "sumar" : "aplicar";
            }

            AplicarPorcentaje AP = new AplicarPorcentaje(percentMode);
            
            if (AP.ShowDialog(this) == DialogResult.OK)
            {
                bgw_actualizarProducto = new BackgroundWorker();
                bgw_actualizarProducto.DoWork += new DoWorkEventHandler(bgw_actualizarProducto_DoWork);
                bgw_actualizarProducto.WorkerReportsProgress = true;
                bgw_actualizarProducto.ProgressChanged += new ProgressChangedEventHandler(bgw_actualizarProducto_ProgressChanged);
                bgw_actualizarProducto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_actualizarProducto_RunWorkerCompleted);

                DataGridViewSelectedRowCollection selectedRows = dgv_listaProductos.SelectedRows;
                double value = AP.Result;
                toggleDataGridInteraction(dgv_listaProductos, false);
                pb_productProgress.Visible = true;
                bgw_actualizarProducto.RunWorkerAsync(new object[] { selectedRows, value, columnName, percentMode });
            }
            
            

        }

        private void tsmi_seleccionarTodo_Click(object sender, EventArgs e)
        {
            dgv_listaProductos.SelectAll();
        }

        private void tsmi_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_listaProductos.SelectedRows;
            int elementCount = selectedRows.Count;
            string messagePart = elementCount > 1 ? " elementos" : " elemento";
            DialogResult res = MessageBox.Show("¿Está seguro que desea eliminar " + elementCount + messagePart + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bgw_actualizarProducto = new BackgroundWorker();
                bgw_actualizarProducto.DoWork += new DoWorkEventHandler(bgw_actualizarProducto_DoWork);
                bgw_actualizarProducto.WorkerReportsProgress = true;
                bgw_actualizarProducto.ProgressChanged += new ProgressChangedEventHandler(bgw_actualizarProducto_ProgressChanged);
                bgw_actualizarProducto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_actualizarProducto_RunWorkerCompleted);
                pb_productProgress.Visible = true;
                toggleDataGridInteraction(dgv_listaProductos, false);
                bgw_actualizarProducto.RunWorkerAsync(new object[] { selectedRows, 1, "id", "" });
            }          
        }

        private void tsmi_addToLocation_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_listaProductos.SelectedRows;
            int locationID = 0;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Ubicacion)
                {
                    locationID = (frm as Ubicacion).selectedLocationID();
                }
            }

            bgw_actualizarProducto = new BackgroundWorker();
            bgw_actualizarProducto.DoWork += new DoWorkEventHandler(bgw_actualizarProducto_DoWork);
            bgw_actualizarProducto.WorkerReportsProgress = true;
            bgw_actualizarProducto.ProgressChanged += new ProgressChangedEventHandler(bgw_actualizarProducto_ProgressChanged);
            bgw_actualizarProducto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_actualizarProducto_RunWorkerCompleted);
            pb_productProgress.Visible = true;
            toggleDataGridInteraction(dgv_listaProductos, false);
            bgw_actualizarProducto.RunWorkerAsync(new object[] { selectedRows, locationID, "pro_seccion_id", "" });
  
        }

        private void tb_filtroNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                btn_nextPage.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                btn_prevPage.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Up)
            {
                try
                {
                    dgv_listaProductos.CurrentCell = dgv_listaProductos[dgv_listaProductos.CurrentCell.ColumnIndex, dgv_listaProductos.CurrentCell.RowIndex - 1];
                }
                catch { }
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                try
                {
                    dgv_listaProductos.CurrentCell = dgv_listaProductos[dgv_listaProductos.CurrentCell.ColumnIndex, dgv_listaProductos.CurrentCell.RowIndex + 1];
                }
                catch { }
                e.Handled = true;
            }
        }

        private void tsmi_chooseColumns_Click(object sender, EventArgs e)
        {
            ElegirColumnas EC = new ElegirColumnas(dgv_listaProductos.Columns,this);
            EC.ShowDialog(this);
        }

        private void dgv_listaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_listaProductos["oculto", e.RowIndex].Value.ToString() == "1")
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        #endregion

        #region Tab Importar Desde Excel

        private void btn_seleccionarArchivo_Click(object sender, EventArgs e)
        {
            ImportWindow IW = new ImportWindow();
            if (IW.ShowDialog(this) == DialogResult.OK)
            {
                DataTable parcialTable = IW.ImportedExcel;
                parcialTable.Columns.Add("Precio a Importar",typeof(double));
                dgv_listadoExcel.DataSource = parcialTable;
                lbl_importedFileName.Text = IW.FileName.Replace("\\","");
                CanTransfer();
            }
        }

        private void tp_importarProductos_Enter(object sender, EventArgs e)
        {
            loadProviderComboBox("Seleccione un proveedor", "1", cb_listaProveedores);
            this.WindowState = winLastState;
            this.Size = new Size(winLastWidth, winLastHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
        }

        private void cb_listaProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanTransfer();
        }

        void CanTransfer()
        {
            btn_transferir.Enabled = cb_listaProveedores.SelectedIndex > 0 && dgv_listadoExcel.DataSource != null && dgv_listadoExcel.Rows.Count > 0;
        }

        private void dgv_listadoExcel_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_listadoExcel.DataSource != null)
            {
                foreach (DataGridViewColumn sCol in dgv_listadoExcel.Columns)
                {
                    if (sCol.Name != "Descripción")
                        sCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

                dgv_listadoExcel.Columns["Codigo"].ReadOnly = true;

                int articleCount = dgv_listadoExcel.Rows.Count;

                lbl_impArticleCount.Text = articleCount > 0 ? articleCount + " articulos a importar." : "No hay articulos a importar";

                dgv_listadoExcel.Columns["Precio"].DefaultCellStyle.Format = "$0.00";
                import_applyPercentage();
            }
        }

        private void dgv_listadoExcel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (double.Parse(dgv_listadoExcel["Precio", e.RowIndex].Value.ToString()) == 0.00)
            {
                e.CellStyle.BackColor = Color.Yellow;
            }
        }

        private void import_applyPercentage()
        {
            double percentage = Convert.ToDouble(nud_importPercentage.Value);
            double plus = 0;
            foreach (DataGridViewRow sRow in dgv_listadoExcel.Rows)
            {
                double valor = Convert.ToDouble(sRow.Cells[2].Value);
                plus = (valor * percentage) / 100;

                sRow.Cells[3].Value = (valor + plus).ToString("00.00");
            }
            dgv_listadoExcel.Columns["Precio a Importar"].DefaultCellStyle.Format = "$0.00";
        }

        private void nud_importPercentage_ValueChanged(object sender, EventArgs e)
        {
            import_applyPercentage();
        }

        private void nud_importPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        BackgroundWorker bgw_transferToDB;

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Está seguro que desea continuar?", "Transferir a Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bgw_transferToDB = new BackgroundWorker();
                bgw_transferToDB.WorkerReportsProgress = true;
                bgw_transferToDB.WorkerSupportsCancellation = true;
                bgw_transferToDB.DoWork += new DoWorkEventHandler(bgw_transferToDB_DoWork);
                bgw_transferToDB.ProgressChanged += new ProgressChangedEventHandler(bgw_transferToDB_ProgressChanged);
                bgw_transferToDB.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_transferToDB_RunWorkerCompleted);

                DataTable productsToImport = dgv_listadoExcel.DataSource as DataTable;
                int id_proveedor = int.Parse((cb_listaProveedores.SelectedItem as DataRowView)["id"].ToString());

                object[] args = new object[] { productsToImport, id_proveedor };

                btn_cancelarTransferencia.Enabled = true;
                btn_transferir.Enabled = false;
                dgv_listadoExcel.Enabled = false;
                cb_listaProveedores.Enabled = false;
                nud_importPercentage.Enabled = false;

                pb_transferProgress.Maximum = 100;
                pb_transferProgress.Minimum = 0;
                pb_transferProgress.Style = ProgressBarStyle.Continuous;

                bgw_transferToDB.RunWorkerAsync(args);
            }
        }

        void bgw_transferToDB_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable productsToImport = ((e.Argument as object[])[0] as DataTable);
            int id_proveedor = int.Parse((e.Argument as object[])[1].ToString());
            DateTime startTime = DateTime.Now;
            BD DBCon = new BD();

            int updated = 0, inserted = 0;

            foreach (DataRow sRow in productsToImport.Rows)
            {
                if (bgw_transferToDB.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    string codigo = sRow[0].ToString().Trim();
                    string nombre = sRow[1].ToString().Replace("\"", "\\\"").Replace("'", "").Trim();
                    double precio = Convert.ToDouble(sRow[3].ToString().Trim());
                    string query = String.Format("Call sp_importFromExcel('{0}','{1}',{2},{3})", codigo,nombre,precio.ToString("0.00",CultureInfo.InvariantCulture),id_proveedor);
                    int result = -1;
                    //while (result == -1)
                    //{
                    //    try
                    //    {
                    //        afldbg.log(this, "Trying to connecto to database", "green");
                            result = int.Parse(DBCon.Read(query).Rows[0][0].ToString());
                    //    }
                    //    catch
                    //    {
                    //        afldbg.log(this, "Connection failed! Retrying in 3 seconds...", "red");
                    //        bgw_transferToDB.ReportProgress(0, 1);
                    //        Thread.Sleep(3000);
                    //        afldbg.log(this, "3 seconds passed, retrying...", "red");
                    //        if (bgw_transferToDB.CancellationPending)
                    //        {
                    //            afldbg.log(this, "Transfer Cancelled", "orange");
                    //            e.Cancel = true;
                    //            return;
                    //        }
                    //    }
                        
                    //}                   
                    if (result == 1)
                        updated++;
                    else
                        inserted++;
                    transferExcelToDataBaseProgressInfo userState = new transferExcelToDataBaseProgressInfo(updated,inserted,productsToImport.Rows.Count, DateTime.Now - startTime);
                    bgw_transferToDB.ReportProgress(0, userState);
                    e.Result = userState;
                }
            }
        }

        void bgw_transferToDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is transferExcelToDataBaseProgressInfo)
            {
                transferExcelToDataBaseProgressInfo data = e.UserState as transferExcelToDataBaseProgressInfo;

                pb_transferProgress.Value = Convert.ToInt32(data.Percentage);

                string infoText = "Transfiriendo... {0}% ({1}/{2}) [Tiempo Transcurrido: {3}:{4}] | Agregados: {5} / Actualizados: {6}";
                lbl_progresoInfo.Text = String.Format(infoText, data.Percentage.ToString("00.00", CultureInfo.InvariantCulture), data.Proccessed,
                                                      data.Total, data.ElapsedTime.Minutes.ToString("00"), data.ElapsedTime.Seconds.ToString("00"),
                                                      data.Inserted, data.Updated);
            }
            else
            {
                lbl_progresoInfo.Text = "La conexión a la base de datos se ha perdido, reintentando en 3 segundos.";
            }
            
            
        }

        void bgw_transferToDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            if (e.Cancelled)
            {
                lbl_progresoInfo.Text = "Tranferencia Cancelada.";
            }
            else
            {
                transferExcelToDataBaseProgressInfo data = e.Result as transferExcelToDataBaseProgressInfo;
                string completeInfo = "Tranferencia Completada en {0}:{1}, {2} productos agregados, {3} productos actualizados.";
                lbl_progresoInfo.Text = String.Format(completeInfo,data.ElapsedTime.Minutes.ToString("00"),data.ElapsedTime.Seconds.ToString("00"),
                                                      data.Inserted,data.Updated);
            }
            
            pb_transferProgress.Value = 0;
            nud_importPercentage.Enabled = true;
            cb_listaProveedores.SelectedIndex = 0;
            dgv_listadoExcel.Enabled = true;
            btn_cancelarTransferencia.Enabled = false;
            cb_listaProveedores.Enabled = true;
        }

        private void btn_cancelarTransferencia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Está seguro que desea cancelar la transferencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bgw_transferToDB.CancelAsync();
            }
        }

        #endregion       


        //private void loadLastConfig()
        //{ 
        //    BD DBCon = new BD();
        //    DataTable settings = DBCon.Read(String.Format("SELECT opcion, valor FROM setting WHERE usuario_id = {0} AND area = '{1}'",Usuario.ID,"Administrar_Stock"));
        //    foreach (DataRow option in settings.Rows)
        //    {
        //        if (option["opcion"].ToString().StartsWith("cb_"))
        //        {
        //            (this.Controls.Find(option["opcion"].ToString(),true)[0] as CheckBox).Checked = option["valor"].ToString() == "0" ? false : true;
                    
        //        }             
        //    }
        //}

        //private void saveConfig()
        //{ 
            
        //}

    }

    public class transferExcelToDataBaseProgressInfo
    {

        double percentage = 0;

        public double Percentage
        {
            get { return percentage; }
        }

        TimeSpan elapsedTime = new TimeSpan();

        public TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
        }

        int updated = 0, inserted = 0, total = 0, proccessed = 0, remaining = 0;

        public int Total
        {
            get { return total; }
        }

        public int Remaining
        {
            get { return remaining; }
        }

        public int Proccessed
        {
            get { return proccessed; }
        }

        public int Inserted
        {
            get { return inserted; }
        }

        public int Updated
        {
            get { return updated; }
        }

        public transferExcelToDataBaseProgressInfo(int u, int i, int t, TimeSpan et)
        {
            updated = u;
            inserted = i;
            total = t;
            proccessed = u + i;
            remaining = total - proccessed;
            percentage = ((Convert.ToDouble(proccessed) * 100D) / Convert.ToDouble(total));
            elapsedTime = et;
        }
    }


    public delegate void ASC_ChangedHandler(string option, object newValue);

    public class Adminstrar_Stock_Config
    {
        public event ASC_ChangedHandler OptionChanged;

        private void OnOptionChanged(string option, object newValue)
        {
            if (OptionChanged != null)
                OptionChanged(option, newValue);
        }

        private int winLastWidth = 1200;
        public int WinLastWidth
        {
            get { return winLastWidth; }
            set { 
                    winLastWidth = value;
                    //OnOptionChanged("winLastWidth"
                }
        }

        private int winLastHeight = 450;
        public int WinLastHeight
        {
            get { return winLastHeight; }
            set { winLastHeight = value; }
        }

        FormWindowState winLastState = FormWindowState.Normal;
        public FormWindowState WinLastState
        {
            get { return winLastState; }
            set { winLastState = value; }
        }

        private bool includeZeroPriced = false;
        public bool IncludeZeroPriced
        {
            get { return includeZeroPriced; }
            set { includeZeroPriced = value; }
        }

        private bool updateDescription = false;
        public bool UpdateDescription
        {
            get { return updateDescription; }
            set { updateDescription = value; }
        }


    }


}
