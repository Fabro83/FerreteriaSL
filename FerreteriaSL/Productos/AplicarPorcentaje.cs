using System;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class AplicarPorcentaje : Form
    {
        double _result;

        public double Result
        {
            get { return _result; }
        }

        public AplicarPorcentaje(string mode)
        {
            InitializeComponent();
            lbl_info.Text = @"Ingrese el porcentaje a " + mode + @" en los articulos seleccionados.";
            Text = mode[0].ToString().ToUpper() + mode.Substring(1) + @" Porcentaje";
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void nud_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _result = Convert.ToDouble(nud_percent.Value);
                btn_apply.PerformClick();
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDouble(nud_percent.Value);
        }

    }
}
