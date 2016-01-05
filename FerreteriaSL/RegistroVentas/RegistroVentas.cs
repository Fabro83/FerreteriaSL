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
    public partial class Cajas : Form
    {
        public Cajas()
        {
            InitializeComponent();
            loadUserComboBox();
            applyFilters();
        }
        
        private void loadUserComboBox()
        {
            BD DBCon = new BD();
            cb_user.DataSource = DBCon.Read("SELECT id, user FROM usuario");
            cb_user.DisplayMember = "user";
        }

        private void dtp_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void dtp_dateTo_ValueChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void applyFilters()
        {
            BD DBCon = new BD();

            string query = "SELECT id, Fecha, Usuario,`Nº Factura`, Cliente, Importe, `Descuento Monto`, `Porcentaje Descuento`, Ganancia FROM vista_cajas WHERE ";

            query += buildFilters();

            DataTable res = DBCon.Read(query);

            double totalImporte = 0, totalDescuentos = 0, DescuentoPorcentajeTotal = 0, mediaPorcentajeDescuentos = 0, totalGanancia = 0;
            int discountRows = 0;

            foreach (DataRow sRow in res.Rows)
            {
                totalImporte += Convert.ToDouble(sRow["Importe"].ToString());
                totalDescuentos += Convert.ToDouble(sRow["Descuento Monto"].ToString());
                DescuentoPorcentajeTotal += Convert.ToDouble(sRow["Porcentaje Descuento"].ToString());
                totalGanancia += Convert.ToDouble(sRow["Ganancia"].ToString());
                if (Convert.ToDouble(sRow["Porcentaje Descuento"].ToString()) > 0)
                    discountRows++;
            }

            mediaPorcentajeDescuentos = discountRows > 0 ? DescuentoPorcentajeTotal / discountRows : 0;
            DescuentoPorcentajeTotal = res.Rows.Count > 0 ? DescuentoPorcentajeTotal / res.Rows.Count : 0;

            lbl_totalImporteValue.Text = "$" + totalImporte.ToString("0.00", CultureInfo.InvariantCulture);
            lbl_totalDescuentosValue.Text = "$" + totalDescuentos.ToString("0.00", CultureInfo.InvariantCulture);
            lbl_porcentajeTotalValue.Text = Math.Round(DescuentoPorcentajeTotal, 2, MidpointRounding.AwayFromZero).ToString("0.00", CultureInfo.InvariantCulture) + "%";
            lbl_mediaPorcentajeDescuentosValue.Text = Math.Round(mediaPorcentajeDescuentos, 2, MidpointRounding.AwayFromZero).ToString("0.00", CultureInfo.InvariantCulture) + "%";
            lbl_gananciaValue.Text = "$" + totalGanancia.ToString("0.00", CultureInfo.InvariantCulture);

            dgv_caja.DataSource = res;

            dgv_caja.Columns["id"].Visible = false;
            dgv_caja.Columns["Importe"].DefaultCellStyle.Format = "$0.00";
            dgv_caja.Columns["Descuento Monto"].DefaultCellStyle.Format = "$0.00";
            dgv_caja.Columns["Porcentaje Descuento"].DefaultCellStyle.Format = "0\\%";
            dgv_caja.Columns[3].Name = dgv_caja.Columns[3].HeaderText = "Nº Factura";
            dgv_caja.Columns["Ganancia"].DefaultCellStyle.Format = "$0.00";

        }

        private string buildFilters()
        {
            string dateFrom = dtp_dateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtp_dateTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            int user_id = cb_user.SelectedIndex > 0 ? int.Parse((cb_user.SelectedItem as DataRowView)["id"].ToString()) : -1;

            string dateFilter = "Fecha BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            string userFilter = user_id != -1 ?  "AND usuario_id = " + user_id : "";

            string fullFilter = dateFilter + userFilter;

            return fullFilter;


        }

        private void dgv_caja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_caja[4, e.RowIndex].Value.ToString() == "TOTAL")
            {
                dgv_caja.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                dgv_caja.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_caja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CajasVerFactura CVF = new CajasVerFactura(int.Parse(dgv_caja.Rows[e.RowIndex].Cells["id"].Value.ToString()),dgv_caja.Rows[e.RowIndex].Cells["Nº Factura"].Value.ToString());
                CVF.Show(this);
            }
        }

    }
}
