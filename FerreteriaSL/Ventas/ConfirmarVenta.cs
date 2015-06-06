using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public partial class ConfirmacionVenta : Form
    {
        readonly double _monto;
        double _vuelto;
        private DataTable _productosTable;

        public ConfirmacionVenta(double monto, DataTable productosIngresadosTable)
        {
            InitializeComponent();
            this._monto = monto;
            SetValues();
            _productosTable = productosIngresadosTable;
        }

        private void SetValues()
        {
            lbl_totalMonto.Text = "$"+_monto;
        }

        private void tb_pagaConMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '\b') return;
            switch (e.KeyChar)
            {
                case '.':
                    e.KeyChar = ',';
                    break;
                case '\r':
                    btn_finalizar.Focus();
                    e.Handled = true;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void tb_pagaConMonto_TextChanged(object sender, EventArgs e)
        {
            double pagaCon = 0;
            if (double.TryParse(tb_pagaConMonto.Text, out pagaCon) && pagaCon > _monto)
            {
                _vuelto = Math.Round(pagaCon - _monto, 2, MidpointRounding.AwayFromZero);
                lbl_vueltoMonto.Text = "$" + _vuelto;
            }
            else
            {
                lbl_vueltoMonto.Text = "$0,00";
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            FacturaA facturaA = new FacturaA();
            if (facturaA.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, object> fieldsDictionary = new Dictionary<string, object>();
                fieldsDictionary.Add("nombre", facturaA.txb_nombre.Text);
                fieldsDictionary.Add("domicilio", facturaA.txb_domicilio.Text);
                fieldsDictionary.Add("iva", facturaA.txb_iva.Text);
                fieldsDictionary.Add("cuit", facturaA.txb_cuit.Text);
                fieldsDictionary.Add("condiciones", facturaA.txb_condiciones.Text);
                fieldsDictionary.Add("impuestos", facturaA.txb_impuestos.Text);
                fieldsDictionary.Add("subtotal2", facturaA.txb_subtotal2.Text);
                fieldsDictionary.Add("subtotal", string.Format("${0:N2}", Math.Truncate((_monto / 1.21) * 100) / 100));
                fieldsDictionary.Add("ivainscripto", string.Format("${0:N2}", Math.Truncate((_monto * 0.21) * 100) / 100));
                fieldsDictionary.Add("total", string.Format("${0:N2}", Math.Truncate(_monto * 100) / 100));

                List<Dictionary<string, object>> gridList = new List<Dictionary<string, object>>();

                foreach (DataRow dataRow in _productosTable.Rows)
                {
                    Dictionary<string, object> gridRowDictionary = new Dictionary<string, object>();

                    for (int i = 0; i < _productosTable.Columns.Count; i++)
                    {
                        string columnName = _productosTable.Columns[i].ColumnName;
                        if (columnName.Contains("precio"))
                        {
                            gridRowDictionary.Add(columnName, string.Format("${0:N2}", float.Parse(dataRow[i].ToString())));
                        }
                        else
                        {
                            gridRowDictionary.Add(columnName, dataRow[i]);
                        }

                    }

                    gridList.Add(gridRowDictionary);
                }

                Impresion objImpresion = new Impresion(fieldsDictionary, gridList, "facturaA");
                objImpresion.StartPrinting();
            }


            
        }

    }
}
