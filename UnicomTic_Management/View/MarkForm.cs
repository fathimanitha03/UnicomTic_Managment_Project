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
    public partial class MarkForm : Form
    {
        private readonly MarkController controller = new MarkController();
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private List<Mark> current = new List<Mark>();

        public MarkForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadMarks();
        }

        private async void LoadDropdowns()
        {
            cmbStudent.DataSource = await db.GetStudentsAsync();
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "StudentID";

            cmbExam.DataSource = await db.GetExamsAsync();
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "ExamID";

            cmbSubject.DataSource = await db.GetSubjectsAsync();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private async void LoadMarks()
        {
            current = await controller.GetMarks();
            dgvMarks.DataSource = null;
            dgvMarks.DataSource = current;
        }

        private void ClearForm()
        {
            txtMarkID.Text = "";
            txtScore.Text = "";
            cmbStudent.SelectedIndex = -1;
            cmbExam.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark
            {
                StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                ExamID = Convert.ToInt32(cmbExam.SelectedValue),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                Score = Convert.ToInt32(txtScore.Text)
            };

            await controller.AddMark(mark);
            LoadMarks();
            ClearForm();
        }

        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < current.Count)
            {
                var m = current[e.RowIndex];
                txtMarkID.Text = m.MarkID.ToString();
                cmbStudent.SelectedValue = m.StudentID;
                cmbExam.SelectedValue = m.ExamID;
                cmbSubject.SelectedValue = m.SubjectID;
                txtScore.Text = m.Score.ToString();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtMarkID.Text, out id))
            {
                Mark mark = new Mark
                {
                    MarkID = id,
                    StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                    ExamID = Convert.ToInt32(cmbExam.SelectedValue),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    Score = Convert.ToInt32(txtScore.Text)
                };

                await controller.UpdateMark(mark);
                LoadMarks();
                ClearForm();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtMarkID.Text, out id))
            {
                await controller.DeleteMark(id);
                LoadMarks();
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
