namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.Descripcion_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoAlm_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoSubalm_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion_pro,
            this.Codigo_pro,
            this.Nombre_pro,
            this.Presentacion_pro,
            this.SaldoAlm_pro,
            this.SaldoSubalm_pro});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Descripcion_pro
            // 
            this.Descripcion_pro.HeaderText = "Descripcion";
            this.Descripcion_pro.Name = "Descripcion_pro";
            this.Descripcion_pro.Width = 200;
            // 
            // Codigo_pro
            // 
            this.Codigo_pro.HeaderText = "Codigo";
            this.Codigo_pro.Name = "Codigo_pro";
            // 
            // Nombre_pro
            // 
            this.Nombre_pro.HeaderText = "Nombre Comercial";
            this.Nombre_pro.Name = "Nombre_pro";
            this.Nombre_pro.Width = 200;
            // 
            // Presentacion_pro
            // 
            this.Presentacion_pro.HeaderText = "Presentacion";
            this.Presentacion_pro.Name = "Presentacion_pro";
            this.Presentacion_pro.Width = 200;
            // 
            // SaldoAlm_pro
            // 
            this.SaldoAlm_pro.HeaderText = "Saldo Almacen";
            this.SaldoAlm_pro.Name = "SaldoAlm_pro";
            // 
            // SaldoSubalm_pro
            // 
            this.SaldoSubalm_pro.HeaderText = "Saldo Sub Almacen";
            this.SaldoSubalm_pro.Name = "SaldoSubalm_pro";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 201);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoAlm_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoSubalm_pro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}