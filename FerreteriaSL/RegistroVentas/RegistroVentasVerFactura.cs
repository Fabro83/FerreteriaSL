using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace FerreteriaSL
{
    public partial class CajasVerFactura : Form
    {
        int windowHeightFill;

        public CajasVerFactura(int ventas_caja_id,string numero_factura)
        {
            InitializeComponent();
            windowHeightFill = GetOSFriendlyName().Contains("XP") ? 56 : 58;
            loadDataGrid(ventas_caja_id);        
            this.Text = "Factura " + numero_factura;
        }

        private void loadDataGrid(int ventas_caja_id)
        {
            BD DBCon = new BD();
            DataTable res = DBCon.Read("SELECT Proveedor,Codigo,Articulo,Cantidad,`Precio Unitario`,`Precio Total` FROM vista_factura WHERE ventas_caja_id = " + ventas_caja_id);
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
            this.Height = windowHeightFill + dgv_factura.ColumnHeadersHeight + (dgv_factura.Rows.Count * dgv_factura.RowTemplate.Height);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetOSFriendlyName()
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
