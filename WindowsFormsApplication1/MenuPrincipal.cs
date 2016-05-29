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

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provver eli = new Provver();
            eli.Show();
            this.Hide();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almsalidas eli = new Almsalidas();
            eli.Show();
            this.Hide();
        }

        private void almacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 eli = new Form2();
            eli.Show();
            this.Hide();
        }

        private void subAlmacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 eli = new Form3();
            eli.Show();
            this.Hide();
        }

        private void añadirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 eli = new Form4();
            eli.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModUser eli = new ModUser();
            eli.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteUser eli = new DeleteUser();
            eli.Show();
            this.Hide();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewUser eli = new ViewUser();
            eli.Show();
            this.Hide();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlBackUp eli = new ControlBackUp();
            eli.Show();
            this.Hide();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlRestore eli = new ControlRestore();
            eli.Show();
            this.Hide();
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 eli = new Form1();
            eli.Show();
            this.Hide();
        }

       
  

    }

  
}
