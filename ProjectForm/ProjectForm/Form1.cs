using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM book";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);
                            row.Cells[0].Value = reader["book_id"];
                            row.Cells[1].Value = reader["name"];
                            row.Cells[2].Value = reader["author"];
                            row.Cells[3].Value = reader["translator"];
                            row.Cells[4].Value = reader["publisher"];
                            row.Cells[5].Value = reader["publication_date"];
                            row.Cells[6].Value = reader["section"];
                            row.Cells[7].Value = reader["borrow_id"];
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

