using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class TeacherForm : Form
    {
        private string connectionString;
        private int currentPage = 0;
        private int pageSize = 10;

        public TeacherForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents(bool isEditMode = false)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT StudentCode, Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students LIMIT @PageSize OFFSET @Offset";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);
                    cmd.Parameters.AddWithValue("@Offset", currentPage * pageSize);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewStudents.DataSource = dt;

                    if (isEditMode)
                    {
                        // Add edit button column
                        if (dataGridViewStudents.Columns["Edit"] == null)
                        {
                            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                            editButtonColumn.Name = "Edit";
                            editButtonColumn.Text = "Edit";
                            editButtonColumn.UseColumnTextForButtonValue = true;
                            dataGridViewStudents.Columns.Insert(0, editButtonColumn);
                        }
                    }
                    else
                    {
                        if (dataGridViewStudents.Columns["Edit"] != null)
                        {
                            dataGridViewStudents.Columns.Remove("Edit");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnReviewStudents_Click(object sender, EventArgs e)
        {
            LoadStudents(false);
        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            LoadStudents(true);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadStudents(dataGridViewStudents.Columns.Contains("Edit"));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                int studentCode = (int)dataGridViewStudents.Rows[e.RowIndex].Cells["StudentCode"].Value;
                EditStudentForm editStudentForm = new EditStudentForm(studentCode);
                editStudentForm.Show();
            }
        }
    }
}
