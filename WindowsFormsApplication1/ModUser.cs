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
    public partial class ModUser : Form
    {
        public ModUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
        }

        private void ModUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'residenciaDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.residenciaDataSet1.Usuario);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                if (MessageBox.Show("Desea editar al Proveedor", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string pos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string pos1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string pos2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string pos3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string pos4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    string pos5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                   

                    if (Usuario.update(pos, pos1, pos2, pos3, pos4,pos5) > 0)
                    {
                        MessageBox.Show("Usuario Agregado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no editado", "No Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
