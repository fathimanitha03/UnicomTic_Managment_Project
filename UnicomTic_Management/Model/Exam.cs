using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTic_Management.Model
{
    internal class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public string ExamDate { get; set; }
        public int SubjectID { get; set; }
        public int CourseID { get; set; }
    }
}
