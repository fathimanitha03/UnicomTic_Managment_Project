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
    internal class StudentController
    {

        private readonly StudentService service = new StudentService();

        public async Task AddStudent(Student student)
        {
            try
            {
                await service.AddStudent(student);
                MessageBox.Show("Student added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Student>> GetStudents()
        {
            return await service.GetAllStudents();
        }

        public async Task UpdateStudent(Student student)
        {
            try
            {
                await service.UpdateStudent(student);
                MessageBox.Show("Student updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteStudent(int studentID)
        {
            try
            {
                await service.DeleteStudent(studentID);
                MessageBox.Show("Student deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

