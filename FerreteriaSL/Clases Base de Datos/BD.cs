using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace FerreteriaSL.Clases_Base_de_Datos
{
    class Bd
    {
        private MySqlConnection _bdConection;

        public MySqlConnection Connection
        {
            get { return _bdConection; }
            set { _bdConection = value; }
        }
        
        public Bd()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");
            XmlNode mySqlSettings = xmlDoc["Settings"]["MySQL"];
            string[] servers = mySqlSettings["Server"].InnerText.Split(',');
            string port = mySqlSettings["port"].InnerText;
            string dataBase = mySqlSettings["Database"].InnerText;
            string uid = mySqlSettings["Uid"].InnerText;
            string pwd = mySqlSettings["Pwd"].InnerText;            
            string connectionString = "Port="+port+";Database="+dataBase+";Uid="+uid+";Pwd="+pwd;

            while (Program.WorkingServer == "")
            {
                foreach (string sServer in servers)
                {
                    string fullConnectionString = "Server=" + sServer.Trim() + ";" + connectionString;
                    _bdConection = new MySqlConnection(fullConnectionString);
                    try
                    {
                        _bdConection.Open();
                        _bdConection.Close();
                        Program.WorkingServer = sServer;
                        break;
                    }
                    catch (Exception e)
                    {

                    }

                }
                if (Program.WorkingServer == String.Empty)
                {
                    DialogResult retry = MessageBox.Show("No se ha podido conectar con la base de datos, intentelo nuevamente.", "Error de Conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (retry != DialogResult.Retry)
                    {
                        break;
                    }
                }         
            }
            
            if (Program.WorkingServer == "")
            {
                Environment.Exit(-1);
            }
            else
            {
                string fullConnectionString = "Server=" + Program.WorkingServer + ";" + connectionString;
                _bdConection = new MySqlConnection(fullConnectionString);      
            }
                    
        }

        public DataTable Read(string query)
        {
            if(_bdConection.State != ConnectionState.Open)
                OpenConnection();            
            MySqlCommand cmd = new MySqlCommand(query, _bdConection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable result = new DataTable();
            result.Load(reader);
            reader.Close();
            _bdConection.Close();
            //afldbg.log(this, query, "gray");
            return result;
        }

        public int Write(string query)
        {
            //afldbg.log(this, query, "gray");
            if (_bdConection.State != ConnectionState.Open)
                OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, _bdConection);
            int result = cmd.ExecuteNonQuery();
            _bdConection.Close();
            return result;
        }

        bool OpenConnection()
        {
            try
            {
                _bdConection.Open();
                return true;
            }
            catch (MySqlException mysqle)
            {
                DialogResult retry = MessageBox.Show("Ha ocurrido un error al internet conectar con la base de datos.\n\n"+mysqle.Message, "Error de conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (retry == DialogResult.Retry)
                    return OpenConnection();
                else
                    return false;
            }
        }

        public void CloseConnection()
        {
            _bdConection.Close();
        }
    }
}


