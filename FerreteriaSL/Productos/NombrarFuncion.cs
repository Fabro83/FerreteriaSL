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
    public partial class NombrarFuncion : Form
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
        }

        public NombrarFuncion()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = tb_nombre.Text.Trim().Length > 2;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.nombre = tb_nombre.Text.Trim();
            this.Close();
        }
    }
}
