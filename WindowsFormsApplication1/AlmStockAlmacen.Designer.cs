namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.Codigo_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sustancia_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caducidad_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoActual_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CM_prp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMax_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surtir_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVU_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Prod,
            this.Nombre_Pro,
            this.descripcion_pro,
            this.Sustancia_pro,
            this.Presentacion_pro,
            this.Lab_pro,
            this.Lote_pro,
            this.Caducidad_pro,
            this.SaldoActual_pro,
            this.CM_prp,
            this.CantidadMax_Prod,
            this.Surtir_pro,
            this.PVU_pro,
            this.Total_pro});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1055, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo_Prod
            // 
            this.Codigo_Prod.HeaderText = "Codigo";
            this.Codigo_Prod.Name = "Codigo_Prod";
            this.Codigo_Prod.Width = 50;
            // 
            // Nombre_Pro
            // 
            this.Nombre_Pro.HeaderText = "Nombre Comercial";
            this.Nombre_Pro.Name = "Nombre_Pro";
            // 
            // descripcion_pro
            // 
            this.descripcion_pro.HeaderText = "Descripcion";
            this.descripcion_pro.Name = "descripcion_pro";
            // 
            // Sustancia_pro
            // 
            this.Sustancia_pro.HeaderText = "Sustancia Activa";
            this.Sustancia_pro.Name = "Sustancia_pro";
            // 
            // Presentacion_pro
            // 
            this.Presentacion_pro.HeaderText = "Presentacion";
            this.Presentacion_pro.Name = "Presentacion_pro";
            // 
            // Lab_pro
            // 
            this.Lab_pro.HeaderText = "Laboratorio";
            this.Lab_pro.Name = "Lab_pro";
            // 
            // Lote_pro
            // 
            this.Lote_pro.HeaderText = "Lote";
            this.Lote_pro.Name = "Lote_pro";
            // 
            // Caducidad_pro
            // 
            this.Caducidad_pro.HeaderText = "Caducidad";
            this.Caducidad_pro.Name = "Caducidad_pro";
            // 
            // SaldoActual_pro
            // 
            this.SaldoActual_pro.HeaderText = "Saldo Actual";
            this.SaldoActual_pro.Name = "SaldoActual_pro";
            // 
            // CM_prp
            // 
            this.CM_prp.HeaderText = "Cantidad Minima";
            this.CM_prp.Name = "CM_prp";
            // 
            // CantidadMax_Prod
            // 
            this.CantidadMax_Prod.HeaderText = "Cantidad Maxima";
            this.CantidadMax_Prod.Name = "CantidadMax_Prod";
            // 
            // Surtir_pro
            // 
            this.Surtir_pro.HeaderText = "Surtir";
            this.Surtir_pro.Name = "Surtir_pro";
            // 
            // PVU_pro
            // 
            this.PVU_pro.HeaderText = "P.V.U ";
            this.PVU_pro.Name = "PVU_pro";
            // 
            // Total_pro
            // 
            this.Total_pro.HeaderText = "Total";
            this.Total_pro.Name = "Total_pro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 342);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sustancia_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caducidad_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoActual_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CM_prp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMax_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surtir_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVU_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_pro;
    }
}