using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;

namespace UnicomTic_Management.Repostory
{
    internal class DatabaseManager
    {
        private static DatabaseManager _instance;
        private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

        private DatabaseManager()
        {
            CreateTables();
        }

        private void CreateTables()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string courseTable = @"CREATE TABLE IF NOT EXISTS Courses (
                                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    CourseName TEXT NOT NULL)";
            var cmd = new SQLiteCommand(courseTable, conn);
            cmd.ExecuteNonQuery();

            // Create Subjects table
            string subjectTable = @"CREATE TABLE IF NOT EXISTS Subjects (
                                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    SubjectName TEXT NOT NULL,
                                    CourseID INTEGER NOT NULL,
                                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID))";
            var subjectCmd = new SQLiteCommand(subjectTable, conn);
            subjectCmd.ExecuteNonQuery();

            conn.Dispose();
        }

        //Course
        public async Task AddCourseAsync(Course course)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            var list = new List<Course>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Courses";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var course = new Course
                {
                    CourseID = Convert.ToInt32(reader["CourseID"]),
                    CourseName = reader["CourseName"].ToString()
                };
                list.Add(course);
            }

            conn.Dispose();
            return list;
        }

        public async Task UpdateCourseAsync(Course course)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
            cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteCourseAsync(int courseID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@CourseID", courseID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        //Subject Methods

        public async Task AddSubjectAsync(Subject subject)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@SubjectName, @CourseID)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
            cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Subject>> GetSubjectsAsync()
        {
            var subjects = new List<Subject>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Subjects";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                subjects.Add(new Subject
                {
                    SubjectID = Convert.ToInt32(reader["SubjectID"]),
                    SubjectName = reader["SubjectName"].ToString(),
                    CourseID = Convert.ToInt32(reader["CourseID"])
                });
            }

            conn.Dispose();
            return subjects;
        }

        public async Task UpdateSubjectAsync(Subject subject)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
            cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
            cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteSubjectAsync(int subjectID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@SubjectID", subjectID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }
    }
}
