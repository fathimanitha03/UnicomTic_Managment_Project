using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class StudentService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task AddStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FullName))
                throw new ArgumentException("Full name is required.");
            await db.AddStudentAsync(student);
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await db.GetStudentsAsync();
        }

        public async Task UpdateStudent(Student student)
        {
            await db.UpdateStudentAsync(student);
        }

        public async Task DeleteStudent(int studentID)
        {
            await db.DeleteStudentAsync(studentID);
        }
    }
}

