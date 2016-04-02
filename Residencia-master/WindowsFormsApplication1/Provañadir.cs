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
    }
}
