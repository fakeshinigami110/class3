using System;
using System.Windows.Forms;

namespace class_mangemt
{
    public partial class TeacherMenuForm : Form
    {
        public TeacherMenuForm()
        {
            InitializeComponent();
        }

        private void btnReviewStudents_Click(object sender, EventArgs e)
        {
            ReviewStudentsForm reviewForm = new ReviewStudentsForm();
            reviewForm.ShowDialog();
        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            ReviewStudentsForm editForm = new ReviewStudentsForm();
            editForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }
    }
}
