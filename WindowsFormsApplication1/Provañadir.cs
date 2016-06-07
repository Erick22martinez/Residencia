using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Provañadir : Form
    {
        public Provañadir()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Proveedor.CrearProve(txtclave.Text, txtnombre.Text, txtcalle.Text, txtnum.Text, txtcol.Text, txtmun.Text, txtcp.Text, txtestado.Text, txttel.Text, txtmovil.Text, txtrfc.Text, txtcontacto.Text) > 0)
            {
                MessageBox.Show("Proveedor Agregado");
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtnum.Text = "";
            txtcalle.Text = "";
            txtclave.Text = "";
            txtcol.Text = "";
            txtcontacto.Text = "";
            txtcp.Text = "";
            txtestado.Text = "";
            txtmovil.Text = "";
            txtmun.Text = "";
            txtrfc.Text = "";
            txttel.Text = "";
            txtclave.Focus();
        }
    }
}
