using System;
using System.Linq;
using System.Windows.Forms;

namespace FerreteriaSL.Ventas
{
    public partial class BusquedaProductoAgregarCantidad : Form
    {
        private double _value = 1;
        private readonly double _precio;

        public double Value
        {
            get { return _value; }
        }

        public BusquedaProductoAgregarCantidad(double precio,string nombre)
        {
            InitializeComponent();
            _precio = precio;
            tb_quantity.Text = "1";
            lbl_productName.Text = nombre;
            lbl_ppuFirstVariable.Text = "1";
            lbl_ppuSecondVariable.Text = "unidad:";
            lbl_ppuThirdVariable.Text = precio.ToString("$0.00");
        }

        private void tb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char[] acceptedChars = { '\r', ',', '\b', '.' };

            //if (!Char.IsNumber(e.KeyChar) && !acceptedChars.Contains(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            //if (e.KeyChar == acceptedChars[0])
            //{
            //    btn_add.PerformClick();
            //}
            //if (e.KeyChar == acceptedChars[3])
            //{
            //    e.KeyChar = ',';
            //}

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
            else if (e.KeyChar == acceptedChars[1] || e.KeyChar == acceptedChars[3])
            {
                e.Handled = true;
            }

            if (e.KeyChar == acceptedChars[0])
            {
                btn_add.PerformClick();
            }          
            
        }

        private void BusquedaProductoAgregarCantidad_Load(object sender, EventArgs e)
        {
            tb_quantity.Focus();
            tb_quantity.SelectAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_quantity.Text.Length < 1)
            {
                tb_quantity.Select();
                DialogResult = DialogResult.None;
                return;
            }
            _value = Convert.ToDouble(tb_quantity.Text);
        }

        private void CalculateTotalPrice()
        {
            double quantity;
            if (double.TryParse(tb_quantity.Text, out quantity))
            {
                double finalPrice = _precio * quantity;
                lbl_ppuFirstVariable.Text = quantity.ToString();
                lbl_ppuSecondVariable.Text = quantity == 1 ? "unidad:" : "unidades:";
                lbl_ppuThirdVariable.Text = finalPrice.ToString("$0.00");
            }
            else
            {
                lbl_ppuFirstVariable.Text = "1";
                lbl_ppuSecondVariable.Text = "unidad:";
                lbl_ppuThirdVariable.Text = _precio.ToString("$0.00");
            }
        }

        private void tb_quantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {         
            if (e.KeyData == Keys.Up)
            {
                double input;
                if (double.TryParse(tb_quantity.Text, out input))
                {
                    input = input + 1;
                    tb_quantity.Text = input.ToString();
                    tb_quantity.SelectAll();
                }
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                double input;
                if (double.TryParse(tb_quantity.Text, out input) && input >= 1)
                {
                    input = input - 1;
                    tb_quantity.Text = input.ToString();
                    tb_quantity.SelectAll();
                }
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                double input;
                if (double.TryParse(tb_quantity.Text, out input) && input >= 0.1)
                {
                    input = input - 0.1;
                    tb_quantity.Text = input.ToString();
                    tb_quantity.SelectAll();
                }
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                double input;
                if (double.TryParse(tb_quantity.Text, out input))
                {
                    input = input + 0.1;
                    tb_quantity.Text = input.ToString();
                    tb_quantity.SelectAll();
                }
                e.Handled = true;
            }
        }

        private void BusquedaProductoAgregarCantidad_Shown(object sender, EventArgs e)
        {
            tb_quantity.Focus();
            tb_quantity.SelectAll();
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            Calculadora cal = new Calculadora(_precio);
            if (cal.ShowDialog(this) == DialogResult.OK)
            {
                tb_quantity.Text = cal.Resultado.ToString();
            }
        }
    }
}
