﻿using System;
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
    public partial class EmpleadosVerPagos : Form
    {
        int windowHeightFill;

        public EmpleadosVerPagos(int emp_id, string emp_nombre)
        {
            InitializeComponent();
            windowHeightFill = GetOSFriendlyName().Contains("XP") ? 56 : 58;
            loadDataGrid(emp_id);        
            this.Text = "Pagos a " + emp_nombre;
        }

        private void loadDataGrid(int emp_id)
        {
            BD DBCon = new BD();
            DataTable res = DBCon.Read("SELECT fecha_pago as Fecha,año as ano, type_mes.mes as Mes, monto as Monto, observacion as obs,empleado_pago.mes as ocultar "+
                                       "FROM empleado_pago LEFT JOIN type_mes ON empleado_pago.mes = type_mes.id WHERE empleado_id = " + emp_id + 
                                       " ORDER BY ano, empleado_pago.mes, empleado_pago.id");
            dgv_pagos.DataSource = res;
            dgv_pagos.Columns["Monto"].DefaultCellStyle.Format = "$0.00";
            dgv_pagos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_pagos.Columns["ano"].HeaderText = "Año";
            dgv_pagos.Columns["obs"].HeaderText = "Observación";
            dgv_pagos.Columns["ocultar"].Visible = false;
            foreach (DataGridViewColumn sColumn in dgv_pagos.Columns)
            {
                if (sColumn.Name != "obs")
                {
                    sColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            dgv_pagos.ScrollBars = ScrollBars.None;
            this.Height = windowHeightFill + dgv_pagos.ColumnHeadersHeight + (dgv_pagos.Rows.Count * dgv_pagos.RowTemplate.Height);

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