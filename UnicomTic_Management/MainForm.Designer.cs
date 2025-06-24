namespace UnicomTic_Management
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.mybtnAttendance = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = " Unicom TIC Dash Board";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(295, 65);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(85, 22);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(23, 102);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(222, 65);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Course";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.Location = new System.Drawing.Point(23, 173);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(222, 58);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.Text = "Subject";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(251, 173);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(222, 58);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.Text = "Student";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnExams
            // 
            this.btnExams.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.Location = new System.Drawing.Point(479, 173);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(222, 58);
            this.btnExams.TabIndex = 5;
            this.btnExams.Text = "Exam";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarks.Location = new System.Drawing.Point(479, 102);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(222, 65);
            this.btnMarks.TabIndex = 6;
            this.btnMarks.Text = "Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(525, 363);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 29);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(633, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(23, 237);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(222, 58);
            this.btnAttendance.TabIndex = 9;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // mybtnAttendance
            // 
            this.mybtnAttendance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mybtnAttendance.Location = new System.Drawing.Point(251, 102);
            this.mybtnAttendance.Name = "mybtnAttendance";
            this.mybtnAttendance.Size = new System.Drawing.Size(222, 65);
            this.mybtnAttendance.TabIndex = 10;
            this.mybtnAttendance.Text = "My Attendance";
            this.mybtnAttendance.UseVisualStyleBackColor = true;
            this.mybtnAttendance.Click += new System.EventHandler(this.mybtnAttendance_Click);
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(251, 237);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(222, 58);
            this.btnRegisterUser.TabIndex = 11;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(776, 417);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.mybtnAttendance);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button mybtnAttendance;
        private System.Windows.Forms.Button btnRegisterUser;
    }
}

