using System;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class AplicarPorcentaje : Form
    {
        public double Result { get; private set; }

        public AplicarPorcentaje(string mode)
        {
            Result = 0;
            InitializeComponent();
            lbl_info.Text = "Ingrese el porcentaje a " + mode + " en los articulos seleccionados.";
            Text = mode[0].ToString().ToUpper() + mode.Substring(1) + " Porcentaje";
        }

        private void nud_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Result = Convert.ToDouble(nud_percent.Value);
                btn_apply.PerformClick();
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Result = Convert.ToDouble(nud_percent.Value);
        }

    }
}
