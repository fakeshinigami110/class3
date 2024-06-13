using System;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load event logic (if any)
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLoginForm loginForm = new StudentLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            ReviewStudentsForm editForm = new ReviewStudentsForm();
            editForm.ShowDialog();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }



    }
}
