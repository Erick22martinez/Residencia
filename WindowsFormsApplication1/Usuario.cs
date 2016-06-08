using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Usuario
    {
        public static int CrearCuentas(string nombre, string apellido, string usuario, string correo, string contraseña, string codigousu)
        {
            int resultado = 0;
            SqlConnection Conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            Conn.Open();

            SqlCommand comm = new SqlCommand(string.Format("Insert into Usuario (Nombre,Apellido,usuario,correo,contraseña,codigousuario) values ('{0}', '{1}','{2}','{3}','{4}','{5}')",nombre,apellido,usuario,correo,contraseña,codigousu),Conn);

            resultado = comm.ExecuteNonQuery();
            Conn.Close();
            return resultado;
        }

        public static int Eliminar(string idclave)
        {
            int retorno = 0;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();

            SqlCommand comm = new SqlCommand(string.Format("Delete From Usuario where codigousuario={0}", idclave), con);

            retorno = comm.ExecuteNonQuery();
            con.Close();

            return retorno;
        }

        public static int update(string idsclave, string nombre, string apellido, string usuario, string correo, string contraseña)
        {
            int result = 0;
            SqlConnection Conn = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            Conn.Open();

            SqlCommand com = new SqlCommand(string.Format("Update Usuario set Nombre='{1}',Apellido='{2}',usuario='{3}',correo='{4}',contraseña='{5}'  where codigousuario={0}", idsclave,nombre,apellido,usuario,correo,contraseña), Conn);

            result = com.ExecuteNonQuery();
            Conn.Close();
            return result;
        }

       
    }
}
