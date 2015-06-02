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
    public partial class ConfirmacionVenta : Form
    {
        double monto;
        double vuelto;

        public ConfirmacionVenta(double monto)
        {
            InitializeComponent();
            this.monto = monto;
            setValues();
        }

        private void setValues()
        {
            lbl_totalMonto.Text = "$"+monto.ToString();
        }

        private void tb_pagaConMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == '\b'))
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                else if(e.KeyChar == '\r')
                {
                    btn_finalizar.Focus();
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }             
            }       
        }

        private void tb_pagaConMonto_TextChanged(object sender, EventArgs e)
        {
            double pagaCon = 0;
            if (double.TryParse(tb_pagaConMonto.Text, out pagaCon) && pagaCon > monto)
            {
                vuelto = Math.Round(pagaCon - monto, 2, MidpointRounding.AwayFromZero);
                lbl_vueltoMonto.Text = "$" + vuelto.ToString();
            }
            else
            {
                lbl_vueltoMonto.Text = "$0,00";
            }
        }

    }
}
