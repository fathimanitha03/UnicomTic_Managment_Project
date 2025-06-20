using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Model;
using UnicomTic_Management.View;

namespace UnicomTic_Management
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            lblWelcome.Text = $"Welcome, {user.Username} ({user.Role})";

            // 🔐 Role-based access control
            if (user.Role == "Student")
            {
                btnStudents.Enabled = false;
                btnMarks.Enabled = false;
                btnExams.Enabled = false;
                btnSubjects.Enabled = false;
            }
            else if (user.Role == "Lecturer")
            {
                btnStudents.Enabled = false;
                btnSubjects.Enabled = false;
            }
            // Admin has access to everything
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.ShowDialog();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            SubjectForm form = new SubjectForm();
            form.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.ShowDialog();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            ExamForm form = new ExamForm();
            form.ShowDialog();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            MarkForm form = new MarkForm();
            form.ShowDialog();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm form = new TimetableForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
