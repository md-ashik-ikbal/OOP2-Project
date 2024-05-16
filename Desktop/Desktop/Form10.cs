using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form10 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";

        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string userName = Form1.userName;
            string password = Form1.password;

            SqlConnection connection = new SqlConnection(connectionString);
            string loginCheckQuery = "SELECT * FROM userRegistration WHERE userName='" + userName + "' AND password ='"+ password +"'";

            SqlDataAdapter adapter = new SqlDataAdapter(loginCheckQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
