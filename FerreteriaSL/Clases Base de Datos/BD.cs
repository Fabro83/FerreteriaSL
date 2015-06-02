using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml;
using System.Windows.Forms;

namespace FerreteriaSL
{
    class BD
    {
        private MySqlConnection bdConection = null;

        public MySqlConnection Connection
        {
            get { return bdConection; }
            set { bdConection = value; }
        }
        
        public BD()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Settings.xml");
            XmlNode mySqlSettings = XMLDoc["Settings"]["MySQL"];
            string[] servers = mySqlSettings["Server"].InnerText.Split(',');
            string dataBase = mySqlSettings["Database"].InnerText;
            string uid = mySqlSettings["Uid"].InnerText;
            string pwd = mySqlSettings["Pwd"].InnerText;
            string connectionString = "Database="+dataBase+";Uid="+uid+";Pwd="+pwd;

            while (Program.workingServer == "")
            {
                foreach (string sServer in servers)
                {
                    string fullConnectionString = "Server=" + sServer.Trim() + ";" + connectionString;
                    bdConection = new MySqlConnection(fullConnectionString);
                    try
                    {
                        bdConection.Open();
                        bdConection.Close();
                        Program.workingServer = sServer;
                        break;
                    }
                    catch (Exception e)
                    {

                    }

                }
                if (Program.workingServer == String.Empty)
                {
                    DialogResult retry = MessageBox.Show("No se ha podido conectar con la base de datos, intentelo nuevamente.", "Error de Conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (retry != DialogResult.Retry)
                    {
                        break;
                    }
                }         
            }
            
            if (Program.workingServer == "")
            {
                Environment.Exit(-1);
            }
            else
            {
                string fullConnectionString = "Server=" + Program.workingServer + ";" + connectionString;
                bdConection = new MySqlConnection(fullConnectionString);      
            }
                    
        }

        public DataTable Read(string query)
        {
            if(bdConection.State != ConnectionState.Open)
                OpenConnection();            
            MySqlCommand cmd = new MySqlCommand(query, bdConection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable result = new DataTable();
            result.Load(reader);
            reader.Close();
            bdConection.Close();
            //afldbg.log(this, query, "gray");
            return result;
        }

        public int Write(string query)
        {
            //afldbg.log(this, query, "gray");
            if (bdConection.State != ConnectionState.Open)
                OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, bdConection);
            int result = cmd.ExecuteNonQuery();
            bdConection.Close();
            return result;
        }

        bool OpenConnection()
        {
            try
            {
                bdConection.Open();
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
            bdConection.Close();
        }
    }
}


