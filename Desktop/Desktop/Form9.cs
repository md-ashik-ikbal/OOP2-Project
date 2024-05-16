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
    public partial class Form9 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";
        public Form9()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form12().Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bloodGroup = comboBox1.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            string loginCheckQuery = "SELECT * FROM donors WHERE bloodGroup='" + bloodGroup + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(loginCheckQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count <= 1)
            {
                dataGridView1.DataSource = dataTable;           
            }
        }
    }
}
