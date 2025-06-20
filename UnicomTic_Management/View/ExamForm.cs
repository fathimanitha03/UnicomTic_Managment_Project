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
    public partial class ExamForm : Form
    {
        private readonly ExamController controller = new ExamController();
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private List<Exam> current = new List<Exam>();

        public ExamForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubjects();
            LoadExams();
        }

        private async void LoadCourses()
        {
            cmbCourse.DataSource = await db.GetCoursesAsync();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private async void LoadSubjects()
        {
            cmbSubject.DataSource = await db.GetSubjectsAsync();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private async void LoadExams()
        {
            current = await controller.GetExams();
            dgvExams.DataSource = null;
            dgvExams.DataSource = current;
        }

        private void ClearForm()
        {
            txtExamID.Text = "";
            txtExamName.Text = "";
            dtpExamDate.Value = DateTime.Today;
            cmbCourse.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam
            {
                ExamName = txtExamName.Text.Trim(),
                ExamDate = dtpExamDate.Value.ToShortDateString(),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            };

            await controller.AddExam(exam);
            LoadExams();
            ClearForm();
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < current.Count)
            {
                var selected = current[e.RowIndex];
                txtExamID.Text = selected.ExamID.ToString();
                txtExamName.Text = selected.ExamName;
                dtpExamDate.Value = Convert.ToDateTime(selected.ExamDate);
                cmbCourse.SelectedValue = selected.CourseID;
                cmbSubject.SelectedValue = selected.SubjectID;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtExamID.Text, out id))
            {
                Exam exam = new Exam
                {
                    ExamID = id,
                    ExamName = txtExamName.Text.Trim(),
                    ExamDate = dtpExamDate.Value.ToShortDateString(),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
                };

                await controller.UpdateExam(exam);
                LoadExams();
                ClearForm();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtExamID.Text, out id))
            {
                await controller.DeleteExam(id);
                LoadExams();
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ExamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
