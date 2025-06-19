using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTic_Management.Model
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public int CourseID { get; set; }
        public int SubjectID { get; set; }
    }
}
