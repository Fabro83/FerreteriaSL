using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Caja_Diaria
{
    public partial class CajaDiaria : Form
    {
        public CajaDiaria()
        {
            InitializeComponent();
            cb_filterType.SelectedIndex = 0;
            LoadMoneyValues();
        }


        #region Tab Resumen


        private void tp_resumen_Enter(object sender, EventArgs e)
        {
            LoadBalanceInfo();
            CalculateDifference();
        }

        void CalculateDifference()
        {
            double totalCaja = double.Parse(lbl_totalEnCajaValue.Text.Replace("$",""));
            double totalMoneda = double.Parse(lbl_moneyValuesTotalValue.Text.Replace("$", ""));
            lbl_moneyValuesDiferenceValue.Text = (totalMoneda - totalCaja).ToString("$0.00");
        }

        void LoadBalanceInfo()
        {
            Bd dbCon = new Bd();
            DataTable cajas = dbCon.Read("SELECT Fecha,Monto FROM vista_cajasporturno WHERE CAST(Fecha as date) = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ORDER BY Fecha");
            foreach (DataRow sRow in cajas.Rows)
            {
                DateTime fecha = DateTime.Parse(sRow["Fecha"].ToString());
                if (fecha.Hour < 15)
                {
                    lbl_cajaTurnoMananaValue.Text = Convert.ToDouble(sRow["Monto"]).ToString("$0.00");
                }
                else
                {
                    lbl_cajaTurnoTardeValue.Text = Convert.ToDouble(sRow["Monto"]).ToString("$0.00");
                }
            }

            DataTable total = dbCon.Read("SELECT valor FROM caja_registro_total ORDER BY fecha DESC LIMIT 1");

            if(total.Rows.Count > 0)
            {
                double totalDelDia = Convert.ToDouble(total.Rows[0]["valor"]);
                lbl_totalEnCajaValue.Text = totalDelDia.ToString("$0.00");
            }          
        }

        void LoadMoneyValues()
        {           
            Bd dbCon = new Bd();
            dgv_moneyValues.DataSource = dbCon.Read("SELECT * FROM caja_valores");
            dgv_moneyValues.Columns["id"].Visible = false;
            dgv_moneyValues.Columns["name"].ReadOnly = true;
            dgv_moneyValues.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_moneyValues.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;         
            MoneyValuesCalculateTotal();
            dgv_moneyValues.CellValueChanged += dgv_moneyValues_CellValueChanged;
            dgv_moneyValues.DataError += dgv_moneyValues_DataError;
        }

        void dgv_moneyValues_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Solo se permite el ingreso de números.", "Fomato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dgv_moneyValues.CancelEdit();
        }

        private void dgv_moneyValues_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Bd dbCon = new Bd();
            double id = double.Parse(dgv_moneyValues["id", e.RowIndex].Value.ToString());
            int quantity = int.Parse(dgv_moneyValues["quantity", e.RowIndex].Value.ToString());
            string query = "UPDATE caja_valores SET quantity = {0} WHERE id = {1}";
            dbCon.Write(String.Format(query, quantity, id.ToString().Replace(",",".")));
            MoneyValuesCalculateTotal();
            CalculateDifference();
        }

        private void MoneyValuesCalculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow sRow in dgv_moneyValues.Rows)
            {
                total += Convert.ToDouble(sRow.Cells["id"].Value) * Convert.ToDouble(sRow.Cells["quantity"].Value);
            }
            lbl_moneyValuesTotalValue.Text = total.ToString("$0.00");
        }

        #endregion

        #region Tab Detalles

        private void RefreshDataGrid()
        {
            string typeCondition = cb_filterType.SelectedIndex != 0 ? "Tipo = " + (cb_filterType.SelectedIndex - 1) : "";
            string dateCondition;
            if (rb_singleDay.Checked)
            {
                dateCondition = String.Format("Fecha BETWEEN '{0} 00:00:00' AND '{0} 23:59:59'", dtp_singleDay.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                dateCondition = String.Format("Fecha BETWEEN '{0} 00:00:00' AND '{1} 23:59:59'", dtp_dateFrom.Value.ToString("yyyy-MM-dd"), dtp_dateTo.Value.ToString("yyyy-MM-dd"));
            }

            string fullCondition = typeCondition == "" ? dateCondition : typeCondition + " AND " + dateCondition;

            Bd dbCon = new Bd();
            dgv_caja.DataSource = dbCon.Read("SELECT * FROM vista_cajadiaria WHERE " + fullCondition + " ORDER BY Fecha");
        }

        private void rb_singleDay_CheckedChanged(object sender, EventArgs e)
        {
            dtp_singleDay.Enabled = rb_singleDay.Checked;
            RefreshDataGrid();
        }

        private void rb_dateRage_CheckedChanged(object sender, EventArgs e)
        {
            dtp_dateFrom.Enabled = dtp_dateTo.Enabled = rb_dateRage.Checked;
            RefreshDataGrid();
        }

        private void dgv_caja_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_caja.DataSource != null)
            {
                dgv_caja.Columns["Tipo"].Visible = false;
                dgv_caja.Columns["Monto"].DefaultCellStyle.Format = "$0.00";
            }
        }

        private void cb_filterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dtp_generic_ValueChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_caja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (int.Parse(dgv_caja["Tipo", e.RowIndex].Value.ToString()) == 0)
            {

                dgv_caja.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
            }
            else
            {
                dgv_caja.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }

        #endregion

        




    }
}
