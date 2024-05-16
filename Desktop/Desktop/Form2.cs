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
    public partial class Form2 : Form
    {
        readonly string connectionString = "Data Source=ANONYMOUS; Initial Catalog=Desktop; Persist Security Info=True; User ID=sa; Password=5321; Encrypt=true; TrustServerCertificate=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string email = textBox1.Text;
            string gender = comboBox2.Text;
            string dateOfBirth = textBox3.Text;
            string bloodGroup = comboBox1.Text;
            string userName = textBox2.Text;
            string password = textBox5.Text;

            SqlConnection connection = new(connectionString);
            string insertQuery = "INSERT INTO userRegistration (name, email, gender, dateOfBirth, bloodGroup, userName, password) VALUES ('" + name + "', '" + email + "', '" + gender + "', '" + dateOfBirth + "', '" + bloodGroup + "', '" + userName + "', '" + password + "')";

            if (name.Length > 0 && email.Length > 0 && dateOfBirth.Length > 0 && bloodGroup.Length > 0 && bloodGroup.Length > 0 && userName.Length > 0 && password.Length > 0)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(insertQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();
                Hide();
                new Form3().Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
