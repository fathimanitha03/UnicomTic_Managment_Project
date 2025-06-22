using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.View
{
    public partial class StudentViewAttendanceForm : Form
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;
        private readonly int studentId;

        public StudentViewAttendanceForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private async void StudentViewAttendanceForm_Load(object sender, EventArgs e)
        {
            var allAttendance = await db.GetAllAttendanceAsync(); MessageBox.Show("Total Attendance Records: " + allAttendance.Count);

            var filtered = allAttendance.Where(a => a.StudentID == studentId).ToList();

            foreach (var a in filtered)
            {
                var subject = await db.GetSubjectByIdAsync(a.SubjectID);
                a.SubjectName = subject?.SubjectName;
            }

            dgvStudentAttendance.DataSource = null;
            dgvStudentAttendance.DataSource = filtered;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudentAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
