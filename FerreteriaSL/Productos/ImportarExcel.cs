using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using FerreteriaSL.Clases_Base_de_Datos;

namespace FerreteriaSL.Productos
{
    public delegate void BeginTransferHandler(object sender, EventArgs e);
    public delegate void EndTransferHandler(object sender, EventArgs e);

    class ListadoEnExcel
    {
        private string _cfgProvider, _cfgDataSource, _cfgExtendedProperties, _connecionString, _providerTableName, _providerTableFilters, _providerTableColumns;

        public string PriceFunction { get; set; }

        public string ProviderPrice { get; private set; }

        private readonly int _idProveedor;
        DataTable _importedTable;
        BackgroundWorker _transferWorker;
        ProgressBar _importProgressBar;
        Label _importLabel;
        readonly int[] _affectedRows = { 0, 0 };
        public event BeginTransferHandler OnBeginTransfer;
        public event EndTransferHandler OnEndTransfer;

        public ListadoEnExcel(int idProveedor)
        {
            _idProveedor = idProveedor;
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
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");
            XmlNode officeXml = xmlDoc["Settings"]["OfficeString"];
            _cfgProvider = officeXml["Provider"].InnerText;
            _cfgExtendedProperties = officeXml["ExtendedProperties"].InnerText;
            Bd dbCon = new Bd();
            DataRow providerInfo = dbCon.Read("SELECT import_providerTableName, import_providerTableFilters, import_providerTableColumns, import_providerPrice FROM proveedor WHERE id = " + _idProveedor).Rows[0];

            _providerTableName = providerInfo["import_providerTableName"]+"$";
            _providerTableFilters = providerInfo["import_providerTableFilters"].ToString();
            _providerTableColumns = providerInfo["import_providerTableColumns"].ToString();
            ProviderPrice = providerInfo["import_providerPrice"].ToString();
        }

        public void LoadExcel(string filePath)
        {
            _cfgDataSource = filePath;
            _connecionString = String.Format("Provider={0};Data Source=\"{1}\";Extended Properties=\"{2}\"", _cfgProvider, _cfgDataSource, _cfgExtendedProperties);
            OleDbConnection con = new OleDbConnection(_connecionString);
            OleDbCommand cmd = new OleDbCommand("SELECT " + _providerTableColumns + " FROM [" + _providerTableName + "] WHERE " + _providerTableFilters, con);
        
            con.Open();
            try
            {
                OleDbDataReader rdr = cmd.ExecuteReader();
                _importedTable = new DataTable();
                _importedTable.Columns.Add(new DataColumn("F1",typeof(string)));
                _importedTable.Columns.Add(new DataColumn("F2",typeof(string)));
                _importedTable.Columns.Add(new DataColumn("F3",typeof(string)));
                _importedTable.Columns.Add(new DataColumn("F4", typeof(string)));
                _importedTable.Load(rdr);
            }
            catch (OleDbException ode)
            {
                MessageBox.Show("EL archivo Excel seleccionado no corresponde al patrón del proveedor indicado.\n\nExcepción:\n" + ode.Message, "Error al importar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private DataTable ParseDataTable(DataTable target)
        {

            foreach (DataRow sRow in target.Rows)
            {
                for (int i = 0; i < sRow.ItemArray.Length; i++)
                {
                    sRow[i] = sRow[i].ToString().Trim();
                }
                
                string precio = sRow[2].ToString();
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
                    var validacionPrecio = double.Parse(precio);
                    sRow[2] = validacionPrecio.ToString();
                }
                catch (Exception)
                {
                    DialogResult res = MessageBox.Show("El articulo con codigo \"" + sRow[0] + "\" tiene un precio que no puede ser leido." +
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

        public void ShowExcelList(DataGridView dgvTarget)
        {
            if (_importedTable != null)
            {
                dgvTarget.DataSource = ParseDataTable(_importedTable);
                if (dgvTarget.DataSource == null)
                {
                    return;
                }
                dgvTarget.Columns[0].HeaderText = "Codigo";
                dgvTarget.Columns[1].HeaderText = "Nombre";
                dgvTarget.Columns[2].HeaderText = "Precio en lista";
                dgvTarget.Columns[3].HeaderText = "Precio a Importar";

                dgvTarget.Columns[0].ReadOnly = true;
                dgvTarget.Columns[1].ReadOnly = true;
                dgvTarget.Columns[2].ReadOnly = true;
                dgvTarget.Columns[3].ReadOnly = true;
            }
        }

        public int TransferToDataBase(ProgressBar importProgressBar,Label importLabel)
        {
            if (_importedTable == null)
            {
                return -1;
            }

            OnBeginTransferCall(this, EventArgs.Empty);

            _importLabel = importLabel;
            _importProgressBar = importProgressBar;
            
            _importProgressBar.Style = ProgressBarStyle.Continuous;
            _importProgressBar.Maximum = 100;
            _importProgressBar.Value = 0;
            _transferWorker = new BackgroundWorker {WorkerReportsProgress = true, WorkerSupportsCancellation = true};
            _transferWorker.DoWork += transferWorker_DoTransfer;
            _transferWorker.ProgressChanged += transferWorker_ProgressChanged;
            _transferWorker.RunWorkerCompleted += transferWorker_RunWorkerCompleted;
            _transferWorker.RunWorkerAsync();
            return 1;        
        }

        private void transferWorker_DoTransfer(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Bd bdCon = new Bd();

            int processedRows = 0;
            ChangeProgressLabelText("Transfiriendo datos de Excel a la Base de Datos...");
            
            foreach (DataRow singleRow in _importedTable.Rows)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    string codigo = singleRow[0].ToString();
                    string nombre = singleRow[1].ToString().Replace("\"", "\\\"").Replace("'","");
                    double precio = Convert.ToDouble(singleRow[3].ToString().Trim());
                    
                    string query = String.Format("SELECT id, precio,porcentaje FROM producto WHERE codigo = \"{0}\" AND nombre = \"{1}\" AND id_proveedor = {2}", codigo, nombre, _idProveedor);

                    // POR AQUI PEDIR EL PORCENTAJE, VERIFICAR QUE SEA DISTINTO DE CERO Y APLICAR EN CASO NEGATIVO.

                    DataTable checkResult = bdCon.Read(query);

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
                            bdCon.Write(query);
                            _affectedRows[1]++;
                        }         
                    }
                    else
                    {                 
                        query = String.Format("INSERT INTO producto (codigo,id_proveedor,nombre,precio) VALUES (\"{0}\",{1},\"{2}\",{3})", codigo, _idProveedor, nombre, precio.ToString("0.00", CultureInfo.InvariantCulture));      
                        bdCon.Write(query);
                        _affectedRows[0]++;
                    }
                    processedRows++;
                    worker.ReportProgress((processedRows * 100) / _importedTable.Rows.Count);
                }               
            }
        }

        void transferWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _importProgressBar.Value = e.ProgressPercentage;
            ChangeProgressLabelText("Transfiriendo datos de Excel a la Base de Datos... " + e.ProgressPercentage + "%");
        }

        void transferWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _importProgressBar.Value = 0;
            if (e.Cancelled)
            {              
                ChangeProgressLabelText("La importación ha sido cancelada.");
                MessageBox.Show("La importacion ha sido cancelada.\n\nArticulos agregados: " + _affectedRows[0] + "\nArticulos actualizados: " + _affectedRows[1], "Tarea Cancelada!");
            }

            else if (e.Error != null)
            {
                ChangeProgressLabelText("Error al importar.");
                MessageBox.Show("Ha ocurrido un error durante la importación.\n\nExcepción:\n" + e.Error.Message, "Error al importar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
          
                ChangeProgressLabelText("Importacion completada exitosamente.");
                MessageBox.Show("La importacion ha finalizado.\n\nArticulos agregados: " + _affectedRows[0] + "\nArticulos actualizados: " + _affectedRows[1], "Tarea Completada!");
            }
            OnEndTransferCall(this, EventArgs.Empty);
        }

        void ChangeProgressLabelText(string text)
        {
            if(_importLabel != null)
                _importLabel.Invoke(new Action(() => _importLabel.Text = text));
        }

        public void CancelTransfer() 
        {
            if(_transferWorker != null && _transferWorker.IsBusy)
                _transferWorker.CancelAsync();
        }

    }
}
