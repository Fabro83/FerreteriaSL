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
    public partial class Inicio : Form
    {

        MainWindow MDIContainer;

        public Inicio(MainWindow MDIContainer)
        {
            InitializeComponent();

#if DEBUG
            usuario.Text = "afliw";
            contraseña.Text = "1234";
#endif

            this.MDIContainer = MDIContainer;
        }

        private void btn_inicioEntrar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            if (!fieldValidation())
            {
                return;
            }

            int result = BD_Functions.Login(usuario.Text.Trim(), contraseña.Text.Trim());

            switch (result)
            {                 
                case 11:
                    showAlertMessage("El usuario ingresado no existe.");
                    usuario.Focus();
                    usuario.SelectAll();
                    break;
                case 12:
                    showAlertMessage("La contraseña ingresada es incorrecta.");
                    contraseña.Focus();
                    contraseña.SelectAll();
                    break;
                default:
                    this.Close();
                    break;
            }
        }


        private void showAlertMessage(string msg)
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

        private bool fieldValidation()
        {
            if (usuario.Text == "")
            {
                showAlertMessage("Debe ingresar su usuario.");
                usuario.Focus();
                return false;
            }
            else if (contraseña.Text == "")
            {
                showAlertMessage("Debe ingresar su contraseña.");
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
