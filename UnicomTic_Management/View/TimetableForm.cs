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
    public partial class TimetableForm : Form
    {
        private readonly TimetableController controller = new TimetableController();
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private List<Timetable> current = new List<Timetable>();

        public TimetableForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadTimetables();
            cmbDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
        }

        private async void LoadDropdowns()
        {
            cmbCourse.DataSource = await db.GetCoursesAsync();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";

            cmbSubject.DataSource = await db.GetSubjectsAsync();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private async void LoadTimetables()
        {
            current = await controller.GetTimetables();
            dgvTimetables.DataSource = null;
            dgvTimetables.DataSource = current;
        }

        private void ClearForm()
        {
            txtTimetableID.Text = "";
            txtTime.Text = "";
            cmbDay.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Timetable t = new Timetable
            {
                Day = cmbDay.SelectedItem?.ToString(),
                Time = txtTime.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            await controller.AddTimetable(t);
            LoadTimetables();
            ClearForm();
        }

        private void dgvTimetables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < current.Count)
            {
                var t = current[e.RowIndex];
                txtTimetableID.Text = t.TimetableID.ToString();
                cmbDay.SelectedItem = t.Day;
                txtTime.Text = t.Time;
                cmbCourse.SelectedValue = t.CourseID;
                cmbSubject.SelectedValue = t.SubjectID;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtTimetableID.Text, out id))
            {
                Timetable t = new Timetable
                {
                    TimetableID = id,
                    Day = cmbDay.SelectedItem?.ToString(),
                    Time = txtTime.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourse.SelectedValue),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
                };

                await controller.UpdateTimetable(t);
                LoadTimetables();
                ClearForm();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtTimetableID.Text, out id))
            {
                await controller.DeleteTimetable(id);
                LoadTimetables();
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TimetableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
