using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FerreteriaSL
{
    public delegate void BeginTransferHandler(object sender, EventArgs e);
    public delegate void EndTransferHandler(object sender, EventArgs e);

    class ListadoEnExcel
    {
        private string cfgProvider, cfgDataSource, cfgExtendedProperties, connecionString, providerTableName, providerTableFilters, providerTableColumns, providerPrice, priceFunction;

        public string PriceFunction
        {
            get { return priceFunction; }
            set { priceFunction = value; }
        }

        public string ProviderPrice
        {
            get { return providerPrice; }
        }

        private int id_proveedor;
        DataTable importedTable;
        BackgroundWorker transferWorker;
        ProgressBar importProgressBar;
        Label importLabel;
        int[] affectedRows = { 0, 0 };
        public event BeginTransferHandler OnBeginTransfer;
        public event EndTransferHandler OnEndTransfer;

        public ListadoEnExcel(int id_proveedor)
        {
            this.id_proveedor = id_proveedor;
            LoadConfig();   
        }

        void OnBeginTransferCall(object sender, EventArgs e)
        {
            if (OnBeginTransfer != null)
            {
                OnBeginTransfer(sender, e);
            }
        }

        void OnEndTransferCall(object sender, EventArgs e)
        {
            if (OnEndTransfer != null)
            {
                OnEndTransfer(sender, e);
            }
        }

        private void LoadConfig()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");
            XmlNode OfficeXML = XMLDoc["Settings"]["OfficeString"];
            this.cfgProvider = OfficeXML["Provider"].InnerText;
            this.cfgExtendedProperties = OfficeXML["ExtendedProperties"].InnerText;
            BD DBCon = new BD();
            DataRow providerInfo = DBCon.Read("SELECT import_providerTableName, import_providerTableFilters, import_providerTableColumns, import_providerPrice FROM proveedor WHERE id = " + id_proveedor).Rows[0];

            this.providerTableName = providerInfo["import_providerTableName"].ToString()+"$";
            this.providerTableFilters = providerInfo["import_providerTableFilters"].ToString();
            this.providerTableColumns = providerInfo["import_providerTableColumns"].ToString();
            this.providerPrice = providerInfo["import_providerPrice"].ToString();
        }

        public void LoadExcel(string filePath)
        {
            this.cfgDataSource = filePath;
            this.connecionString = String.Format("Provider={0};Data Source=\"{1}\";Extended Properties=\"{2}\"", cfgProvider, cfgDataSource, cfgExtendedProperties);
            OleDbConnection con = new OleDbConnection(connecionString);
            OleDbCommand cmd = new OleDbCommand("SELECT " + providerTableColumns + " FROM [" + providerTableName + "] WHERE " + providerTableFilters, con);
        
            con.Open();
            try
            {
                OleDbDataReader rdr = cmd.ExecuteReader();
                importedTable = new DataTable();
                importedTable.Columns.Add(new DataColumn("F1",typeof(string)));
                importedTable.Columns.Add(new DataColumn("F2",typeof(string)));
                importedTable.Columns.Add(new DataColumn("F3",typeof(string)));
                importedTable.Columns.Add(new DataColumn("F4", typeof(string)));
                this.importedTable.Load(rdr);
            }
            catch (OleDbException ode)
            {
                MessageBox.Show("EL archivo Excel seleccionado no corresponde al patrón del proveedor indicado.\n\nExcepción:\n" + ode.Message, "Error al importar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private DataTable parseDataTable(DataTable target)
        {

            foreach (DataRow sRow in target.Rows)
            {
                for (int i = 0; i < sRow.ItemArray.Length; i++)
                {
                    sRow[i] = sRow[i].ToString().Trim();
                }
                
                string precio = sRow[2].ToString();
                double validacion_precio = -1;
                Regex reg1 = new Regex(@"^\d+,\d+$");
                Regex reg2 = new Regex(@"^\d+\.\d+\,\d+$");
                bool stringReplaced = false;

                while (!reg1.IsMatch(precio) && !reg2.IsMatch(precio))
                {
                    if (stringReplaced)
                    {
                        break;
                    }
                    else
                    {
                        precio = precio.Replace(",", "").Replace(".", ",");
                        stringReplaced = true;
                    }
                }

                try
                {
                    validacion_precio = double.Parse(precio);
                    sRow[2] = validacion_precio.ToString();
                }
                catch (Exception ea)
                {
                    DialogResult res = MessageBox.Show("El articulo con codigo \"" + sRow[0].ToString() + "\" tiene un precio que no puede ser leido." +
                                           "\n\nEl articulo será marcado en rojo para que lo modifique manualmente." +
                                           "\nEn caso de no hacerlo, el articulo sera ignorado en la importación.", "Advertencia",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Warning);
                    if (res == DialogResult.Cancel)
                    {
                        return null;
                    }
                    sRow[2] = "-1";
                }
            }
            return target;
        }

        public void ShowExcelList(DataGridView dgv_target)
        {
            if (importedTable != null)
            {
                dgv_target.DataSource = parseDataTable(importedTable);
                if (dgv_target.DataSource == null)
                {
                    return;
                }
                dgv_target.Columns[0].HeaderText = "Codigo";
                dgv_target.Columns[1].HeaderText = "Nombre";
                dgv_target.Columns[2].HeaderText = "Precio en lista";
                dgv_target.Columns[3].HeaderText = "Precio a Importar";

                dgv_target.Columns[0].ReadOnly = true;
                dgv_target.Columns[1].ReadOnly = true;
                dgv_target.Columns[2].ReadOnly = true;
                dgv_target.Columns[3].ReadOnly = true;
            }
        }

        public int TransferToDataBase(ProgressBar importProgressBar,Label importLabel)
        {
            if (importedTable == null)
            {
                return -1;
            }

            OnBeginTransferCall(this, EventArgs.Empty);

            this.importLabel = importLabel;
            this.importProgressBar = importProgressBar;
            
            this.importProgressBar.Style = ProgressBarStyle.Continuous;
            this.importProgressBar.Maximum = 100;
            this.importProgressBar.Value = 0;
            transferWorker = new BackgroundWorker();
            transferWorker.WorkerReportsProgress = true;
            transferWorker.WorkerSupportsCancellation = true;
            transferWorker.DoWork += new DoWorkEventHandler(transferWorker_DoTransfer);
            transferWorker.ProgressChanged += new ProgressChangedEventHandler(transferWorker_ProgressChanged);
            transferWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(transferWorker_RunWorkerCompleted);
            transferWorker.RunWorkerAsync();
            return 1;        
        }

        private void transferWorker_DoTransfer(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            BD BDCon = new BD();

            int processedRows = 0;
            changeProgressLabelText("Transfiriendo datos de Excel a la Base de Datos...");
            
            foreach (DataRow SingleRow in importedTable.Rows)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    string codigo = SingleRow[0].ToString();
                    string nombre = SingleRow[1].ToString().Replace("\"", "\\\"").Replace("'","");
                    double precio = Convert.ToDouble(SingleRow[3].ToString().Trim());
                    
                    string query = String.Format("SELECT id, precio,porcentaje FROM producto WHERE codigo = \"{0}\" AND nombre = \"{1}\" AND id_proveedor = {2}", codigo, nombre, id_proveedor);

                    // POR AQUI PEDIR EL PORCENTAJE, VERIFICAR QUE SEA DISTINTO DE CERO Y APLICAR EN CASO NEGATIVO.

                    DataTable checkResult = BDCon.Read(query);

                    if (checkResult.Rows.Count > 0)
                    {
                        double precioAnterior = double.Parse(checkResult.Rows[0]["precio"].ToString());
                        if (precioAnterior != precio)
                        {
                            double porcentaje = double.Parse(checkResult.Rows[0]["porcentaje"].ToString());
                            double precioFinal = precio;
                            if (porcentaje != 0)
                            {
                                precioFinal = precio + ((porcentaje * precio) / 100);
                            }
                            
                            int id = int.Parse(checkResult.Rows[0][0].ToString());
                            query = String.Format("UPDATE producto SET precio = {0},precio_final = {1} WHERE id = {2}", precio.ToString("0.00", CultureInfo.InvariantCulture), precioFinal.ToString("0.00", CultureInfo.InvariantCulture), id);                       
                            BDCon.Write(query);
                            affectedRows[1]++;
                        }         
                    }
                    else
                    {                 
                        query = String.Format("INSERT INTO producto (codigo,id_proveedor,nombre,precio) VALUES (\"{0}\",{1},\"{2}\",{3})", codigo, id_proveedor, nombre, precio.ToString("0.00", CultureInfo.InvariantCulture));      
                        BDCon.Write(query);
                        affectedRows[0]++;
                    }
                    processedRows++;
                    worker.ReportProgress((processedRows * 100) / importedTable.Rows.Count);
                }               
            }
        }

        void transferWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            importProgressBar.Value = e.ProgressPercentage;
            changeProgressLabelText("Transfiriendo datos de Excel a la Base de Datos... " + e.ProgressPercentage + "%");
        }

        void transferWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            importProgressBar.Value = 0;
            if ((e.Cancelled == true))
            {              
                changeProgressLabelText("La importación ha sido cancelada.");
                MessageBox.Show("La importacion ha sido cancelada.\n\nArticulos agregados: " + affectedRows[0] + "\nArticulos actualizados: " + affectedRows[1], "Tarea Cancelada!");
            }

            else if (!(e.Error == null))
            {
                changeProgressLabelText("Error al importar.");
                MessageBox.Show("Ha ocurrido un error durante la importación.\n\nExcepción:\n" + e.Error.Message, "Error al importar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
          
                changeProgressLabelText("Importacion completada exitosamente.");
                MessageBox.Show("La importacion ha finalizado.\n\nArticulos agregados: " + affectedRows[0] + "\nArticulos actualizados: " + affectedRows[1], "Tarea Completada!");
            }
            OnEndTransferCall(this, EventArgs.Empty);
        }

        void changeProgressLabelText(string text)
        {
            if(importLabel != null)
                importLabel.Invoke(new Action(() => importLabel.Text = text));
        }

        public void CancelTransfer() 
        {
            if(transferWorker != null && transferWorker.IsBusy)
                transferWorker.CancelAsync();
        }

    }
}
