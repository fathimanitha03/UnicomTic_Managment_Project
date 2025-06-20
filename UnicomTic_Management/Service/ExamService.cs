using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class ExamService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task AddExam(Exam exam)
        {
            if (string.IsNullOrWhiteSpace(exam.ExamName))
                throw new ArgumentException("Exam name is required.");
            await db.AddExamAsync(exam);
        }

        public async Task<List<Exam>> GetAllExams()
        {
            return await db.GetExamsAsync();
        }

        public async Task UpdateExam(Exam exam)
        {
            await db.UpdateExamAsync(exam);
        }

        public async Task DeleteExam(int examID)
        {
            await db.DeleteExamAsync(examID);
        }
    }
}

