using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class CourseService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task AddCourse(string courseName)
        {
            if (string.IsNullOrWhiteSpace(courseName))
            {
                throw new ArgumentException("Course name cannot be empty.");
            }

            var course = new Course { CourseName = courseName };
            await db.AddCourseAsync(course);
        }

        public async Task<List<Course>> GetAllCourses()
        {
            return await db.GetCoursesAsync();
        }

        public async Task UpdateCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseName))
            {
                throw new ArgumentException("Course name cannot be empty.");
            }

            await db.UpdateCourseAsync(course);
        }

        public async Task DeleteCourse(int courseID)
        {
            if (courseID <= 0)
            {
                throw new ArgumentException("Invalid Course ID.");
            }

            await db.DeleteCourseAsync(courseID);
        }
    }

}

