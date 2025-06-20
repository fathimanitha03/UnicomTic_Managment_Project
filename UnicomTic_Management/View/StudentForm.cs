using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Controller;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.View
{
    public partial class StudentForm : Form
    {
        private readonly StudentController controller = new StudentController();
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private List<Student> currentStudents = new List<Student>();
        private List<Course> currentCourses = new List<Course>();
        private List<Subject> currentSubjects = new List<Subject>();

        public StudentForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubjects();
            LoadStudents();
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private async void LoadCourses()
        {
            currentCourses = await db.GetCoursesAsync();
            cmbCourse.DataSource = currentCourses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private async void LoadSubjects()
        {
            currentSubjects = await db.GetSubjectsAsync();
            cmbSubject.DataSource = currentSubjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private async void LoadStudents()
        {
            currentStudents = await controller.GetStudents();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = currentStudents;
        }

        private void ClearForm()
        {
            txtStudentID.Text = "";
            txtFullName.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FullName = txtFullName.Text.Trim(),
                Gender = cmbGender.SelectedItem?.ToString(),
                DOB = dtpDOB.Value.ToShortDateString(),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            await controller.AddStudent(student);
            LoadStudents();
            ClearForm();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentStudents.Count)
            {
                var selected = currentStudents[e.RowIndex];
                txtStudentID.Text = selected.StudentID.ToString();
                txtFullName.Text = selected.FullName;
                cmbGender.SelectedItem = selected.Gender;
                dtpDOB.Value = Convert.ToDateTime(selected.DOB);
                cmbCourse.SelectedValue = selected.CourseID;
                cmbSubject.SelectedValue = selected.SubjectID;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtStudentID.Text, out id))
            {
                Student student = new Student
                {
                    StudentID = id,
                    FullName = txtFullName.Text.Trim(),
                    Gender = cmbGender.SelectedItem?.ToString(),
                    DOB = dtpDOB.Value.ToShortDateString(),
                    CourseID = Convert.ToInt32(cmbCourse.SelectedValue),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
                };

                await controller.UpdateStudent(student);
                LoadStudents();
                ClearForm();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtStudentID.Text, out id))
            {
                await controller.DeleteStudent(id);
                LoadStudents();
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
