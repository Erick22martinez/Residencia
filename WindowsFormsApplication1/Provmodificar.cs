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
    public partial class Provmodificar : Form
    {
        public Provmodificar()
        {
            InitializeComponent();
        }

        private void Provmodificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'residenciaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.residenciaDataSet.Proveedor);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pos = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            if (dataGridView1.CurrentCell.ColumnIndex == 12)
            {
                if (MessageBox.Show("Desea editar al Proveedor", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    if (Proveedor.update(pos) > 0)
                    {
                        MessageBox.Show("Proveedor Agregado");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no editado", "No Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal ini = new MenuPrincipal();
            ini.Show();
            this.Hide();
        }


    }
}
