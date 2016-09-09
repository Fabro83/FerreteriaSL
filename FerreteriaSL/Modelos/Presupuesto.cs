using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BarCode;
using FerreteriaSL.Clases_Base_de_Datos;
using FerreteriaSL.Clases_Genericas;

namespace FerreteriaSL.Modelos
{
    class Presupuesto
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Domicilio { get; private set; }
        public DateTime Fecha { get; private set; }
        public List<PresupuestoProducto> Productos { get; private set; }
        private const string BarcodePrefix = "PRES";
        private const int PresupuestoPrintId = 2;

        public Presupuesto(string barcode)
        {
            Get(int.Parse(barcode.Replace(BarcodePrefix, "")));
        }

        public Presupuesto(int id)
        {
            Get(id);
        }

        public Presupuesto(string nombre, string domicilio, DateTime fecha, DataTable items)
        {
            Id = -1;
            Nombre = nombre;
            Domicilio = domicilio;
            Fecha = fecha;
            LoadItems(items);
        }

        private void Get(int id)
        {
            Bd dBcon = new Bd();
            var res = dBcon.Read("SELECT id,nombre,domicilio,fecha FROM presupuesto WHERE id = " + id);
            if (res.Rows.Count <= 0) return;
            Id = int.Parse(res.Rows[0]["id"].ToString());
            Nombre = res.Rows[0]["nombre"].ToString();
            Domicilio = res.Rows[0]["domicilio"].ToString();
            Fecha = DateTime.Parse(res.Rows[0]["fecha"].ToString());
            var items = dBcon.Read("SELECT id,CANTIDAD,DESCRIPCION,DESCRIPCION_NUEVA,`PRECIO UNITARIO`,`PRECIO UNITARIO_NUEVO`,CODIGO FROM vista_presupuesto WHERE presupuesto_id = " + id);
            dBcon.CloseConnection();
            LoadItems(items);
        }

        public Presupuesto Save()
        {
            if (Id != -1) return null;
            string query = "INSERT INTO presupuesto (nombre,domicilio,fecha) VALUES ('{0}','{1}','{2}')";
            query = String.Format(query, Nombre, Domicilio, Fecha.ToString("yyyy-MM-dd"));
            Bd dbCon = new Bd();
            dbCon.Write(query);
            SetInsertedId();      
            SaveProducts(dbCon);
            return this;
        }

        private void SetInsertedId()
        {
            Bd dbCon = new Bd();
            var getIdQuery = "SELECT id FROM presupuesto WHERE nombre = '{0}' AND domicilio = '{1}' AND fecha = '{2}' ORDER BY id DESC";
            getIdQuery = String.Format(getIdQuery, Nombre, Domicilio, Fecha.ToString("yyyy-MM-dd"));
            Id = int.Parse(dbCon.Read(getIdQuery).Rows[0]["id"].ToString());           
        }

        private void SaveProducts(Bd dbCon)
        {
            const string query = "INSERT INTO presupuesto_producto (presupuesto_id,producto_id,cantidad,descripcion,precio_unitario) VALUES ({0},{1},{2},'{3}',{4})";
            foreach (var filledQuery in Productos.Select(producto => String.Format(query, Id, producto.Id, Bd.DoubleToString(producto.Cantidad), producto.Descripcion, Bd.DoubleToString(producto.PrecioUnitario))))
            {
                dbCon.Write(filledQuery);
            }
            dbCon.CloseConnection();
        }

        public void UpdatePrices()
        {
            foreach (PresupuestoProducto producto in Productos)
            {
                producto.PrecioUnitario = producto.PrecioNuevo;
            }
        }

        public void UpdateDescriptions()
        {
            foreach (PresupuestoProducto producto in Productos)
            {
                producto.Descripcion = producto.DescripcionNueva;
            }
        }

        public bool HasNewPrices()
        {
            return Productos.Any(a => a.PrecioUnitario != a.PrecioNuevo);
        }

        public bool HasNewDescriptions()
        {
            return Productos.Any(a => a.Descripcion != a.DescripcionNueva);
        }

        public string GetBarcode()
        {
            return  Id != -1 ? BarcodeConverter128.StringToBarcode(BarcodePrefix + Id.ToString("D8")) : "";
        }

        public double GetTotalAmount()
        {
            return Productos.Sum(s => s.PrecioUnitario * s.Cantidad);
        }

        private void LoadItems(DataTable items)
        {
            Productos = new List<PresupuestoProducto>();
            if (items.Rows.Count <= 0) return;
            foreach (DataRow item in items.Rows)
            {
                Productos.Add(new PresupuestoProducto
                {
                    Cantidad = double.Parse(item["CANTIDAD"].ToString()),
                    Descripcion = item["DESCRIPCION"].ToString(),
                    DescripcionNueva = items.Columns.Contains("DESCRIPCION_NUEVA") ? item["DESCRIPCION_NUEVA"].ToString() : null,
                    PrecioUnitario = double.Parse(item["PRECIO UNITARIO"].ToString()),
                    PrecioNuevo = items.Columns.Contains("PRECIO UNITARIO_NUEVO") ? double.Parse(item["PRECIO UNITARIO_NUEVO"].ToString()) : 0,                   
                    Id = items.Columns.Contains("id") ? int.Parse(item["id"].ToString()) : -1,
                    Codigo = item["CODIGO"].ToString()
                });
            }
        }

        public void Print(short copies)
        {
            Dictionary<string, object> fieldsDictionary = new Dictionary<string, object>
            {
                {"nombre", "Señor/a: " + Nombre},
                {"domicilio", "Domicilio: " + Domicilio},
                {"fecha", Fecha.ToString("dd/MM/yyyy")},
                {"codigo_barra","fre3of9x,30,Regular,0&&" + GetBarcode()}
            };

            List<Dictionary<string, object>> gridList = new List<Dictionary<string, object>>
            {
                new Dictionary<string, object>()
                {
                    {"cantidad", "Arial,10,Bold,0&&" + "Cantidad"},
                    {"descripcion", "Arial,10,Bold,0&&" + "Descripción"},
                    {"precio_unitario", "Arial,10,Bold,0&&" + "Precio Unitario"},
                    {"precio_subtotal", "Arial,10,Bold,0&&" + "Importe"}
                }
            };

            gridList.AddRange(Productos.Select(producto => producto.GetPrintRow()));

            gridList.Add(new Dictionary<string, object>
            {
                {"cantidad",""},
                {"descripcion",""},
                {"precio_unitario","Arial,14,Bold,20&&"+"Total:"},
                {"precio_subtotal","Arial,14,Bold,20&&"+string.Format("${0:N2}",GetTotalAmount())}
            });

            Impresion objImpresion = new Impresion(fieldsDictionary, gridList, PresupuestoPrintId, copies);
            objImpresion.StartPrinting();
        }


    }

    class PresupuestoProducto
    {
        public int Id { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioNuevo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionNueva { get; set; }
        public string Codigo { get; set; }

        public Dictionary<string,object> GetPrintRow()
        {
            return new Dictionary<string, object>
            {
                {"cantidad",Cantidad},
                {"descripcion",Descripcion},
                {"precio_unitario",String.Format("${0:N2}",PrecioUnitario)},
                {"precio_subtotal",String.Format("${0:N2}",(PrecioUnitario * Cantidad))}
            };
        }

        public bool HasNewPrice()
        {
            return PrecioUnitario != PrecioNuevo;
        }

        public bool HasNewDescription()
        {
            return Descripcion != DescripcionNueva;
        }

        public void UpdatePrice()
        {
            PrecioUnitario = PrecioNuevo;
        }

        public void UpdateDescription()
        {
            Descripcion = DescripcionNueva;
        }

    }

}
