using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;
using FerreteriaSL.Clases_Genericas;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace FerreteriaSL.Componentes
{
    public delegate void SelectionMadeHandler(object sender, int idProducto);

    public delegate void EstimateScannedHandler(object sender, string barcode);

    public partial class ComboGrid : UserControl
    {
        int _textBoxHeight = 20;
        int _heightFix = 26;
        string _lastStringToSearch = "";
        public event SelectionMadeHandler SelectionMade;
        public event EstimateScannedHandler EstimateScanned;
        BackgroundWorker _bgwDelaySearch;

        public string SearchPhrase 
        {
            get { return tb_cuadroBusqueda.Text; }
            set { tb_cuadroBusqueda.Text = value; }
        }


        public ComboGrid()
        {
            InitializeComponent();
            _bgwDelaySearch = new BackgroundWorker();
            _bgwDelaySearch.WorkerSupportsCancellation = true;
            _bgwDelaySearch.DoWork += bgw_delaySearch_DoWork;
            _bgwDelaySearch.RunWorkerCompleted += bgw_delaySearch_RunWorkerCompleted;
        }

        void bgw_delaySearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                DoSearch();
            }
            else
            {
                _bgwDelaySearch.RunWorkerAsync();
            }
        }

        void bgw_delaySearch_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
            e.Cancel = _bgwDelaySearch.CancellationPending;
        }    

        void SelectionMadeCall(object sender, int idProducto)
        {
            if (SelectionMade != null)
            {
                SelectionMade(sender, idProducto);
            }
        }

        private void tb_cuadroBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (_bgwDelaySearch.IsBusy)
                _bgwDelaySearch.CancelAsync();
            else
                _bgwDelaySearch.RunWorkerAsync();
        }

        void DoSearch()
        {
            if (tb_cuadroBusqueda.Text.Trim().Length < 4)
            {
                dgv_vistaResultados.DataSource = null;
                _lastStringToSearch = "";
                lbl_moreInfo.Visible = false;
                _heightFix = 4;
                return;
            }

            Bd dbCon = new Bd();
            string stringToSearch = BuildCondition();

            if (stringToSearch == _lastStringToSearch)
            {
                return;
            }
            _lastStringToSearch = stringToSearch;
            string query = String.Format("SELECT Proveedor, Descripcion,Precio,id FROM vista_tablaproductosventas WHERE {0} OR Codigo LIKE '%{1}%' LIMIT 0,10", stringToSearch, tb_cuadroBusqueda.Text.Trim());
            DataTable res = dbCon.Read(query);
            if (res.Rows.Count >= 10)
            {
                int itemCount = int.Parse(dbCon.Read(query.Replace("Proveedor, Descripcion,Precio,id", "Count(*)")).Rows[0][0].ToString());
                lbl_moreInfo.Visible = true;
                lbl_moreInfo.Text = "+" + (itemCount - 10) + " articulos no mostrados.";
                _heightFix = 26;
            }
            else
            {
                lbl_moreInfo.Visible = false;
                _heightFix = 4;
            }
            dgv_vistaResultados.DataSource = res;
            dgv_vistaResultados.Columns["id"].Visible = false;
            dgv_vistaResultados.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_vistaResultados.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_vistaResultados.Columns["Precio"].DefaultCellStyle.Format = "$0.00";
            if (dgv_vistaResultados.Rows.Count <= 0) return;
            int trueHeight = dgv_vistaResultados.Rows[0].Height * dgv_vistaResultados.Rows.Count - 1;
            dgv_vistaResultados.Size = trueHeight > dgv_vistaResultados.Rows[0].Height * 10 ? new Size(dgv_vistaResultados.Size.Width, dgv_vistaResultados.Rows[0].Height * 10 + _heightFix) : new Size(dgv_vistaResultados.Size.Width, trueHeight + _heightFix);
        }

        private string BuildCondition()
        {
            string[] separateWords = tb_cuadroBusqueda.Text.Trim().Split(' ');
            string condition = "";
            for (int i = 0; i < separateWords.Length; i++)
            {
                condition += "Descripcion LIKE ";
                condition += "'%" + CommonStringParser.EscapeSqlQuery(separateWords[i]) + "%'";
                condition += i == separateWords.Length - 1 ? "" : " AND ";
            }
            return condition;
        }

        private void dgv_vistaResultados_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_vistaResultados.Rows.Count == 0)
            {
                Size = new Size(Width, _textBoxHeight);
                return;
            }
            
            int trueHeight = dgv_vistaResultados.Rows[0].Height * dgv_vistaResultados.Rows.Count - 1;

            Size = trueHeight > dgv_vistaResultados.Rows[0].Height * 10 ? new Size(Width, _textBoxHeight + dgv_vistaResultados.Rows[0].Height * 10 + _heightFix) : new Size(Width, _textBoxHeight + trueHeight + _heightFix);
                
        }

        private void tb_cuadroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 40:
                    if (dgv_vistaResultados.DataSource != null && dgv_vistaResultados.Rows.Count > 0 && dgv_vistaResultados.Rows.Count - 1 > dgv_vistaResultados.CurrentCell.RowIndex)
                    {           
                        dgv_vistaResultados.CurrentCell = dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex + 1].Cells[0];
                    }
                    e.Handled = true;
                    break;
                case 38:
                    if (dgv_vistaResultados.DataSource != null && dgv_vistaResultados.Rows.Count > 0 && dgv_vistaResultados.CurrentCell.RowIndex > 0)
                    {                        
                        dgv_vistaResultados.CurrentCell = dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex - 1].Cells[0];
                    }
                    e.Handled = true;
                    break;
                case 13:                    
                    if (dgv_vistaResultados.CurrentCell != null)
                    {
                        ItemSelected();
                    }
                    else if (tb_cuadroBusqueda.Text.StartsWith("PRES"))
                    {
                        OnEstimateScanned(tb_cuadroBusqueda.Text);
                        tb_cuadroBusqueda.Text = "";
                        dgv_vistaResultados.DataSource = null;
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case 27:
                    if (dgv_vistaResultados.DataSource != null)
                    {
                        dgv_vistaResultados.DataSource = null;
                        tb_cuadroBusqueda.Text = "";
                    }
                    e.Handled = true;
                    break;
            }       
        }

        public void ClearTextBox()
        {
            tb_cuadroBusqueda.Text = "";
        }

        private void ComboGrid_Enter(object sender, EventArgs e)
        {
            tb_cuadroBusqueda.Focus();
        }

        public void CloseDisplay() 
        {
            //dgv_vistaResultados.DataSource = null;
        }

        private void dgv_vistaResultados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemSelected();
        }

        private void ItemSelected()
        {
            SelectionMadeCall(this, Convert.ToInt32(dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["id"].Value));
            tb_cuadroBusqueda.TextChanged -= tb_cuadroBusqueda_TextChanged;
            tb_cuadroBusqueda.Text = dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["Descripcion"].Value.ToString();
            tb_cuadroBusqueda.TextChanged += tb_cuadroBusqueda_TextChanged;
            lbl_moreInfo.Visible = false;
            dgv_vistaResultados.DataSource = null;
        }

        protected virtual void OnEstimateScanned(string barcode)
        {
            var handler = EstimateScanned;
            if (handler != null) handler(this, barcode);
        }
    }
}
