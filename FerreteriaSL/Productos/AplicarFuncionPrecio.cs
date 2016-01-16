using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Productos
{
    public partial class AplicarFuncionPrecio : Form
    {
        string _precioOrigen, _precioDestino, _columnPrecioOrigen, _columnPrecioDestino;
        double _precioDeMuestra;
        BackgroundWorker _bgw;

        public string Query { get; private set; }

        public int Result { get; private set; }

        public DataGridViewSelectedRowCollection TargetRows { get; private set; }

        public AplicarFuncionPrecio(DataGridViewSelectedRowCollection targetRows,string tipoPrecio)
        {
            Result = 0;
            InitializeComponent();
            TargetRows = targetRows;
            _precioOrigen = tipoPrecio;
            _precioDestino = tipoPrecio.Contains("Venta") ? "Precio de Compra" : "Precio de Venta";
            _precioDeMuestra = double.Parse(targetRows[targetRows.Count - 1].Cells[_precioOrigen].Value.ToString());
            Inicializar();
        }

        public AplicarFuncionPrecio(string tipoPrecio,double precioMuestra)
        {
            Result = 0;
            InitializeComponent();
            _columnPrecioOrigen = tipoPrecio;
            _columnPrecioDestino = tipoPrecio.Contains("venta") ? "precio_compra" : "precio_venta";
            _precioOrigen = tipoPrecio.Contains("venta") ? "Precio de Venta" : "Precio de Compra";
            _precioDestino = tipoPrecio.Contains("venta") ? "Precio de Compra" : "Precio de Venta";
            _precioDeMuestra = precioMuestra;
            Inicializar();
        }

        private void Inicializar()
        {
            lbl_precioOrigen.Text = _precioOrigen + ": " + _precioDeMuestra.ToString("0.00",CultureInfo.InvariantCulture);
            lbl_precioDestino.Text = _precioDestino + ": ";
            lbl_precioDestinoValor.Location = new Point(lbl_precioDestino.Width + lbl_precioDestino.Location.X - 8, lbl_precioDestino.Location.Y);
            Text = "Aplicar Función | " + _precioOrigen + " > " + _precioDestino;
            CargarComboBoxFunciones();          
        }

        private void CargarComboBoxFunciones()
        {
            int selectedIndex = cb_funcionesGuardas.SelectedIndex != -1 ? cb_funcionesGuardas.SelectedIndex : 0;

            Bd dbCon = new Bd();
            DataTable providerTable = dbCon.Read("SELECT id, CONCAT(`name`,\": [\",`function`,\"]\") as nombre, function FROM funcion");
            DataRow defaultRow = providerTable.NewRow();
            defaultRow[0] = "-1";
            defaultRow[1] = "Funciones Guardadas";
            defaultRow[2] = "";
            providerTable.Rows.Add(defaultRow);
            providerTable.DefaultView.Sort = "id asc";
            cb_funcionesGuardas.DataSource = providerTable;
            cb_funcionesGuardas.DisplayMember = "nombre";
            cb_funcionesGuardas.SelectedIndex = selectedIndex > cb_funcionesGuardas.Items.Count - 1 ? 0 : selectedIndex;           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProbarFuncion()
        {
            string funcion = tb_funcion.Text.Trim();
            funcion = funcion.Replace("?P", _precioDeMuestra.ToString("0.00", CultureInfo.InvariantCulture));
            string result = BdFunctions.TestFunction(funcion);
            double value = -1.00;
            try
            {
                value = double.Parse(result);
                result = value.ToString("0.00", CultureInfo.InvariantCulture);
                lbl_precioDestinoValor.ForeColor = Color.Black;
                btn_aplicar.Enabled = true;
            }
            catch (Exception e)
            {
                result = "Hay un error de sintaxis en la función.";
                lbl_precioDestinoValor.ForeColor = Color.DarkRed;
                btn_aplicar.Enabled = false;
            }
            lbl_precioDestinoValor.Text = result;
        }

        private void btn_probarFuncion_Click(object sender, EventArgs e)
        {
            if(tb_funcion.Text != "")
                ProbarFuncion();
        }

        private void btn_insertarFuncion_Click(object sender, EventArgs e)
        {
            tb_funcion.Text = (cb_funcionesGuardas.SelectedItem as DataRowView)[2].ToString();
        }

        private void cb_funcionesGuardas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_cargarFuncion.Enabled = btn_eliminarFuncion.Enabled = cb_funcionesGuardas.SelectedIndex != 0;
        }

        private void tb_funcion_TextChanged(object sender, EventArgs e)
        {
            btn_probarFuncion.Enabled = btn_guardar.Enabled = tb_funcion.Text.Length > 0;
            btn_aplicar.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            NombrarFuncion nf = new NombrarFuncion();
            nf.ShowDialog(this);
            if (nf.Nombre != null)
            {
                Bd dbCon = new Bd();
                int result = dbCon.Write(String.Format("INSERT INTO funcion (name,function) VALUES ('{0}','{1}')",nf.Nombre,tb_funcion.Text.Trim()));
                if (result == 1)
                {
                    MessageBox.Show("La función fue guardada correctamente.","Función",MessageBoxButtons.OK);
                    CargarComboBoxFunciones();
                }
            }
        }

        private void btn_eliminarFuncion_Click(object sender, EventArgs e)
        {
            string nombreFuncion = (cb_funcionesGuardas.SelectedItem as DataRowView)[1].ToString();
            
            if (MessageBox.Show(this, "¿Desea eliminar la función guardada \"" + nombreFuncion + "\"?", "Eliminar Función", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int id = int.Parse((cb_funcionesGuardas.SelectedItem as DataRowView)[0].ToString());
                Bd dbCon = new Bd();
                dbCon.Write("DELETE FROM funcion WHERE id = " + id);
                MessageBox.Show(this, "\"" + nombreFuncion + "\" fue eliminada.", "Eliminar Función", MessageBoxButtons.OK);
                CargarComboBoxFunciones();
            }
            

        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            if (TargetRows == null)
            {
                Query = String.Format("{0} = {1}",_columnPrecioDestino, tb_funcion.Text.Trim().Replace("?P", _columnPrecioOrigen));
                Close();
            }
            else
            {
                _bgw = new BackgroundWorker();
                _bgw.DoWork += BGW_DoWork;
                _bgw.RunWorkerCompleted += BGW_RunWorkerCompleted;
                _bgw.WorkerReportsProgress = true;
                _bgw.ProgressChanged += BGW_ProgressChanged;
                Size = new Size(Size.Width, 280);
                pb_aplicarFormula.Value = 0;
                pb_aplicarFormula.Maximum = 100;
                btn_aplicar.Enabled = btn_ayuda.Enabled = btn_cancelar.Enabled = btn_cargarFuncion.Enabled = btn_eliminarFuncion.Enabled = btn_guardar.Enabled = btn_probarFuncion.Enabled = false;
                _bgw.RunWorkerAsync();
            }      
        }

        void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_aplicarFormula.Value = e.ProgressPercentage;
        }

        void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            string funcion = tb_funcion.Text.Trim();
            int rowCounter = 0;
            foreach (DataGridViewRow singleRow in TargetRows)
            {
                string fullFuncion = funcion.Replace("?P", double.Parse(singleRow.Cells[_precioOrigen].Value.ToString()).ToString("0.00", CultureInfo.InvariantCulture));
                string result = BdFunctions.TestFunction(fullFuncion);
                singleRow.Cells[_precioDestino].Value = Math.Round(double.Parse(result), 2);
                rowCounter++;
                _bgw.ReportProgress((rowCounter * 100) / TargetRows.Count);
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Size currentSize = Size;

            if (currentSize.Width == 390)
            {
                Size = new Size(620, 260);
                btn_ayuda.Text = "<";
            }
            else
            {            
                Size = new Size(390, 260);
                btn_ayuda.Text = "?";
            }
        }

    }
}
