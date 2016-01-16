using System;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class NombrarFuncion : Form
    {
        public string Nombre { get; private set; }

        public NombrarFuncion()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = tb_nombre.Text.Trim().Length > 2;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Nombre = tb_nombre.Text.Trim();
            Close();
        }
    }
}
