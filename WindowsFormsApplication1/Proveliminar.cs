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
            // TODO: esta línea de código carga datos en la tabla 'residenciaDataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.residenciaDataSet1.Proveedor);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dataGridView1.CurrentCell.ColumnIndex==2)
          {
              if (MessageBox.Show("Desea eliminar al Proveedor", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
              {


                  string pos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                  
                  //string poss = Convert.ToString(pos);

                  if (Proveedor.Eliminar(pos) > 0)
               
                  {
                      MessageBox.Show("Proveedor Eliminado", "Proveedor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  else
                  {
                      MessageBox.Show("No se pudo Eliminar el Proveedor","Proveedor no Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                  }
              }
              else 
              {
                  MessageBox.Show("Se cancelo la eliminacion","Eliminacion cancelada", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
              }
          }
        }

      
        
        
    }
    
}

