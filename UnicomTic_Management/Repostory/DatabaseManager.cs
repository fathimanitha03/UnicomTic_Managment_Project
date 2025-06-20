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

            
            string subjectTable = @"CREATE TABLE IF NOT EXISTS Subjects (
                                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    SubjectName TEXT NOT NULL,
                                    CourseID INTEGER NOT NULL,
                                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID))";
            var subjectCmd = new SQLiteCommand(subjectTable, conn);
            subjectCmd.ExecuteNonQuery();

            string studentTable = @"CREATE TABLE IF NOT EXISTS Students (
                             StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                             FullName TEXT NOT NULL,
                             Gender TEXT NOT NULL,
                             DOB TEXT NOT NULL,
                             CourseID INTEGER NOT NULL,
                             SubjectID INTEGER NOT NULL,
                             FOREIGN KEY(CourseID) REFERENCES Courses(CourseID),
                             FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                             )";
            var studentCmd = new SQLiteCommand(studentTable, conn);
            studentCmd.ExecuteNonQuery();

            string examTable = @"CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        ExamDate TEXT NOT NULL,
                        SubjectID INTEGER NOT NULL,
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                        )";
            var examCmd = new SQLiteCommand(examTable, conn);
            examCmd.ExecuteNonQuery();

            string timetableTable = @"CREATE TABLE IF NOT EXISTS Timetables (
                             TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                             Day TEXT NOT NULL,
                             Time TEXT NOT NULL,
                             SubjectID INTEGER NOT NULL,
                             CourseID INTEGER NOT NULL,
                             FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                             FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                             )";
            var timetableCmd = new SQLiteCommand(timetableTable, conn);
            timetableCmd.ExecuteNonQuery();

            string markTable = @"CREATE TABLE IF NOT EXISTS Marks (
                                MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                                StudentID INTEGER NOT NULL,
                                ExamID INTEGER NOT NULL,
                                SubjectID INTEGER NOT NULL,
                                Score INTEGER NOT NULL,
                                FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                                FOREIGN KEY(ExamID) REFERENCES Exams(ExamID),
                                FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                            )";
            var markCmd = new SQLiteCommand(markTable, conn);
            markCmd.ExecuteNonQuery();

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

        //Students
        public async Task AddStudentAsync(Student student)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Students (FullName, Gender, DOB, CourseID, SubjectID) VALUES (@FullName, @Gender, @DOB, @CourseID, @SubjectID)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@FullName", student.FullName);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@DOB", student.DOB);
            cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
            cmd.Parameters.AddWithValue("@SubjectID", student.SubjectID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            var list = new List<Student>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Students";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new Student
                {
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    FullName = reader["FullName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    DOB = reader["DOB"].ToString(),
                    CourseID = Convert.ToInt32(reader["CourseID"]),
                    SubjectID = Convert.ToInt32(reader["SubjectID"])
                });
            }

            conn.Dispose();
            return list;
        }

        public async Task UpdateStudentAsync(Student student)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Students SET FullName = @FullName, Gender = @Gender, DOB = @DOB, CourseID = @CourseID, SubjectID = @SubjectID WHERE StudentID = @StudentID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@FullName", student.FullName);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@DOB", student.DOB);
            cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
            cmd.Parameters.AddWithValue("@SubjectID", student.SubjectID);
            cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteStudentAsync(int studentID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Students WHERE StudentID = @StudentID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }
        //Exam methods
        public async Task AddExamAsync(Exam exam)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Exams (ExamName, ExamDate, SubjectID, CourseID) VALUES (@ExamName, @ExamDate, @SubjectID, @CourseID)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
            cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
            cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
            cmd.Parameters.AddWithValue("@CourseID", exam.CourseID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Exam>> GetExamsAsync()
        {
            var exams = new List<Exam>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Exams";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                exams.Add(new Exam
                {
                    ExamID = Convert.ToInt32(reader["ExamID"]),
                    ExamName = reader["ExamName"].ToString(),
                    ExamDate = reader["ExamDate"].ToString(),
                    SubjectID = Convert.ToInt32(reader["SubjectID"]),
                    CourseID = Convert.ToInt32(reader["CourseID"])
                });
            }

            conn.Dispose();
            return exams;
        }

        public async Task UpdateExamAsync(Exam exam)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Exams SET ExamName = @ExamName, ExamDate = @ExamDate, SubjectID = @SubjectID, CourseID = @CourseID WHERE ExamID = @ExamID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
            cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
            cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
            cmd.Parameters.AddWithValue("@CourseID", exam.CourseID);
            cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteExamAsync(int examID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Exams WHERE ExamID = @ExamID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ExamID", examID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }


        //Timetable
        public async Task AddTimetableAsync(Timetable timetable)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Timetables (Day, Time, SubjectID, CourseID) VALUES (@Day, @Time, @SubjectID, @CourseID)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Day", timetable.Day);
            cmd.Parameters.AddWithValue("@Time", timetable.Time);
            cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
            cmd.Parameters.AddWithValue("@CourseID", timetable.CourseID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Timetable>> GetTimetablesAsync()
        {
            var list = new List<Timetable>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Timetables";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new Timetable
                {
                    TimetableID = Convert.ToInt32(reader["TimetableID"]),
                    Day = reader["Day"].ToString(),
                    Time = reader["Time"].ToString(),
                    SubjectID = Convert.ToInt32(reader["SubjectID"]),
                    CourseID = Convert.ToInt32(reader["CourseID"])
                });
            }

            conn.Dispose();
            return list;
        }

        public async Task UpdateTimetableAsync(Timetable timetable)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Timetables SET Day = @Day, Time = @Time, SubjectID = @SubjectID, CourseID = @CourseID WHERE TimetableID = @TimetableID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Day", timetable.Day);
            cmd.Parameters.AddWithValue("@Time", timetable.Time);
            cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
            cmd.Parameters.AddWithValue("@CourseID", timetable.CourseID);
            cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteTimetableAsync(int timetableID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Timetables WHERE TimetableID = @TimetableID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@TimetableID", timetableID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task AddMarkAsync(Mark mark)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "INSERT INTO Marks (StudentID, ExamID, SubjectID, Score) VALUES (@StudentID, @ExamID, @SubjectID, @Score)";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmd.Parameters.AddWithValue("@SubjectID", mark.SubjectID);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task<List<Mark>> GetMarksAsync()
        {
            var list = new List<Mark>();
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM Marks";
            var cmd = new SQLiteCommand(query, conn);
            var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new Mark
                {
                    MarkID = Convert.ToInt32(reader["MarkID"]),
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    ExamID = Convert.ToInt32(reader["ExamID"]),
                    SubjectID = Convert.ToInt32(reader["SubjectID"]),
                    Score = Convert.ToInt32(reader["Score"])
                });
            }

            conn.Dispose();
            return list;
        }

        public async Task UpdateMarkAsync(Mark mark)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, SubjectID = @SubjectID, Score = @Score WHERE MarkID = @MarkID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmd.Parameters.AddWithValue("@SubjectID", mark.SubjectID);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }

        public async Task DeleteMarkAsync(int markID)
        {
            var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM Marks WHERE MarkID = @MarkID";
            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MarkID", markID);
            await cmd.ExecuteNonQueryAsync();

            conn.Dispose();
        }
    }
}
