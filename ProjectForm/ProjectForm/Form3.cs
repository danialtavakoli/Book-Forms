using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI";
        string tempPassword;

        public Form3(string password)
        {
            tempPassword = password;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string myPassword = tempPassword;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT m.*, SUM(p.penalty_amount) AS 'total_penalty_amount', ( SELECT STRING_AGG(b.name, ', ') FROM borrow br INNER JOIN book b ON br.book_id = b.book_id WHERE br.member_id = m.member_id ) AS 'borrowed_book' FROM member m LEFT JOIN penalty p ON m.member_id = p.member_id WHERE m.member_id = @myPassword GROUP BY m.member_id, m.name, m.phone_number, m.address, m.join_date, m.image, m.library_address, m.borrow_id, m.penalty_id;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@myPassword", myPassword);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);
                            row.Cells[0].Value = reader["member_id"];
                            row.Cells[1].Value = reader["name"];
                            row.Cells[2].Value = reader["phone_number"];
                            row.Cells[3].Value = reader["address"];
                            row.Cells[4].Value = reader["join_date"];
                            row.Cells[5].Value = reader["image"];
                            row.Cells[6].Value = reader["library_address"];
                            row.Cells[7].Value = reader["borrow_id"];
                            row.Cells[8].Value = reader["penalty_id"];
                            row.Cells[9].Value = reader["total_penalty_amount"];
                            row.Cells[10].Value = reader["borrowed_book"];
                            dataGridView1.Rows.Add(row);
                        }
                        reader.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string authorName = textBox3.Text.Trim();
            string bookTitle = textBox4.Text.Trim();
            Form4 form4 = new Form4(authorName, bookTitle, tempPassword);
            form4.Show();
        }
    }
}
