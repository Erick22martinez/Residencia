﻿namespace WindowsFormsApplication1
{
    partial class Provmodificar
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
            this.button1 = new System.Windows.Forms.Button();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar_Prov = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre_prov,
            this.Editar_Prov});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 145);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "clave";
            this.Clave.Name = "Clave";
            // 
            // Nombre_prov
            // 
            this.Nombre_prov.HeaderText = "Nombre";
            this.Nombre_prov.Name = "Nombre_prov";
            this.Nombre_prov.Width = 250;
            // 
            // Editar_Prov
            // 
            this.Editar_Prov.HeaderText = "Editar";
            this.Editar_Prov.Name = "Editar_Prov";
            this.Editar_Prov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar_Prov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar_Prov.Text = "Edit";
            this.Editar_Prov.Width = 40;
            // 
            // Provmodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Provmodificar";
            this.Text = "Provmodificar";
            this.Load += new System.EventHandler(this.Provmodificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_prov;
        private System.Windows.Forms.DataGridViewButtonColumn Editar_Prov;
    }
}