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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar_Prov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residenciaDataSet1 = new WindowsFormsApplication1.ResidenciaDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.residenciaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication1.ResidenciaDataSet1TableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenciaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenciaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigousuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.Editar_Prov});
            this.dataGridView2.DataSource = this.usuarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(415, 145);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // codigousuarioDataGridViewTextBoxColumn
            // 
            this.codigousuarioDataGridViewTextBoxColumn.DataPropertyName = "codigousuario";
            this.codigousuarioDataGridViewTextBoxColumn.HeaderText = "codigousuario";
            this.codigousuarioDataGridViewTextBoxColumn.Name = "codigousuarioDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // Editar_Prov
            // 
            this.Editar_Prov.HeaderText = "Eliminar";
            this.Editar_Prov.Name = "Editar_Prov";
            this.Editar_Prov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar_Prov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar_Prov.Text = "Eliminar";
            this.Editar_Prov.UseColumnTextForButtonValue = true;
            this.Editar_Prov.Width = 70;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.residenciaDataSet1;
            // 
            // residenciaDataSet1
            // 
            this.residenciaDataSet1.DataSetName = "ResidenciaDataSet1";
            this.residenciaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // residenciaDataSet1BindingSource
            // 
            this.residenciaDataSet1BindingSource.DataSource = this.residenciaDataSet1;
            this.residenciaDataSet1BindingSource.Position = 0;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenciaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenciaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource residenciaDataSet1BindingSource;
        private ResidenciaDataSet1 residenciaDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ResidenciaDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar_Prov;

    }
}