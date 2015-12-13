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
    public partial class AgregarNuevoEmpleado : Form
    {
        public AgregarNuevoEmpleado()
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
