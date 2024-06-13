namespace class_mangemt
{
    partial class TeacherMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReviewStudents;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Button btnAddStudent;

        private void InitializeComponent()
        {
            this.btnReviewStudents = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReviewStudents
            // 
            this.btnReviewStudents.Location = new System.Drawing.Point(50, 50);
            this.btnReviewStudents.Name = "btnReviewStudents";
            this.btnReviewStudents.Size = new System.Drawing.Size(200, 50);
            this.btnReviewStudents.TabIndex = 0;
            this.btnReviewStudents.Text = "Review Students";
            this.btnReviewStudents.UseVisualStyleBackColor = true;
            this.btnReviewStudents.Click += new System.EventHandler(this.btnReviewStudents_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Location = new System.Drawing.Point(50, 120);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(200, 50);
            this.btnEditStudents.TabIndex = 1;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(50, 190);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 50);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // TeacherMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.btnReviewStudents);
            this.Name = "TeacherMenuForm";
            this.Text = "Teacher Menu";
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
