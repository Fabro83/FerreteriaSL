using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace FerreteriaSL
{
    public static class BD_Functions
    {
        private static BD DataBase = null;

        public static int Login(string usuario, string contraseña)
        {
            DataBase = new BD();
            string queryString = String.Format("SELECT id,pass, privilegio FROM usuario WHERE user = '{0}'", usuario);
            DataTable result = DataBase.Read(queryString);

            if (result.Rows.Count > 0)
            {
                DataRow UserData = result.Rows[0];
                if (UserData["pass"].ToString() == contraseña)
                {
                    Usuario.ChangeUser(int.Parse(UserData["id"].ToString()), usuario, int.Parse(UserData["privilegio"].ToString()));
                    DataBase.CloseConnection();
                    DataBase = null;
                    return 1;
                }
                else
                {
                    DataBase.CloseConnection();
                    DataBase = null;
                    return 12;
                }
            }
            else
            {
                DataBase.CloseConnection();
                DataBase = null;
                return 11;
            }
            
        }

        public static DataTable bringTableProducto()
        {
            DataBase = new BD();
            System.Data.DataTable ProductTable = DataBase.Read("SELECT codigo, proveedor.nombre, tipo.descripcion, producto.nombre, stock, precio_venta, precio_compra FROM producto LEFT JOIN proveedor ON id_proveedor = proveedor.id LEFT JOIN tipo ON id_tipo = tipo.id");
            ProductTable.Columns[0].ColumnName = "Codigo";
            ProductTable.Columns[1].ColumnName = "Proveedor";
            ProductTable.Columns[2].ColumnName = "Tipo";
            ProductTable.Columns[3].ColumnName = "Nombre";
            ProductTable.Columns[4].ColumnName = "Stock";
            ProductTable.Columns[5].ColumnName = "Precio Venta";
            ProductTable.Columns[6].ColumnName = "Precio Costo";
            DataBase.CloseConnection();
            DataBase = null;
            return ProductTable;
        }

        public static string testFunction(string function)
        {
            DataBase = new BD();
            string result = "";
            try
            {
                result = DataBase.Read(String.Format("SELECT ({0})", function)).Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return result;
        }

        //public static void MultipleUpdate(DataGridViewSelectedRowCollection changedRows)
        //{
        //    BD DBCon = new BD();
        //    string query = "UPDATE producto SET ";
        //    string whereClause = "WHERE id IN (";
        //    foreach (DataGridViewColumn sCol in changedRows.)
        //    {
        //        if (sCol.Name == "id")
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            query += sCol.Name + " = CASE id ";
 
        //            foreach (DataGridViewRow sRow in changedRows)
        //            {
        //                string pro_id = sRow.Cells["id"].Value.ToString();
        //                string valueToUpdate = sRow.Cells[sCol.Index].Value.ToString();
        //                whereClause += pro_id;
        //                query += String.Format("WHEN {0} THEN {1} ",pro_id,valueToUpdate);
        //                if (sCol.Index < changedRows[0].Cells.Count - 1)
        //                {
        //                    query += "END,";
        //                }
        //                else
        //                {
        //                    query += "END ";
        //                }

        //                if (sRow.Index < changedRows.Count - 1)
        //                {
        //                    whereClause += ",";
        //                }
        //                else
        //                {
        //                    whereClause += ")";
        //                }
        //            }
                    
        //        }               
        //    }      
        //}
    }
}
