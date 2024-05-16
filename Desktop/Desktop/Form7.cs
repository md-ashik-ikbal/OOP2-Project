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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Desktop
{
    public partial class Form7 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form12().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentCity = textBox4.Text;
            string bloodGroup = comboBox1.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            string loginCheckQuery = "SELECT * FROM donors WHERE currentCity='" + currentCity + "' AND bloodGroup='" + bloodGroup + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(loginCheckQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
