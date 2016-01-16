using System;
using System.Data;
using System.Management;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.RegistroVentas
{
    public partial class CajasVerFactura : Form
    {
        int _windowHeightFill;

        public CajasVerFactura(int ventasCajaId,string numeroFactura)
        {
            InitializeComponent();
            _windowHeightFill = GetOsFriendlyName().Contains("XP") ? 56 : 58;
            LoadDataGrid(ventasCajaId);        
            Text = "Factura " + numeroFactura;
        }

        private void LoadDataGrid(int ventasCajaId)
        {
            Bd dbCon = new Bd();
            DataTable res = dbCon.Read("SELECT Proveedor,Codigo,Articulo,Cantidad,`Precio Unitario`,`Precio Total` FROM vista_factura WHERE ventas_caja_id = " + ventasCajaId);
            dgv_factura.DataSource = res;
            dgv_factura.Columns["Precio Unitario"].DefaultCellStyle.Format = "$0.00";
            dgv_factura.Columns["Precio Total"].DefaultCellStyle.Format = "$0.00";
            foreach (DataGridViewColumn sColumn in dgv_factura.Columns)
            {
                if (sColumn.Name != "Articulo")
                {
                    sColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            dgv_factura.ScrollBars = ScrollBars.None;
            Height = _windowHeightFill + dgv_factura.ColumnHeadersHeight + (dgv_factura.Rows.Count * dgv_factura.RowTemplate.Height);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string GetOsFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

    }
}
