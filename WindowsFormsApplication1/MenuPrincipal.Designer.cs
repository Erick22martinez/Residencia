﻿namespace WindowsFormsApplication1
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subAlmacenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores ";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenToolStripMenuItem1,
            this.subAlmacenToolStripMenuItem1});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // almacenToolStripMenuItem1
            // 
            this.almacenToolStripMenuItem1.Name = "almacenToolStripMenuItem1";
            this.almacenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.almacenToolStripMenuItem1.Text = "Almacen";
            this.almacenToolStripMenuItem1.Click += new System.EventHandler(this.almacenToolStripMenuItem1_Click);
            // 
            // subAlmacenToolStripMenuItem1
            // 
            this.subAlmacenToolStripMenuItem1.Name = "subAlmacenToolStripMenuItem1";
            this.subAlmacenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.subAlmacenToolStripMenuItem1.Text = "SubAlmacen";
            this.subAlmacenToolStripMenuItem1.Click += new System.EventHandler(this.subAlmacenToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.verToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // añadirToolStripMenuItem1
            // 
            this.añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            this.añadirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.añadirToolStripMenuItem1.Text = "Añadir";
            this.añadirToolStripMenuItem1.Click += new System.EventHandler(this.añadirToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem1
            // 
            this.verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            this.verToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem1.Text = "Ver";
            this.verToolStripMenuItem1.Click += new System.EventHandler(this.verToolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restaurarToolStripMenuItem,
            this.cambioDeUsuarioToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // cambioDeUsuarioToolStripMenuItem
            // 
            this.cambioDeUsuarioToolStripMenuItem.Name = "cambioDeUsuarioToolStripMenuItem";
            this.cambioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cambioDeUsuarioToolStripMenuItem.Text = "Cambio de Usuario";
            this.cambioDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambioDeUsuarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE INVENTARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(134, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subAlmacenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem1;

    }
}