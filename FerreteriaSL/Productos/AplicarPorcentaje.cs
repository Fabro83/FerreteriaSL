using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public partial class AplicarPorcentaje : Form
    {
        double result = 0;

        public double Result
        {
            get { return result; }
        }

        public AplicarPorcentaje(string mode)
        {
            InitializeComponent();
            lbl_info.Text = "Ingrese el porcentaje a " + mode + " en los articulos seleccionados.";
            this.Text = mode[0].ToString().ToUpper() + mode.Substring(1) + " Porcentaje";
        }

        private void nud_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                result = Convert.ToDouble(nud_percent.Value);
                btn_apply.PerformClick();
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(nud_percent.Value);
        }

    }
}
