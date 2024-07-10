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

namespace ProjectForm
{
    public partial class Form5 : Form
    {
        string connectionString = "Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI";
        string tempPassword;

        public Form5(string password)
        {
            tempPassword = password;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM library_staff where staff_id = @tempPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tempPassword", tempPassword);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);
                            row.Cells[0].Value = reader["staff_id"];
                            row.Cells[1].Value = reader["name"];
                            row.Cells[2].Value = reader["phone_number"];
                            row.Cells[3].Value = reader["section"];
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

                string query2 = "SELECT b.book_id, b.member_id FROM borrow b";
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView2);
                            row.Cells[0].Value = reader["book_id"];
                            row.Cells[1].Value = reader["member_id"];
                            row.Cells[2].Value = "accept";
                            row.Cells[3].Value = "reject";
                            dataGridView2.Rows.Add(row);
                        }
                        reader.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                string query3 = "SELECT member_id FROM member";
                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView3);
                            row.Cells[0].Value = reader["member_id"];
                            row.Cells[1].Value = "remove";
                            dataGridView3.Rows.Add(row);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["reject"].Index && e.RowIndex >= 0)
            {
                string book_id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                string member_id = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM borrow WHERE book_id = @bookId AND member_id = @memberId;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookId", book_id);
                    command.Parameters.AddWithValue("@memberId", member_id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["remove"].Index && e.RowIndex >= 0)
            {
                string member_id = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM borrow WHERE member_id = @memberId; DELETE FROM penalty WHERE member_id = @memberId; DELETE FROM member WHERE member_id = @memberId;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@memberId", member_id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryTemp = @"SELECT MAX(member_id) + 1 FROM member;";
                SqlCommand commandTemp = new SqlCommand(queryTemp, connection);
                int nextmemberId = (int)commandTemp.ExecuteScalar();
                string member_id = nextmemberId.ToString();

                string name = textBox4.Text.Trim();
                string phone_number = textBox5.Text.Trim();
                string address = textBox6.Text.Trim();
                DateTime join_date = DateTime.Now;
                string library_address = "123 Main Street";

                string query = @"INSERT INTO member (member_id, name, phone_number, address, join_date, image, library_address, borrow_id, penalty_id) VALUES (@member_id, @name, @phone_number, @address, @join_date, 0x, @library_address, NULL, NULL)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@member_id", member_id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone_number", phone_number);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@join_date", join_date);
                command.Parameters.AddWithValue("@library_address", library_address);
                command.ExecuteNonQuery();
                connection.Close();
            }
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
