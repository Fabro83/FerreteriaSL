using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.RegistroVentas
{
    public partial class Cajas : Form
    {
        public Cajas()
        {
            InitializeComponent();
            LoadUserComboBox();
            ApplyFilters();
        }
        
        private void LoadUserComboBox()
        {
            Bd dbCon = new Bd();
            cb_user.DataSource = dbCon.Read("SELECT id, user FROM usuario");
            cb_user.DisplayMember = "user";
        }

        private void dtp_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dtp_dateTo_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            Bd dbCon = new Bd();

            string query = "SELECT id, Fecha, Usuario,`Nº Factura`, Cliente, Importe, `Descuento Monto`, `Porcentaje Descuento`, Ganancia FROM vista_cajas WHERE ";

            query += BuildFilters();

            DataTable res = dbCon.Read(query);

            double totalImporte = 0, totalDescuentos = 0, descuentoPorcentajeTotal = 0, totalGanancia = 0;
            int discountRows = 0;

            foreach (DataRow sRow in res.Rows)
            {
                totalImporte += Convert.ToDouble(sRow["Importe"].ToString());
                totalDescuentos += Convert.ToDouble(sRow["Descuento Monto"].ToString());
                descuentoPorcentajeTotal += Convert.ToDouble(sRow["Porcentaje Descuento"].ToString());
                totalGanancia += Convert.ToDouble(sRow["Ganancia"].ToString());
                if (Convert.ToDouble(sRow["Porcentaje Descuento"].ToString()) > 0)
                    discountRows++;
            }

            var mediaPorcentajeDescuentos = discountRows > 0 ? descuentoPorcentajeTotal / discountRows : 0;
            descuentoPorcentajeTotal = res.Rows.Count > 0 ? descuentoPorcentajeTotal / res.Rows.Count : 0;

            lbl_totalImporteValue.Text = "$" + totalImporte.ToString("0.00", CultureInfo.InvariantCulture);
            lbl_totalDescuentosValue.Text = "$" + totalDescuentos.ToString("0.00", CultureInfo.InvariantCulture);
            lbl_porcentajeTotalValue.Text = Math.Round(descuentoPorcentajeTotal, 2, MidpointRounding.AwayFromZero).ToString("0.00", CultureInfo.InvariantCulture) + "%";
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

        private string BuildFilters()
        {
            string dateFrom = dtp_dateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtp_dateTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            int userId = cb_user.SelectedIndex > 0 ? int.Parse((cb_user.SelectedItem as DataRowView)["id"].ToString()) : -1;

            string dateFilter = "Fecha BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            string userFilter = userId != -1 ?  "AND usuario_id = " + userId : "";

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
            Close();
        }

        private void dgv_caja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CajasVerFactura cvf = new CajasVerFactura(int.Parse(dgv_caja.Rows[e.RowIndex].Cells["id"].Value.ToString()),dgv_caja.Rows[e.RowIndex].Cells["Nº Factura"].Value.ToString());
                cvf.Show(this);
            }
        }

    }
}
