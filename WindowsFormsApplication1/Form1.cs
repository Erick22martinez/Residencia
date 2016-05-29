using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            registro();
            
        }

        public void registro()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=Residencia;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            conexion.Open();

            SqlCommand consulta = new SqlCommand("select * from Usuario where usuario='" + txtuser.Text + "' and contraseña='" + txtcontra.Text + "'", conexion);

            SqlDataReader ejecutar = consulta.ExecuteReader();

            if (ejecutar.Read() == true)
            {
                MessageBox.Show("Bienvenido " + txtuser.Text);
                this.Hide();

                MenuPrincipal frm = new MenuPrincipal();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                txtuser.Clear();
                txtcontra.Clear();
                txtuser.Focus();

                conexion.Close();
            }
        }
    }
}
