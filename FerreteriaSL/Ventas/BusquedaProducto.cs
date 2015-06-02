using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FerreteriaSL
{
    public partial class BusquedaProducto : Form
    {
        const double itemsPerPage = 25;
        string pageQuery = "";
        int curPage = 0;
        int totalPages = 0;
        public bool ventas = true;
        BackgroundWorker bgw_waitFilter;

        public BusquedaProducto(int proveedor_id = -1, string searchPhrase = "")
        {
            InitializeComponent();
            initialize();
            if (proveedor_id != -1)
            {
                foreach (object sItem in cb_filterProvider.Items)
                {
                    if (int.Parse((sItem as DataRowView)["id"].ToString()) == proveedor_id)
                    {
                        cb_filterProvider.SelectedItem = sItem;
                        cb_filterProvider.Enabled = false;
                        ventas = false;
                        doSearch();
                    }
                }
            }

            tb_filterWords.Text = searchPhrase;
            tb_filterWords.Select();
            tb_filterWords.ScrollToCaret();
        }

        void bgw_waitFilter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                doSearch();
            }
            else
            {
                bgw_waitFilter.RunWorkerAsync();
            }
        }

        void bgw_waitFilter_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            e.Cancel = (sender as BackgroundWorker).CancellationPending;
        }

        public void initialize()
        {
            loadProviderComboBox(" Todos los proveedores","1",cb_filterProvider);
            bgw_waitFilter = new BackgroundWorker();
            bgw_waitFilter.DoWork += new DoWorkEventHandler(bgw_waitFilter_DoWork);
            bgw_waitFilter.WorkerSupportsCancellation = true;
            bgw_waitFilter.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_waitFilter_RunWorkerCompleted);
        }

        private void loadProviderComboBox(string firstItem, string condition, ComboBox cb_target)
        {
            BD DBCon = new BD();
            DataTable ProviderTable = DBCon.Read("SELECT id,nombre FROM proveedor WHERE " + condition);
            DataRow defaultRow = ProviderTable.NewRow();
            defaultRow[0] = "-1";
            defaultRow[1] = firstItem;
            ProviderTable.Rows.Add(defaultRow);
            ProviderTable.DefaultView.Sort = "nombre asc";
            cb_target.DataSource = ProviderTable;
            cb_target.DisplayMember = "nombre";
        }

        private string buildCondition()
        {
            string[] separateWords = tb_filterWords.Text.Trim().Split(' ');
            string condition = "";
            for (int i = 0; i < separateWords.Length; i++)
            {
                condition += "Descripcion LIKE ";
                condition += "'%" + separateWords[i] + "%'";
                condition += i == separateWords.Length - 1 ? "" : " AND ";
            }
            return condition;
        }

        private void tb_filterWords_TextChanged(object sender, EventArgs e)
        {
            if (bgw_waitFilter.IsBusy)
            {
                bgw_waitFilter.CancelAsync();
            }
            else
            {
                bgw_waitFilter.RunWorkerAsync();
            }
        }

        private void doSearch()
        {
            BD DBCon = new BD();
            string stringToSearch = buildCondition();
            curPage = 0;

            string stockAddition = chb_stock.Checked ?  " AND Stock > 0" : "";
            string visibilityAddition = " AND oculto = 0";
            string providerAddition = cb_filterProvider.SelectedIndex > 0 ? " AND ProveedorID = " + (cb_filterProvider.SelectedItem as DataRowView)["id"].ToString() : "";
            string columns = ventas ? "Codigo,Proveedor, Descripcion,Stock,Precio,id, Ubicacion,oculto" : "Codigo,Proveedor, Descripcion,Stock,Costo,id,oculto";
            string count = "Count(*)";
            string query = "SELECT {0} FROM vista_tablaproductosventas WHERE ((" + stringToSearch + ") OR codigo LIKE '%" + tb_filterWords.Text.Trim() + "%')" + providerAddition + stockAddition + visibilityAddition;
            
            double rowCount =  double.Parse(DBCon.Read(String.Format(query,count)).Rows[0][0].ToString());

            lbl_info.Text = rowCount + (rowCount != 1 ? " articulos encontrados." : " articulo encontrado.");

            totalPages =  Convert.ToInt32(Math.Ceiling(rowCount / itemsPerPage));

            pageQuery = String.Format(query, columns); 

            DataTable res = DBCon.Read(String.Format(query,columns) + " LIMIT 0,"+itemsPerPage);
            dgv_productList.DataSource = res;
            dgv_productList.Columns["id"].Visible = false;
            dgv_productList.Columns["oculto"].Visible = false;

            if (columns.Contains("Precio"))
            {
                dgv_productList.Columns["Precio"].DefaultCellStyle.Format = "$0.00";
            }
            else
            {
                dgv_productList.Columns["Costo"].DefaultCellStyle.Format = "$0.00";
            }


            foreach (DataGridViewColumn sCol in dgv_productList.Columns)
            {
                if (sCol.Name != "Descripcion")
                    sCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
             
        }

        private void cb_filterProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filterProvider.SelectedIndex >= 0)
                doSearch();
        }

        private void chb_stock_CheckedChanged(object sender, EventArgs e)
        {
            doSearch();
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            BD DBCon = new BD();
            curPage++;
            dgv_productList.DataSource = DBCon.Read(pageQuery + " LIMIT " + (curPage * itemsPerPage) + "," + itemsPerPage);
        }

        private void dgv_productList_DataSourceChanged(object sender, EventArgs e)
        {
            curPage = totalPages > 0 ? curPage : -1;
            lbl_pageInfo.Text = (curPage + 1) + "/" + totalPages;
            btn_nextPage.Enabled = curPage + 1 < totalPages;
            btn_prevPage.Enabled = curPage > 0;
        }

        private void btn_prevPage_Click(object sender, EventArgs e)
        {
            BD DBCon = new BD();
            curPage--;
            dgv_productList.DataSource = DBCon.Read(pageQuery + " LIMIT " + (curPage * itemsPerPage) + "," + itemsPerPage);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_productList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            addItem(e.RowIndex);

        }

        private void addItem(int rowIndex)
        {
            string pro_name = dgv_productList["Descripcion", rowIndex].Value.ToString();      
            
            if (cb_filterProvider.Enabled)
            {
                double precio = double.Parse(dgv_productList["Precio", rowIndex].Value.ToString());
                Ventas VentasWindow = getVentasWindowHwnd();
                if (VentasWindow == null)
                {
                    return;
                }                

                BusquedaProductoAgregarCantidad BPAC = new BusquedaProductoAgregarCantidad(precio,pro_name);

                BPAC.ShowDialog(this);

                if (BPAC.DialogResult == DialogResult.OK)
                {
                    double quantity = BPAC.Value;
                    BPAC.Close();
                    VentasWindow.addItemToCartFromSearchWindow(int.Parse(dgv_productList.Rows[rowIndex].Cells["id"].Value.ToString()), quantity);
                }
            }
            else
            {
                double precio = double.Parse(dgv_productList["Costo", rowIndex].Value.ToString());
                Pedidos PedidosWindow = getPedidosWindowHwnd();
                if (PedidosWindow == null)
                {
                    return;
                }

                BusquedaProductoAgregarCantidad BPAC = new BusquedaProductoAgregarCantidad(precio, pro_name);

                BPAC.ShowDialog(this);

                if (BPAC.DialogResult == DialogResult.OK)
                {
                    double quantity = BPAC.Value;
                    BPAC.Close();
                    PedidosWindow.addItemToCartFromSearchWindow(int.Parse(dgv_productList.Rows[rowIndex].Cells["id"].Value.ToString()), quantity);
                }
            }
            
        }

        private Ventas getVentasWindowHwnd()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Ventas)
                {
                    return frm as Ventas;
                }
            }
            return null;
        }

        private Pedidos getPedidosWindowHwnd()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Pedidos)
                {
                    return frm as Pedidos;
                }
            }
            return null;
        }

        private void dgv_productList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && dgv_productList.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_productList.SelectedRows[0].Index;
                addItem(rowIndex);
                e.Handled = true;
            }
            if (e.KeyData == Keys.Left)
            {
                btn_prevPage.PerformClick();
            }
            if (e.KeyData == Keys.Right)
            {
                btn_nextPage.PerformClick();
            }
        }

        private void BusquedaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B')
                this.Close();
        }

        private void tb_filterWords_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            { 
                case Keys.Down:
                    try
                    {
                        dgv_productList.CurrentCell = dgv_productList[0, dgv_productList.CurrentCell.RowIndex + 1];
                    }
                    catch { }
                    e.Handled = true;
                    break;
                case Keys.Up:
                    try
                    {
                        dgv_productList.CurrentCell = dgv_productList[0, dgv_productList.CurrentCell.RowIndex - 1];
                    }
                    catch { }
                    e.Handled = true;
                    break;
                case Keys.Right:
                    btn_nextPage.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Left:
                    btn_prevPage.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    int rIdx = dgv_productList.CurrentCell != null ? dgv_productList.CurrentCell.RowIndex : -1;
                    if (rIdx != -1)
                        addItem(rIdx);
                    e.Handled = true;
                    break;
            }
        }



    }
}
