using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Desktop
{
   

    public partial class Form1 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";

        public static string userName = "";
        public static string password = "";
        public Form1()
        {
            InitializeComponent();
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName = textBox3.Text;
            password = textBox1.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            string loginCheckQuery = "SELECT * FROM userRegistration WHERE userName='"+userName+"' AND password='"+password+"'";

            SqlDataAdapter adapter = new SqlDataAdapter(loginCheckQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                Hide();
                new Form11().Show();
            }
            else
            {
                MessageBox.Show("Please Check you Username and Password");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}


