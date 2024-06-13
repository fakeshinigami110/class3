using MySql.Data.MySqlClient;
using System;
using System.Configuration; // Required for ConfigurationManager
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class StudentLoginForm : Form
    {
        private string connectionString;

        public StudentLoginForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        private void StudentLoginForm_Load(object sender, EventArgs e)
        {
            // Load event logic (if any)
        }

        private void txtStudentCode_TextChanged(object sender, EventArgs e)
        {
            // Check if the current text in txtStudentCode is equal to the default text
            if (txtStudentCode.Text == "Please Enter Your student code")
            {
                // Clear the default text when the user starts typing
                txtStudentCode.Clear();
            }
            // Optionally, you can add more logic here if needed
            // For example, validate the entered student code, enable/disable buttons, etc.
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (int.TryParse(txtStudentCode.Text, out int studentCode))
            {
                // Open the StudentDetailsForm with the entered student code
                StudentDetailsForm detailsForm = new StudentDetailsForm(studentCode);
                detailsForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Please enter a valid student code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
