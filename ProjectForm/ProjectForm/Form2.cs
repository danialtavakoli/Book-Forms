using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class Form2 : Form
    {

        string connectionString = "Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text.Trim();
            string password = textBox4.Text.Trim();
            if (CheckMemberCredentials(name, password))
            {
                Form3 form3 = new Form3(password);
                form3.Show();
            }
            else if (CheckLibraryStaffCredentials(name, password))
            {
                Form5 form5 = new Form5(password);
                form5.Show();
            }
            else
            {
                MessageBox.Show("Invalid name or password");
            }
        }

        private bool CheckMemberCredentials(string name, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM member WHERE name = @name AND member_id = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool CheckLibraryStaffCredentials(string name, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM library_staff WHERE name = @name AND staff_id = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
