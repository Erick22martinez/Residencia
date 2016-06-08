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
            

            if (dataGridView1.CurrentCell.ColumnIndex == 12)
            {
                if (MessageBox.Show("Desea editar al Proveedor", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string pos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string pos1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string pos2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string pos3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string pos4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    string pos5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    string pos6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    string pos7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    string pos8 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    string pos9 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    string pos10 = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    string pos11 = dataGridView1.CurrentRow.Cells[11].Value.ToString();

                    if (Proveedor.update(pos,pos1,pos2,pos3,pos4,pos5,pos6,pos7,pos8,pos9,pos10,pos11) > 0)
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
