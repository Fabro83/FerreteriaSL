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
    public partial class Calculadora : Form
    {
        double precio;
        double resultado = -1;

        public double Resultado
        {
            get { return resultado; }
        }

        public Calculadora(double precio)
        {
            InitializeComponent();
            this.precio = precio;
            cb_type.SelectedIndex = 0;
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            gb_units.Text = cb_type.SelectedItem.ToString();
            if (cb_type.SelectedIndex == 0)
            {
                lbl_info1.Text = "El articulo contiene:";
                lbl_info2.Visible = tb_articleUnitsToSell.Visible = true;
            }
            else
            {
                lbl_info1.Text = "Precio deseado:";
                lbl_info2.Visible = tb_articleUnitsToSell.Visible = false;             
            }
            tb_articleContains.Text = "";
            tb_articleUnitsToSell.Text = "";
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox target = sender as TextBox;
            char[] acceptedChars = { '\r', ',', '\b', '.' };

            if (!Char.IsNumber(e.KeyChar) && !acceptedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((target.Text == String.Empty || target.Text == target.SelectedText) || !target.Text.Contains(','))
            {
                if (e.KeyChar == acceptedChars[1] && (target.Text == String.Empty || target.SelectedText == target.Text))
                {
                    target.Text = "0,";
                    target.Select(target.Text.Length, 0);
                    e.Handled = true;
                }

                if (e.KeyChar == acceptedChars[3])
                {
                    if (target.Text == String.Empty || target.SelectedText == target.Text)
                    {
                        target.Text = "0,";
                        e.Handled = true;
                        target.Select(target.Text.Length, 0);
                    }
                    else
                    {
                        e.KeyChar = ',';
                    }
                }
            }
            else if( e.KeyChar == acceptedChars[1] || e.KeyChar == acceptedChars[3])
            {
                e.Handled = true;
            }
           
            if (e.KeyChar == acceptedChars[0])
            {
                btn_insert.PerformClick();
            }          
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            resultado = -1;
            lbl_equivalentUnits.Text = "N/A";
            calculateUnits();
        }

        void calculateUnits()
        {
            if (cb_type.SelectedIndex == 0 && tb_articleContains.Text.Length > 0 && tb_articleUnitsToSell.Text.Length > 0)
            {
                try
                {
                    double aQuantity = double.Parse(tb_articleContains.Text);
                    double tQuantity = double.Parse(tb_articleUnitsToSell.Text);
                    double parc = (tQuantity * precio) / aQuantity;
                    resultado = parc / precio;
                    lbl_equivalentUnits.Text = resultado.ToString("0.00");
                }
                catch{}
            }
            else if(cb_type.SelectedIndex == 1 && tb_articleContains.Text.Length > 1)
            {
                try
                {
                    double tPrice = double.Parse(tb_articleContains.Text);
                    resultado = tPrice / precio;
                    lbl_equivalentUnits.Text = resultado.ToString("0.00");
                }
                catch { }
            }


        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (resultado == -1)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
        }

    }
}
