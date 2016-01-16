using System;
using System.Data;
using FerreteriaSL.Clases_Genericas;

namespace FerreteriaSL.Clases_Base_de_Datos
{
    public static class BdFunctions
    {
        private static Bd _dataBase;

        public static int Login(string usuario, string contraseña)
        {
            _dataBase = new Bd();
            string queryString = String.Format("SELECT id,pass, privilegio FROM usuario WHERE user = '{0}'", usuario);
            DataTable result = _dataBase.Read(queryString);

            if (result.Rows.Count > 0)
            {
                DataRow userData = result.Rows[0];
                if (userData["pass"].ToString() == contraseña)
                {
                    Usuario.ChangeUser(int.Parse(userData["id"].ToString()), usuario, int.Parse(userData["privilegio"].ToString()));
                    _dataBase.CloseConnection();
                    _dataBase = null;
                    return 1;
                }
                else
                {
                    _dataBase.CloseConnection();
                    _dataBase = null;
                    return 12;
                }
            }
            else
            {
                _dataBase.CloseConnection();
                _dataBase = null;
                return 11;
            }
            
        }

        public static DataTable BringTableProducto()
        {
            _dataBase = new Bd();
            DataTable productTable = _dataBase.Read("SELECT codigo, proveedor.nombre, tipo.descripcion, producto.nombre, stock, precio_venta, precio_compra FROM producto LEFT JOIN proveedor ON id_proveedor = proveedor.id LEFT JOIN tipo ON id_tipo = tipo.id");
            productTable.Columns[0].ColumnName = "Codigo";
            productTable.Columns[1].ColumnName = "Proveedor";
            productTable.Columns[2].ColumnName = "Tipo";
            productTable.Columns[3].ColumnName = "Nombre";
            productTable.Columns[4].ColumnName = "Stock";
            productTable.Columns[5].ColumnName = "Precio Venta";
            productTable.Columns[6].ColumnName = "Precio Costo";
            _dataBase.CloseConnection();
            _dataBase = null;
            return productTable;
        }

        public static string TestFunction(string function)
        {
            _dataBase = new Bd();
            string result;
            try
            {
                result = _dataBase.Read(String.Format("SELECT ({0})", function)).Rows[0][0].ToString();
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
