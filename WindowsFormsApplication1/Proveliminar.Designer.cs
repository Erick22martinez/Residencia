namespace WindowsFormsApplication1
{
    partial class Proveliminar
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
            this.Clave_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar_Prov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave_Prov,
            this.Nombre_Prov,
            this.Eliminar_Prov});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // Clave_Prov
            // 
            this.Clave_Prov.HeaderText = "Clave";
            this.Clave_Prov.Name = "Clave_Prov";
            // 
            // Nombre_Prov
            // 
            this.Nombre_Prov.HeaderText = "Nombre";
            this.Nombre_Prov.Name = "Nombre_Prov";
            this.Nombre_Prov.Width = 250;
            // 
            // Eliminar_Prov
            // 
            this.Eliminar_Prov.HeaderText = "Eliminar";
            this.Eliminar_Prov.Name = "Eliminar_Prov";
            this.Eliminar_Prov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar_Prov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar_Prov.Text = "Delete";
            this.Eliminar_Prov.ToolTipText = "Delete";
            this.Eliminar_Prov.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Proveliminar";
            this.Text = "Proveliminar";
            this.Load += new System.EventHandler(this.Proveliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prov;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar_Prov;
    }
}