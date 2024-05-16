using System;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form13().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form12().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().Show();
        }
    }
}
