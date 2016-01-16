using System;
using System.Data;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Empleados
{
    public partial class EmpleadosVerPagos : Form
    {
        readonly int _windowHeightFill;

        public EmpleadosVerPagos(int empId, string empNombre)
        {
            InitializeComponent();
            _windowHeightFill = GetOsFriendlyName().Contains("XP") ? 56 : 58;
            LoadDataGrid(empId);        
            Text = @"Pagos a " + empNombre;
        }

        private void LoadDataGrid(int empId)
        {
            Bd dbCon = new Bd();
            DataTable res = dbCon.Read("SELECT fecha_pago as Fecha,año as ano, type_mes.mes as Mes, monto as Monto, observacion as obs,empleado_pago.mes as ocultar "+
                                       "FROM empleado_pago LEFT JOIN type_mes ON empleado_pago.mes = type_mes.id WHERE empleado_id = " + empId + 
                                       " ORDER BY ano, empleado_pago.mes, empleado_pago.id");
            dgv_pagos.DataSource = res;
            dgv_pagos.Columns["Monto"].DefaultCellStyle.Format = "$0.00";
            dgv_pagos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_pagos.Columns["ano"].HeaderText = "Año";
            dgv_pagos.Columns["obs"].HeaderText = "Observación";
            dgv_pagos.Columns["ocultar"].Visible = false;
            foreach (var sColumn in dgv_pagos.Columns.Cast<DataGridViewColumn>().Where(sColumn => sColumn.Name != "obs"))
            {
                sColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dgv_pagos.ScrollBars = ScrollBars.None;
            Height = _windowHeightFill + dgv_pagos.ColumnHeadersHeight + (dgv_pagos.Rows.Count * dgv_pagos.RowTemplate.Height);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string GetOsFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (var o in searcher.Get())
            {
                var os = (ManagementObject) o;
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

    }
}
