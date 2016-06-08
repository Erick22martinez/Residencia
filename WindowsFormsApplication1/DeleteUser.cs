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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal saliraña = new MenuPrincipal();
            saliraña.Show();
            this.Hide();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'residenciaDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.residenciaDataSet1.Usuario);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.CurrentCell.ColumnIndex==3)
          {
              if (MessageBox.Show("Desea eliminar al Usuario", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
              {


                  string pos = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                  
                  //string poss = Convert.ToString(pos);

                  if (Usuario.Eliminar(pos) > 0)
               
                  {
                      MessageBox.Show("Usuario Eliminado", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  else
                  {
                      MessageBox.Show("No se pudo Eliminar el Usuario", "Usuario no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

