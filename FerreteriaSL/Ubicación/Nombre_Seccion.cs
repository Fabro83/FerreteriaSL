using System;
using System.Windows.Forms;

namespace FerreteriaSL.Ubicación
{
    public partial class NombreSeccion : Form
    {
        public NombreSeccion()
        {
            InitializeComponent();
        }

        private void txb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_ok.PerformClick();
            if (e.KeyChar == (char)27)
                btn_cancel.PerformClick();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txb_abb.Text.Length < 1 || txb_abb.Text.Length > 4 || txb_name.Text.Length < 3)
            {
                MessageBox.Show("El nombre de la nueva sección debe ser de 3 caracteres o más, y su abreviación debe ser de 1 a 3 caracteres. Verifique los datos introducidos.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
