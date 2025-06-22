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
    
        public partial class StudentAttendanceForm : Form
        {
            private readonly AttendanceController controller = new AttendanceController();
            private readonly DatabaseManager db = DatabaseManager.Instance;

            public StudentAttendanceForm() => InitializeComponent();

            private async void StudentAttendanceForm_Load(object sender, EventArgs e)
            {
                cmbStatus.Items.AddRange(new string[] { "Present", "Absent", "Late", "Excused" });

                cmbStudent.DataSource = await db.GetStudentsAsync();
                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentID";

                cmbSubject.DataSource = await db.GetSubjectsAsync();
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectID";

                await LoadAttendance();
            }

            private async Task LoadAttendance()
            {
                var list = await controller.GetAttendance();
                foreach (var a in list)
                {
                    var student = await db.GetStudentByIdAsync(a.StudentID);
                    var subject = await db.GetSubjectByIdAsync(a.SubjectID);
                    a.StudentName = student.FullName;
                    a.SubjectName = subject.SubjectName;
                }
                dgvAttendance.DataSource = null;
                dgvAttendance.DataSource = list;
            }

            private async void btnAdd_Click(object sender, EventArgs e)
            {
                if (cmbStudent.SelectedIndex == -1 || cmbSubject.SelectedIndex == -1 || string.IsNullOrEmpty(cmbStatus.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                var a = new Attendance
                {
                    StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    Date = dtpDate.Value.ToString("yyyy-MM-dd"),
                    Status = cmbStatus.Text
                };

                await controller.AddAttendance(a);
                await LoadAttendance();
            }

            private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    var row = dgvAttendance.Rows[e.RowIndex];
                    txtAttendanceID.Text = row.Cells["AttendanceID"].Value.ToString();
                    cmbStudent.SelectedValue = Convert.ToInt32(row.Cells["StudentID"].Value);
                    cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                    dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
                    cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                }
            }

            private async void btnUpdate_Click(object sender, EventArgs e)
            {
                var a = new Attendance
                {
                    AttendanceID = Convert.ToInt32(txtAttendanceID.Text),
                    StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    Date = dtpDate.Value.ToString("yyyy-MM-dd"),
                    Status = cmbStatus.Text
                };

                await controller.UpdateAttendance(a);
                await LoadAttendance();
            }

            private async void btnDelete_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(txtAttendanceID.Text);
                await controller.DeleteAttendance(id);
                await LoadAttendance();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        

       
    }
}
