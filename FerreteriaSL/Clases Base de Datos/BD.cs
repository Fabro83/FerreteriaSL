using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace FerreteriaSL.Clases_Base_de_Datos
{
    class Bd
    {
        public MySqlConnection Connection { get; set; }

        public Bd()
        {
            Connection = null;
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
                    Connection = new MySqlConnection(fullConnectionString);
                    try
                    {
                        Connection.Open();
                        Connection.Close();
                        Program.WorkingServer = sServer;
                        break;
                    }
                    catch (Exception)
                    {
                        // ignored
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
                Connection = new MySqlConnection(fullConnectionString);      
            }
                    
        }

        public DataTable Read(string query)
        {
            if(Connection.State != ConnectionState.Open)
                OpenConnection();            
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable result = new DataTable();
            result.Load(reader);
            reader.Close();
            Connection.Close();
            //afldbg.log(this, query, "gray");
            return result;
        }

        public int Write(string query)
        {
            //afldbg.log(this, query, "gray");
            if (Connection.State != ConnectionState.Open)
                OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            int result = cmd.ExecuteNonQuery();
            Connection.Close();
            return result;
        }

        bool OpenConnection()
        {
            try
            {
                Connection.Open();
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
            Connection.Close();
        }
    }
}


