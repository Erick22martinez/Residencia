﻿using System;
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
    public partial class Almentradas : Form
    {
        public Almentradas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal entr = new MenuPrincipal();
            entr.Show();
            this.Hide();
        }

        private void Almentradas_Load(object sender, EventArgs e)
        {

        }
    }
}
