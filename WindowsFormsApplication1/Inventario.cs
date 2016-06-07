using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Inventario
    {

        public static int CrearInven(string codigo, string fecha, string proveedor, string concepto, string factura, string cantidad, string descripcion, string nombrecomercial, string presentacion, string precio,string sustancia, string lab,string lote, string cad)
        {
            int result = 0;
            SqlConnection Conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            Conn.Open();

            SqlCommand com = new SqlCommand(string.Format("Insert into Inventario (codigo,Fecha,Proveedor,Concepto,Factura,Cantidad,Descripcion,Nombrecomercial,Presentacion,Precio,SustanciaActiva,Laboratorio,Lote,Caducidad) values ('{0}', '{1}','{2}','{3}','{4}','{5}', '{6}','{7}', '{8}', '{9}','{10}','{11}','{12}','{13}')", codigo, fecha, proveedor, concepto, factura, cantidad, descripcion, nombrecomercial, presentacion, precio,sustancia,lab,lote,cad), Conn);

            result = com.ExecuteNonQuery();
            Conn.Close();
            return result;
        }
    }
}
