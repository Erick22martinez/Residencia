namespace WindowsFormsApplication1
{
    partial class Provver
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
            this.Direccion_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Direccion_Prov,
            this.Telefono_Prov,
            this.RFC_Prov,
            this.Contacto_Prov});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Clave_Prov
            // 
            this.Clave_Prov.HeaderText = "Clave";
            this.Clave_Prov.Name = "Clave_Prov";
            this.Clave_Prov.ReadOnly = true;
            this.Clave_Prov.Width = 60;
            // 
            // Nombre_Prov
            // 
            this.Nombre_Prov.HeaderText = "Nombre";
            this.Nombre_Prov.Name = "Nombre_Prov";
            this.Nombre_Prov.ReadOnly = true;
            this.Nombre_Prov.Width = 200;
            // 
            // Direccion_Prov
            // 
            this.Direccion_Prov.HeaderText = "Direccion";
            this.Direccion_Prov.Name = "Direccion_Prov";
            this.Direccion_Prov.ReadOnly = true;
            this.Direccion_Prov.Width = 250;
            // 
            // Telefono_Prov
            // 
            this.Telefono_Prov.HeaderText = "Telefono";
            this.Telefono_Prov.Name = "Telefono_Prov";
            this.Telefono_Prov.ReadOnly = true;
            this.Telefono_Prov.Width = 120;
            // 
            // RFC_Prov
            // 
            this.RFC_Prov.HeaderText = "RFC";
            this.RFC_Prov.Name = "RFC_Prov";
            this.RFC_Prov.ReadOnly = true;
            this.RFC_Prov.Width = 170;
            // 
            // Contacto_Prov
            // 
            this.Contacto_Prov.HeaderText = "Contacto";
            this.Contacto_Prov.Name = "Contacto_Prov";
            this.Contacto_Prov.ReadOnly = true;
            this.Contacto_Prov.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Provver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Provver";
            this.Text = "Provver";
            this.Load += new System.EventHandler(this.Provver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto_Prov;
    }
}