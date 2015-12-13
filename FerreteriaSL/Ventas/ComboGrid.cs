using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace FerreteriaSL
{
    public delegate void SelectionMadeHandler(object sender, int id_producto);

    public partial class ComboGrid : UserControl
    {
        int textBoxHeight = 20;
        int heightFix = 26;
        string lastStringToSearch = "";
        public event SelectionMadeHandler SelectionMade;
        BackgroundWorker bgw_delaySearch;

        public string SearchPhrase 
        {
            get { return tb_cuadroBusqueda.Text; }
            set { tb_cuadroBusqueda.Text = value; }
        }


        public ComboGrid()
        {
            InitializeComponent();
            bgw_delaySearch = new BackgroundWorker();
            bgw_delaySearch.WorkerSupportsCancellation = true;
            bgw_delaySearch.DoWork += new DoWorkEventHandler(bgw_delaySearch_DoWork);
            bgw_delaySearch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_delaySearch_RunWorkerCompleted);
        }

        void bgw_delaySearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                doSearch();
            }
            else
            {
                bgw_delaySearch.RunWorkerAsync();
            }
        }

        void bgw_delaySearch_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
            e.Cancel = bgw_delaySearch.CancellationPending;
        }    

        void SelectionMadeCall(object sender, int id_producto)
        {
            if (SelectionMade != null)
            {
                SelectionMade(sender, id_producto);
            }
        }

        private void tb_cuadroBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (bgw_delaySearch.IsBusy)
                bgw_delaySearch.CancelAsync();
            else
                bgw_delaySearch.RunWorkerAsync();
        }

        void doSearch()
        {
            if (tb_cuadroBusqueda.Text.Trim().Length < 4)
            {
                dgv_vistaResultados.DataSource = null;
                lastStringToSearch = "";
                lbl_moreInfo.Visible = false;
                heightFix = 4;
                return;
            }

            BD DBCon = new BD();
            string stringToSearch = buildCondition();

            if (stringToSearch == lastStringToSearch)
            {
                return;
            }
            else
            {
                lastStringToSearch = stringToSearch;
            }
            string query = String.Format("SELECT Proveedor, Descripcion,Precio,id FROM vista_tablaproductosventas WHERE {0} OR Codigo LIKE '%{1}%' LIMIT 0,10", stringToSearch, tb_cuadroBusqueda.Text.Trim());
            DataTable res = DBCon.Read(query);
            if (res.Rows.Count >= 10)
            {
                int itemCount = int.Parse(DBCon.Read(query.Replace("Proveedor, Descripcion,Precio,id", "Count(*)")).Rows[0][0].ToString());
                lbl_moreInfo.Visible = true;
                lbl_moreInfo.Text = "+" + (itemCount - 10) + " articulos no mostrados.";
                heightFix = 26;
            }
            else
            {
                lbl_moreInfo.Visible = false;
                heightFix = 4;
            }
            dgv_vistaResultados.DataSource = res;
            dgv_vistaResultados.Columns["id"].Visible = false;
            dgv_vistaResultados.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_vistaResultados.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_vistaResultados.Columns["Precio"].DefaultCellStyle.Format = "$0.00";
            if (dgv_vistaResultados.Rows.Count > 0)
            {
                int trueHeight = dgv_vistaResultados.Rows[0].Height * dgv_vistaResultados.Rows.Count - 1;
                if (trueHeight > dgv_vistaResultados.Rows[0].Height * 10)
                {
                    dgv_vistaResultados.Size = new Size(dgv_vistaResultados.Size.Width, dgv_vistaResultados.Rows[0].Height * 10 + heightFix);
                }
                else
                {
                    dgv_vistaResultados.Size = new Size(dgv_vistaResultados.Size.Width, trueHeight + heightFix);
                }

            }
        }

        private string buildCondition()
        {
            string[] separateWords = tb_cuadroBusqueda.Text.Trim().Split(' ');
            string condition = "";
            for (int i = 0; i < separateWords.Length; i++)
            {
                condition += "Descripcion LIKE ";
                condition += "'%" + CommonStringParser.EscapeSQLQuery(separateWords[i]) + "%'";
                condition += i == separateWords.Length - 1 ? "" : " AND ";
            }
            return condition;
        }

        private void dgv_vistaResultados_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_vistaResultados.Rows.Count == 0)
            {
                this.Size = new Size(this.Width, textBoxHeight);
                return;
            }
            
            int trueHeight = dgv_vistaResultados.Rows[0].Height * dgv_vistaResultados.Rows.Count - 1;

            if (trueHeight > dgv_vistaResultados.Rows[0].Height * 10)
            {
                this.Size = new Size(this.Width, textBoxHeight + dgv_vistaResultados.Rows[0].Height * 10 + heightFix);
            }
            else
            {
                this.Size = new Size(this.Width, textBoxHeight + trueHeight + heightFix);
            }
                
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
                        SelectionMadeCall(this, Convert.ToInt32(dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["id"].Value));
                        tb_cuadroBusqueda.TextChanged -= tb_cuadroBusqueda_TextChanged;
                        tb_cuadroBusqueda.Text = dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["Descripcion"].Value.ToString();
                        tb_cuadroBusqueda.TextChanged += tb_cuadroBusqueda_TextChanged;
                        lbl_moreInfo.Visible = false;
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
                default:
                    break;
            }       
        }

        public void clearTextBox()
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
            SelectionMadeCall(this, Convert.ToInt32(dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["id"].Value));
            tb_cuadroBusqueda.Text = dgv_vistaResultados.Rows[dgv_vistaResultados.CurrentCell.RowIndex].Cells["Descripcion"].Value.ToString();
            dgv_vistaResultados.DataSource = null;
        }

    }
}
