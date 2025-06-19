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
    internal class CourseController
    {
        private readonly CourseService service = new CourseService();

        public async Task AddCourse(string name)
        {
            try
            {
                await service.AddCourse(name);
                MessageBox.Show("Course added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Course>> GetCourses()
        {
            return await service.GetAllCourses();
        }

        public async Task UpdateCourse(Course course)
        {
            try
            {
                await service.UpdateCourse(course);
                MessageBox.Show("Course updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteCourse(int courseID)
        {
            try
            {
                await service.DeleteCourse(courseID);
                MessageBox.Show("Course deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

