using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTic_Management.Model
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        // For UI display
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
    }
}
