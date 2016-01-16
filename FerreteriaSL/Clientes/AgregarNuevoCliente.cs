using System;
using System.Windows.Forms;

namespace FerreteriaSL.Clientes
{
    public partial class AgregarNuevoCliente : Form
    {
        public AgregarNuevoCliente()
        {
            InitializeComponent();
        }

        private void tb_firstName_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_firstName.Text.Trim().Length > 3 && tb_lastName.Text.Trim().Length > 3;
        }

        private void tb_lastName_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_firstName.Text.Trim().Length > 3 && tb_lastName.Text.Trim().Length > 3;
        }

        private void tb_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_add.PerformClick();
        }

        private void tb_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_add.PerformClick();
        }
    }
}
