namespace class_mangemt
{
    partial class TeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReviewStudents;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnAddStudent;

        private void InitializeComponent()
        {
            this.btnReviewStudents = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReviewStudents
            // 
            this.btnReviewStudents.Location = new System.Drawing.Point(68, 50);
            this.btnReviewStudents.Name = "btnReviewStudents";
            this.btnReviewStudents.Size = new System.Drawing.Size(215, 50);
            this.btnReviewStudents.TabIndex = 0;
            this.btnReviewStudents.Text = "Review Students";
            this.btnReviewStudents.UseVisualStyleBackColor = true;
            this.btnReviewStudents.Click += new System.EventHandler(this.btnReviewStudents_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Location = new System.Drawing.Point(504, 50);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(215, 50);
            this.btnEditStudents.TabIndex = 1;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(68, 120);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(650, 200);
            this.dataGridViewStudents.TabIndex = 2;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(504, 330);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(215, 50);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(68, 330);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(215, 50);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.btnReviewStudents);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        // Dispose and other methods...
    }
}
