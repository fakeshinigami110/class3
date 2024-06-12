namespace Amozesh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Teacher = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teacher
            // 
            this.Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher.Location = new System.Drawing.Point(169, 186);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(211, 117);
            this.Teacher.TabIndex = 0;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(534, 186);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(211, 117);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Enter += new System.EventHandler(this.button2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 563);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Name = "Form1";
            this.Text = "Class Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Teacher;
        private System.Windows.Forms.Button Student;
    }
}

