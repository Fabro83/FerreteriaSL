using System;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL
{
    public partial class Inicio : Form
    {

        MainWindow _mdiContainer;

        public Inicio(MainWindow mdiContainer)
        {
            InitializeComponent();

#if DEBUG
            usuario.Text = "afliw";
            contraseña.Text = "1234";
#endif

            _mdiContainer = mdiContainer;
        }

        private void btn_inicioEntrar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            if (!FieldValidation())
            {
                return;
            }

            int result = BdFunctions.Login(usuario.Text.Trim(), contraseña.Text.Trim());

            switch (result)
            {                 
                case 11:
                    ShowAlertMessage("El usuario ingresado no existe.");
                    usuario.Focus();
                    usuario.SelectAll();
                    break;
                case 12:
                    ShowAlertMessage("La contraseña ingresada es incorrecta.");
                    contraseña.Focus();
                    contraseña.SelectAll();
                    break;
                default:
                    Close();
                    break;
            }
        }


        private void ShowAlertMessage(string msg)
        {
            lbl_inicioAlerta.Text = msg;
            lbl_inicioAlerta.Visible = true;
        }

        
        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                Ingresar();
            }
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                Ingresar();
            }

        }

        private bool FieldValidation()
        {
            if (usuario.Text == "")
            {
                ShowAlertMessage("Debe ingresar su usuario.");
                usuario.Focus();
                return false;
            }
            else if (contraseña.Text == "")
            {
                ShowAlertMessage("Debe ingresar su contraseña.");
                contraseña.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_inicioSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
