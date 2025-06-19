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
    internal class SubjectController
    {
        private readonly SubjectService service = new SubjectService();

        public async Task AddSubject(Subject subject)
        {
            try
            {
                await service.AddSubject(subject);
                MessageBox.Show("Subject added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Subject>> GetSubjects()
        {
            return await service.GetAllSubjects();
        }

        public async Task UpdateSubject(Subject subject)
        {
            try
            {
                await service.UpdateSubject(subject);
                MessageBox.Show("Subject updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteSubject(int subjectID)
        {
            try
            {
                await service.DeleteSubject(subjectID);
                MessageBox.Show("Subject deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
    

