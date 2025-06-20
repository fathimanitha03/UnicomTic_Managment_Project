using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTic_Management.Model
{
    internal class Mark
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; }
        public int ExamID { get; set; }
        public int SubjectID { get; set; }
        public int Score { get; set; }
    }
}
