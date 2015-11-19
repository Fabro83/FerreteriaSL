using System;
using System.Windows.Forms;

namespace FerreteriaSL.Productos
{
    public partial class NombrarFuncion : Form
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }

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
            _nombre = tb_nombre.Text.Trim();
            Close();
        }
    }
}
