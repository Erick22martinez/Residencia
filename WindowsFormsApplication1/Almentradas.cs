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
    public partial class Almentradas : Form
    {
        public Almentradas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal entr = new MenuPrincipal();
            entr.Show();
            this.Hide();
        }

        private void Almentradas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Inventario.CrearInven(txtcodigo.Text,txtfecha.Text,txtproveedor.Text,txtconcepto.Text,txtfactura.Text,txtcantidad.Text,txtdescripcion.Text,txtnombre.Text,txtpresentacion.Text,txtprecio.Text,txtsustancia.Text,txtlab.Text,txtlote.Text,txtcadu.Text) > 0)
            {
                MessageBox.Show("Producto Agregado");
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }
    }
}
