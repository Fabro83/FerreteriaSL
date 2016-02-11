using System;
using System.Windows.Forms;

namespace FerreteriaSL.Empleados
{
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
            nud_yearToPay.Value = DateTime.Now.Year;
            cb_monthToPay.SelectedIndex = DateTime.Now.Month-1;
        }

        private void cb_monthToPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void nud_yearToPay_ValueChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void nud_mountToPay_ValueChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void validate()
        {
            btn_register.Enabled = cb_monthToPay.SelectedIndex != -1 && nud_yearToPay.Value > 1900 && nud_mountToPay.Value > 0;
        }

        private void nud_mountToPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            generic_KeyPress(this, e);
        }

        private void generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_register.PerformClick();
            if (e.KeyChar == '\u001B')
                btn_cancel.PerformClick();
        }
    }
}
