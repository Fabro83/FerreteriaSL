using System;
using System.Windows.Forms;

namespace FerreteriaSL.Proveedores
{
    public partial class AgregarNuevoProveedor : Form
    {
        public AgregarNuevoProveedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_name.Text.Trim().Length > 3;
        }

        private void generic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_add.PerformClick();
            if (e.KeyChar == '\u001B')
                btn_cancel.PerformClick();
        }
    }
}
