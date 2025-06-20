using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Model;
using UnicomTic_Management.Service;

namespace UnicomTic_Management.Controller
{
    internal class ExamController
    {
        private readonly ExamService service = new ExamService();

        public async Task AddExam(Exam exam)
        {
            try
            {
                await service.AddExam(exam);
                MessageBox.Show("Exam added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Exam>> GetExams()
        {
            return await service.GetAllExams();
        }

        public async Task UpdateExam(Exam exam)
        {
            try
            {
                await service.UpdateExam(exam);
                MessageBox.Show("Exam updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteExam(int examID)
        {
            try
            {
                await service.DeleteExam(examID);
                MessageBox.Show("Exam deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
    

