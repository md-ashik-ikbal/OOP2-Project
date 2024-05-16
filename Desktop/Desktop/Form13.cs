﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().Show();
        }
    }
}
