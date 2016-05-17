namespace WindowsFormsApplication1
{
    partial class ViewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar_Prov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_user,
            this.Nombre_usuario,
            this.Apellido_user,
            this.Nombre,
            this.Correo_user,
            this.Editar_Prov});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 145);
            this.dataGridView1.TabIndex = 2;
            // 
            // Codigo_user
            // 
            this.Codigo_user.HeaderText = "Codigo de Usuario";
            this.Codigo_user.Name = "Codigo_user";
            // 
            // Nombre_usuario
            // 
            this.Nombre_usuario.HeaderText = "Nombre";
            this.Nombre_usuario.Name = "Nombre_usuario";
            this.Nombre_usuario.Width = 200;
            // 
            // Apellido_user
            // 
            this.Apellido_user.HeaderText = "Apellidos";
            this.Apellido_user.Name = "Apellido_user";
            this.Apellido_user.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Usuario";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Correo_user
            // 
            this.Correo_user.HeaderText = "Correo Electronico";
            this.Correo_user.Name = "Correo_user";
            // 
            // Editar_Prov
            // 
            this.Editar_Prov.HeaderText = "Ver";
            this.Editar_Prov.Name = "Editar_Prov";
            this.Editar_Prov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar_Prov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar_Prov.Text = "view";
            this.Editar_Prov.Width = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_user;
        private System.Windows.Forms.DataGridViewButtonColumn Editar_Prov;
        private System.Windows.Forms.Button button1;
    }
}