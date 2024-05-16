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
    public partial class Form6 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";

        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string donorId = textBox3.Text;
            string name = textBox4.Text;
            string gender = comboBox3.Text;
            string dateOfBirth = textBox1.Text;
            string occupation = textBox6.Text;
            string mobileNumber = textBox9.Text;
            string email = textBox10.Text;
            string bloodGroup = comboBox1.Text;
            string currentCity = comboBox2.Text;
            string currentAddress = textBox7.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            string insertQuery = "INSERT INTO donors (donorId, name, gender, dateOfBirth, occupation, mobileNumber, email, bloodGroup, currentCity, currentAddress) VALUES ('" + donorId + "', '" + name + "', '" + gender + "', '" + dateOfBirth + "', '" + occupation + "', '" + mobileNumber + "', '" + email + "', '" + bloodGroup + "', '" + currentCity + "', '" + currentAddress + "')";

            if (donorId.Length > 0 && name.Length > 0 && dateOfBirth.Length > 0 && occupation.Length > 0 && mobileNumber.Length > 0 && email.Length > 0 && currentCity.Length > 0 && currentAddress.Length > 0)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(insertQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();
                Hide();
                new Form14().Show();
            }
            else
            {
                MessageBox.Show("Please Check you Credintials");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form13().Show();
        }
    }
}
