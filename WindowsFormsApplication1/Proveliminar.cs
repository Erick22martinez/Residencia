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
    public partial class Proveliminar : Form
    {
        public Proveliminar()
        {
            InitializeComponent();
        }

        private void Proveliminar_Load(object sender, EventArgs e)
        {
            MenuPrincipal ini = new MenuPrincipal();
            ini.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
        }
    }
}
