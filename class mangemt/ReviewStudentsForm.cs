using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class ReviewStudentsForm : Form
    {
        private string connectionString;
        private int currentPage = 1;
        private int pageSize = 10;

        public ReviewStudentsForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int offset = (currentPage - 1) * pageSize;
                    string query = $"SELECT StudentCode, Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students LIMIT {pageSize} OFFSET {offset}";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Add Edit button column
                    if (!dataGridView1.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                        editButton.Name = "Edit";
                        editButton.Text = "Edit";
                        editButton.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Insert(0, editButton);
                    }

                    // Add Delete button column
                    if (!dataGridView1.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                        deleteButton.Name = "Delete";
                        deleteButton.Text = "Delete";
                        deleteButton.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Insert(1, deleteButton);
                    }

                    // Customize DataGridView column headers
                    dataGridView1.Columns["StudentCode"].HeaderText = "Student Code";
                    dataGridView1.Columns["Name"].HeaderText = "Student Name";
                    dataGridView1.Columns["Lesson1Score"].HeaderText = "Lesson 1 Score";
                    dataGridView1.Columns["Lesson2Score"].HeaderText = "Lesson 2 Score";
                    dataGridView1.Columns["Lesson3Score"].HeaderText = "Lesson 3 Score";
                    dataGridView1.Columns["Lesson4Score"].HeaderText = "Lesson 4 Score";
                    dataGridView1.Columns["Lesson5Score"].HeaderText = "Lesson 5 Score";
                    dataGridView1.Columns["GPA"].HeaderText = "GPA";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadStudentData();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadStudentData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int studentCode = (int)dataGridView1.Rows[e.RowIndex].Cells["StudentCode"].Value;
                EditStudentForm editForm = new EditStudentForm(studentCode);
                editForm.ShowDialog();
                LoadStudentData();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int studentCode = (int)dataGridView1.Rows[e.RowIndex].Cells["StudentCode"].Value;
                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteStudent(studentCode);
                }
            }
        }

        private void DeleteStudent(int studentCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Students WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student deleted successfully!");
                    LoadStudentData(); // Reload the data grid view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}
