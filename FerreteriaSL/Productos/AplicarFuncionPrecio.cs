using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace FerreteriaSL
{
    public partial class AplicarFuncionPrecio : Form
    {
        DataGridViewSelectedRowCollection targetRows;
        string precioOrigen, precioDestino, columnPrecioOrigen, columnPrecioDestino;
        double precioDeMuestra;
        int result = 0;
        BackgroundWorker BGW;
        string query;

        public string Query
        {
            get { return query; }
        }

        public int Result
        {
            get { return result; }
        }

        public DataGridViewSelectedRowCollection TargetRows
        {
            get { return targetRows; }
        }

        public AplicarFuncionPrecio(DataGridViewSelectedRowCollection targetRows,string tipoPrecio)
        {
            InitializeComponent();
            this.targetRows = targetRows;
            this.precioOrigen = tipoPrecio;
            this.precioDestino = tipoPrecio.Contains("Venta") ? "Precio de Compra" : "Precio de Venta";
            this.precioDeMuestra = double.Parse(targetRows[targetRows.Count - 1].Cells[precioOrigen].Value.ToString());
            inicializar();
        }

        public AplicarFuncionPrecio(string tipoPrecio,double precioMuestra)
        {
            InitializeComponent();
            this.columnPrecioOrigen = tipoPrecio;
            this.columnPrecioDestino = tipoPrecio.Contains("venta") ? "precio_compra" : "precio_venta";
            this.precioOrigen = tipoPrecio.Contains("venta") ? "Precio de Venta" : "Precio de Compra";
            this.precioDestino = tipoPrecio.Contains("venta") ? "Precio de Compra" : "Precio de Venta";
            this.precioDeMuestra = precioMuestra;
            inicializar();
        }

        private void inicializar()
        {
            lbl_precioOrigen.Text = precioOrigen + ": " + precioDeMuestra.ToString("0.00",CultureInfo.InvariantCulture);
            lbl_precioDestino.Text = precioDestino + ": ";
            lbl_precioDestinoValor.Location = new Point(lbl_precioDestino.Width + lbl_precioDestino.Location.X - 8, lbl_precioDestino.Location.Y);
            this.Text = "Aplicar Función | " + this.precioOrigen + " > " + this.precioDestino;
            cargarComboBoxFunciones();          
        }

        private void cargarComboBoxFunciones()
        {
            int selectedIndex = cb_funcionesGuardas.SelectedIndex != -1 ? cb_funcionesGuardas.SelectedIndex : 0;

            BD DBCon = new BD();
            DataTable ProviderTable = DBCon.Read("SELECT id, CONCAT(`name`,\": [\",`function`,\"]\") as nombre, function FROM funcion");
            DataRow defaultRow = ProviderTable.NewRow();
            defaultRow[0] = "-1";
            defaultRow[1] = "Funciones Guardadas";
            defaultRow[2] = "";
            ProviderTable.Rows.Add(defaultRow);
            ProviderTable.DefaultView.Sort = "id asc";
            cb_funcionesGuardas.DataSource = ProviderTable;
            cb_funcionesGuardas.DisplayMember = "nombre";
            cb_funcionesGuardas.SelectedIndex = selectedIndex > cb_funcionesGuardas.Items.Count - 1 ? 0 : selectedIndex;           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void probarFuncion()
        {
            string funcion = tb_funcion.Text.Trim();
            funcion = funcion.Replace("?P", precioDeMuestra.ToString("0.00", CultureInfo.InvariantCulture));
            string result = BD_Functions.testFunction(funcion);
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
                probarFuncion();
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
            NombrarFuncion NF = new NombrarFuncion();
            NF.ShowDialog(this);
            if (NF.Nombre != null)
            {
                BD DBCon = new BD();
                int result = DBCon.Write(String.Format("INSERT INTO funcion (name,function) VALUES ('{0}','{1}')",NF.Nombre,tb_funcion.Text.Trim()));
                if (result == 1)
                {
                    MessageBox.Show("La función fue guardada correctamente.","Función",MessageBoxButtons.OK);
                    cargarComboBoxFunciones();
                }
            }
        }

        private void btn_eliminarFuncion_Click(object sender, EventArgs e)
        {
            string nombreFuncion = (cb_funcionesGuardas.SelectedItem as DataRowView)[1].ToString();
            
            if (MessageBox.Show(this, "¿Desea eliminar la función guardada \"" + nombreFuncion + "\"?", "Eliminar Función", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int id = int.Parse((cb_funcionesGuardas.SelectedItem as DataRowView)[0].ToString());
                BD DBCon = new BD();
                DBCon.Write("DELETE FROM funcion WHERE id = " + id);
                MessageBox.Show(this, "\"" + nombreFuncion + "\" fue eliminada.", "Eliminar Función", MessageBoxButtons.OK);
                cargarComboBoxFunciones();
            }
            

        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            if (targetRows == null)
            {
                this.query = String.Format("{0} = {1}",this.columnPrecioDestino, tb_funcion.Text.Trim().Replace("?P", this.columnPrecioOrigen));
                this.Close();
            }
            else
            {
                BGW = new BackgroundWorker();
                BGW.DoWork += new DoWorkEventHandler(BGW_DoWork);
                BGW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BGW_RunWorkerCompleted);
                BGW.WorkerReportsProgress = true;
                BGW.ProgressChanged += new ProgressChangedEventHandler(BGW_ProgressChanged);
                this.Size = new Size(this.Size.Width, 280);
                pb_aplicarFormula.Value = 0;
                pb_aplicarFormula.Maximum = 100;
                btn_aplicar.Enabled = btn_ayuda.Enabled = btn_cancelar.Enabled = btn_cargarFuncion.Enabled = btn_eliminarFuncion.Enabled = btn_guardar.Enabled = btn_probarFuncion.Enabled = false;
                BGW.RunWorkerAsync();
            }      
        }

        void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_aplicarFormula.Value = e.ProgressPercentage;
        }

        void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            string funcion = tb_funcion.Text.Trim();
            int rowCounter = 0;
            foreach (DataGridViewRow singleRow in targetRows)
            {
                string fullFuncion = funcion.Replace("?P", double.Parse(singleRow.Cells[precioOrigen].Value.ToString()).ToString("0.00", CultureInfo.InvariantCulture));
                string result = BD_Functions.testFunction(fullFuncion);
                singleRow.Cells[precioDestino].Value = Math.Round(double.Parse(result), 2);
                rowCounter++;
                BGW.ReportProgress((rowCounter * 100) / targetRows.Count);
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Size currentSize = this.Size;

            if (currentSize.Width == 390)
            {
                this.Size = new Size(620, 260);
                btn_ayuda.Text = "<";
            }
            else
            {            
                this.Size = new Size(390, 260);
                btn_ayuda.Text = "?";
            }
        }

    }
}
