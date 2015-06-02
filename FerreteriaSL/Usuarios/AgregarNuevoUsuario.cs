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
    public partial class AgregarNuevoUsuario : Form
    {
        public AgregarNuevoUsuario()
        {
            InitializeComponent();
        }

        private void tb_userName_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_userName.Text.Trim().Length > 3 && tb_userPassword.Text.Trim().Length > 3;
        }

        private void tb_userPassword_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_userName.Text.Trim().Length > 3 && tb_userPassword.Text.Trim().Length > 3;
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
