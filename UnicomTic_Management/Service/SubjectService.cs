using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class SubjectService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task AddSubject(Subject subject)
        {
            if (string.IsNullOrWhiteSpace(subject.SubjectName))
                throw new ArgumentException("Subject name cannot be empty.");
            await db.AddSubjectAsync(subject);
        }

        public async Task<List<Subject>> GetAllSubjects()
        {
            return await db.GetSubjectsAsync();
        }

        public async Task UpdateSubject(Subject subject)
        {
            await db.UpdateSubjectAsync(subject);
        }

        public async Task DeleteSubject(int subjectID)
        {
            await db.DeleteSubjectAsync(subjectID);
        }
    }

}

    

