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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == txtconfirmar.Text)
                
            {
                if (Usuario.CrearCuentas(txtnombre.Text, txtape.Text, txtusuario.Text, txtcorreo.Text, txtcontraseña.Text, txtcodigo.Text) > 0)
                {
                    MessageBox.Show("Usuario Agregado");
                }
            }
            else

                MessageBox.Show("Error verificar datos");
        }
        }
    }

