using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Ventas
{
    public partial class BusquedaProducto : Form
    {
        const double ItemsPerPage = 25;
        string _pageQuery = "";
        int _curPage;
        int _totalPages;
        public bool Ventas = true;
        BackgroundWorker _bgwWaitFilter;

        public BusquedaProducto(int proveedorId = -1, string searchPhrase = "")
        {
            InitializeComponent();
            Initialize();
            if (proveedorId != -1)
            {
                foreach (var sItem in cb_filterProvider.Items.Cast<object>().Where(sItem =>
                {
                    var dataRowView = sItem as DataRowView;
                    return dataRowView != null && int.Parse(dataRowView["id"].ToString()) == proveedorId;
                }))
                {
                    cb_filterProvider.SelectedItem = sItem;
                    cb_filterProvider.Enabled = false;
                    Ventas = false;
                    DoSearch();
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
                DoSearch();
            }
            else
            {
                _bgwWaitFilter.RunWorkerAsync();
            }
        }

        void bgw_waitFilter_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            var backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker != null) e.Cancel = backgroundWorker.CancellationPending;
        }

        public void Initialize()
        {
            LoadProviderComboBox(" Todos los proveedores","1",cb_filterProvider);
            _bgwWaitFilter = new BackgroundWorker();
            _bgwWaitFilter.DoWork += bgw_waitFilter_DoWork;
            _bgwWaitFilter.WorkerSupportsCancellation = true;
            _bgwWaitFilter.RunWorkerCompleted += bgw_waitFilter_RunWorkerCompleted;
        }

        private static void LoadProviderComboBox(string firstItem, string condition, ComboBox cbTarget)
        {
            Bd dbCon = new Bd();
            DataTable providerTable = dbCon.Read("SELECT id,nombre FROM proveedor WHERE " + condition);
            DataRow defaultRow = providerTable.NewRow();
            defaultRow[0] = "-1";
            defaultRow[1] = firstItem;
            providerTable.Rows.Add(defaultRow);
            providerTable.DefaultView.Sort = "nombre asc";
            cbTarget.DataSource = providerTable;
            cbTarget.DisplayMember = "nombre";
        }

        private string BuildCondition()
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
            if (_bgwWaitFilter.IsBusy)
            {
                _bgwWaitFilter.CancelAsync();
            }
            else
            {
                _bgwWaitFilter.RunWorkerAsync();
            }
        }

        private void DoSearch()
        {
            Bd dbCon = new Bd();
            string stringToSearch = BuildCondition();
            _curPage = 0;

            string stockAddition = chb_stock.Checked ?  " AND Stock > 0" : "";
            const string visibilityAddition = " AND oculto = 0";
            string providerAddition = cb_filterProvider.SelectedIndex > 0 ? " AND ProveedorID = " + (cb_filterProvider.SelectedItem as DataRowView)["id"].ToString() : "";
            string columns = Ventas ? "Codigo,Proveedor, Descripcion,Stock,Precio,id, Ubicacion,oculto" : "Codigo,Proveedor, Descripcion,Stock,Costo,id,oculto";
            const string count = "Count(*)";
            string query = "SELECT {0} FROM vista_tablaproductosventas WHERE ((" + stringToSearch + ") OR codigo LIKE '%" + tb_filterWords.Text.Trim() + "%')" + providerAddition + stockAddition + visibilityAddition;
            
            double rowCount =  double.Parse(dbCon.Read(String.Format(query,count)).Rows[0][0].ToString());

            lbl_info.Text = rowCount + (rowCount != 1 ? " articulos encontrados." : " articulo encontrado.");

            _totalPages =  Convert.ToInt32(Math.Ceiling(rowCount / ItemsPerPage));

            _pageQuery = String.Format(query, columns); 

            DataTable res = dbCon.Read(String.Format(query,columns) + " LIMIT 0,"+ItemsPerPage);
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
                DoSearch();
        }

        private void chb_stock_CheckedChanged(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            Bd dbCon = new Bd();
            _curPage++;
            dgv_productList.DataSource = dbCon.Read(_pageQuery + " LIMIT " + (_curPage * ItemsPerPage) + "," + ItemsPerPage);
        }

        private void dgv_productList_DataSourceChanged(object sender, EventArgs e)
        {
            _curPage = _totalPages > 0 ? _curPage : -1;
            lbl_pageInfo.Text = (_curPage + 1) + @"/" + _totalPages;
            btn_nextPage.Enabled = _curPage + 1 < _totalPages;
            btn_prevPage.Enabled = _curPage > 0;
        }

        private void btn_prevPage_Click(object sender, EventArgs e)
        {
            Bd dbCon = new Bd();
            _curPage--;
            dgv_productList.DataSource = dbCon.Read(_pageQuery + " LIMIT " + (_curPage * ItemsPerPage) + "," + ItemsPerPage);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_productList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            AddItem(e.RowIndex);

        }

        private void AddItem(int rowIndex)
        {
            string proName = dgv_productList["Descripcion", rowIndex].Value.ToString();      
            
            if (cb_filterProvider.Enabled)
            {
                double precio = double.Parse(dgv_productList["Precio", rowIndex].Value.ToString());
                Ventas ventasWindow = GetVentasWindowHwnd();
                if (ventasWindow == null)
                {
                    return;
                }                

                BusquedaProductoAgregarCantidad bpac = new BusquedaProductoAgregarCantidad(precio,proName);

                bpac.ShowDialog(this);

                if (bpac.DialogResult == DialogResult.OK)
                {
                    double quantity = bpac.Value;
                    bpac.Close();
                    ventasWindow.AddItemToCartFromSearchWindow(int.Parse(dgv_productList.Rows[rowIndex].Cells["id"].Value.ToString()), quantity);
                }
            }
            else
            {
                double precio = double.Parse(dgv_productList["Costo", rowIndex].Value.ToString());
                Pedidos.Pedidos pedidosWindow = GetPedidosWindowHwnd();
                if (pedidosWindow == null)
                {
                    return;
                }

                BusquedaProductoAgregarCantidad bpac = new BusquedaProductoAgregarCantidad(precio, proName);

                bpac.ShowDialog(this);

                if (bpac.DialogResult == DialogResult.OK)
                {
                    double quantity = bpac.Value;
                    bpac.Close();
                    pedidosWindow.AddItemToCartFromSearchWindow(int.Parse(dgv_productList.Rows[rowIndex].Cells["id"].Value.ToString()), quantity);
                }
            }
            
        }

        private Ventas GetVentasWindowHwnd()
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

        private Pedidos.Pedidos GetPedidosWindowHwnd()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Pedidos.Pedidos)
                {
                    return frm as Pedidos.Pedidos;
                }
            }
            return null;
        }

        private void dgv_productList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && dgv_productList.SelectedRows.Count > 0)
            {
                int rowIndex = dgv_productList.SelectedRows[0].Index;
                AddItem(rowIndex);
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
                Close();
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
                    catch
                    {
                        // ignored
                    }
                    e.Handled = true;
                    break;
                case Keys.Up:
                    try
                    {
                        dgv_productList.CurrentCell = dgv_productList[0, dgv_productList.CurrentCell.RowIndex - 1];
                    }
                    catch
                    {
                        // ignored
                    }
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
                        AddItem(rIdx);
                    e.Handled = true;
                    break;
            }
        }



    }
}
