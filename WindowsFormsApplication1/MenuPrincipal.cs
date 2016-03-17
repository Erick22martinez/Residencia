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
    public partial class MenuPrincipal : Form
    {
        public static void cerrar()
        {
            Application.Exit();
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal ini = new MenuPrincipal();
            ini.Show();
            this.Hide();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provañadir ana = new Provañadir();
            ana.Show();
            this.Hide();
          
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogo = MessageBox.Show("Desea Salir del Sistema!", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                MenuPrincipal.cerrar();
            }
            else
                return;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provmodificar mod = new Provmodificar();
            mod.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveliminar eli = new Proveliminar();
            eli.Show();
            this.Hide();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almentradas entr = new Almentradas();
            entr.Show();
            this.Hide();
        }

       
  

    }

  
}
