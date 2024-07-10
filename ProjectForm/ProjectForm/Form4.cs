using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace ProjectForm
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI";
        string tempAuthorName;
        string tempBookTitle;
        string tempBookId;
        string password;
        bool tempIsBorrowed;

        public Form4(string authorName, string bookTitle, string tempPassword)
        {
            tempAuthorName = authorName;
            tempBookTitle = bookTitle;
            password = tempPassword;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"SELECT *
                    FROM book
                    WHERE author = @author OR name = @bookName;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@author", tempAuthorName);
                command.Parameters.AddWithValue("@bookName", tempBookTitle);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string button_text = "";
                        bool isBorrowed = CheckIfBookIsBorrowed(tempBookTitle, tempAuthorName);
                        tempBookId = reader["book_id"].ToString();
                        tempIsBorrowed = isBorrowed;
                        if (isBorrowed)
                        {
                            button_text = "reserve";
                        }
                        else
                        {
                            button_text = "borrow";
                        }
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = reader["book_id"];
                        row.Cells[1].Value = reader["author"];
                        row.Cells[2].Value = reader["translator"];
                        row.Cells[3].Value = reader["publisher"];
                        row.Cells[4].Value = reader["publication_date"];
                        row.Cells[5].Value = reader["name"];
                        row.Cells[6].Value = reader["section"];
                        row.Cells[7].Value = reader["borrow_id"];
                        row.Cells[8].Value = button_text;
                        dataGridView1.Rows.Add(row);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private bool CheckIfBookIsBorrowed(string bookName, string authorName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = @"SELECT COUNT(*) FROM borrow WHERE book_id = (SELECT book_id FROM book WHERE name = @bookName or author = @authorName);";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@bookName", bookName);
                command.Parameters.AddWithValue("@authorName", authorName);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["button"].Index && e.RowIndex >= 0)
            {
                if (tempIsBorrowed)
                {
                    //reserve
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE borrow SET reserver_id = @reserverId WHERE book_id = @bookId;";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@reserverId", password);
                        command.Parameters.AddWithValue("@bookId", tempBookId);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else
                {
                    //borrow
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string queryTemp = @"SELECT MAX(borrow_id) + 1 FROM borrow;";
                        SqlCommand commandTemp = new SqlCommand(queryTemp, connection);
                        int nextBorrowId = (int)commandTemp.ExecuteScalar();
                        string nextBorrowIdString = nextBorrowId.ToString();
                        string query = @"INSERT INTO borrow (borrow_id, book_id, member_id, borrow_date, return_date, reserver_id) VALUES (@borrow_id, @bookId, @memberId, @borrowDate, @returnDate, Null);";
                        SqlCommand command = new SqlCommand(query, connection); 
                        command.Parameters.AddWithValue("@borrow_id", nextBorrowIdString);
                        command.Parameters.AddWithValue("@bookId", tempBookId);
                        command.Parameters.AddWithValue("@memberId", password);
                        command.Parameters.AddWithValue("@borrowDate", DateTime.Now);
                        command.Parameters.AddWithValue("@returnDate", DateTime.Now.AddDays(14));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }
    }
}
