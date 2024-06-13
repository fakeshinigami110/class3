using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class StudentDetailsForm : Form
    {
        private string connectionString;

        public StudentDetailsForm(int studentCode)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            LoadStudentDetails(studentCode);
        }

        private void LoadStudentDetails(int studentCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Lesson1Score, Lesson2Score, Lesson3Score, Lesson4Score, Lesson5Score, GPA FROM Students WHERE StudentCode = @StudentCode";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;

                    // Optionally, you can customize DataGridView column headers
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

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            // Load event logic (if any)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
