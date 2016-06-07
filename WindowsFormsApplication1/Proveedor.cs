using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Proveedor
    {
        public static int CrearProve(string clave, string nombre, string calle, string numero, string colonia, string municipio, string cp, string estado, string tel, string movil, string rfc, string contacto)
        {
            int result = 0;
            SqlConnection Conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            Conn.Open();

            SqlCommand com = new SqlCommand(string.Format("Insert into Proveedor (clave,Nombre,Calle,Numero,Colonia,Municipio,CP,Estado,Telefono,Movil,RFC,Contacto) values ('{0}', '{1}','{2}','{3}','{4}','{5}', '{6}','{7}', '{8}', '{9}', '{10}', '{11}')", clave, nombre, calle, numero, colonia, municipio, cp, estado, tel, movil, rfc, contacto), Conn);

           result = com.ExecuteNonQuery();
           Conn.Close();
           return result;
        }

        public static int Eliminar(string idclave)
        {
            int retorno = 0;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();

            SqlCommand comm = new SqlCommand(string.Format("Delete From Proveedor where clave={0}",idclave), con);

            retorno = comm.ExecuteNonQuery();
            con.Close();

            return retorno;
        }

        public static int update(string idsclave)
        {
            int result = 0;
            SqlConnection Conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            Conn.Open();//clave,Nombre,Calle,Numero,Colonia,Municipio,CP,Estado,Telefono,Movil,RFC,Contacto

            SqlCommand com = new SqlCommand(string.Format("Update Proveedor set Nombre='{0}', Calle='{1}',Numero='{2}',Colonia='{3}',Municipio='{4}',CP='{5}',Estado='{6}',Telefono='{7}',Movil='{8}',RFC='{9}',Contacto='{10}', where clave={11}",idsclave), Conn);

            result = com.ExecuteNonQuery();
            Conn.Close();
            return result;
        }

        
        
    }
}
