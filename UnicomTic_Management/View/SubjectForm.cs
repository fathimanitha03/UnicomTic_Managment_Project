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
    public partial class SubjectForm : Form
    {
        private readonly SubjectController controller = new SubjectController();
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private List<Subject> currentSubjects = new List<Subject>();
        private List<Course> currentCourses = new List<Course>();

        public SubjectForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadCourses();
        }

        private async void LoadSubjects()
        {
            currentSubjects = await controller.GetSubjects();
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = currentSubjects;
        }

        private async void LoadCourses()
        {
            currentCourses = await db.GetCoursesAsync();
            cmbCourses.DataSource = currentCourses;
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseID";
        }

        private void ClearForm()
        {
            txtSubjectID.Text = "";
            txtSubjectName.Text = "";
            cmbCourses.SelectedIndex = -1;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedValue == null) return;

            Subject subject = new Subject
            {
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourses.SelectedValue)
            };

            await controller.AddSubject(subject);
            LoadSubjects();
            ClearForm();
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentSubjects.Count)
            {
                var selected = currentSubjects[e.RowIndex];
                txtSubjectID.Text = selected.SubjectID.ToString();
                txtSubjectName.Text = selected.SubjectName;
                cmbCourses.SelectedValue = selected.CourseID;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtSubjectID.Text, out id))
            {
                Subject subject = new Subject
                {
                    SubjectID = id,
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourses.SelectedValue)
                };

                await controller.UpdateSubject(subject);
                LoadSubjects();
                ClearForm();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtSubjectID.Text, out id))
            {
                await controller.DeleteSubject(id);
                LoadSubjects();
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
