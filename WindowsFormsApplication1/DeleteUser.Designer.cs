namespace WindowsFormsApplication1
{
    partial class DeleteUser
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Codigo_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar_Prov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_user,
            this.Nombre_usuario,
            this.Nombre,
            this.Editar_Prov});
            this.dataGridView2.Location = new System.Drawing.Point(1, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 145);
            this.dataGridView2.TabIndex = 2;
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
            // Nombre
            // 
            this.Nombre.HeaderText = "Usuario";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Editar_Prov
            // 
            this.Editar_Prov.HeaderText = "Eliminar";
            this.Editar_Prov.Name = "Editar_Prov";
            this.Editar_Prov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar_Prov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar_Prov.Text = "Delete";
            this.Editar_Prov.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar_Prov;
        private System.Windows.Forms.Button button1;

    }
}