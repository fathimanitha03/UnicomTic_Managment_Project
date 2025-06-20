using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class TimetableService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task AddTimetable(Timetable t)
        {
            if (string.IsNullOrWhiteSpace(t.Day) || string.IsNullOrWhiteSpace(t.Time))
                throw new ArgumentException("Day and Time cannot be empty.");

            await db.AddTimetableAsync(t);
        }

        public async Task<List<Timetable>> GetAllTimetables()
        {
            return await db.GetTimetablesAsync();
        }

        public async Task UpdateTimetable(Timetable t)
        {
            await db.UpdateTimetableAsync(t);
        }

        public async Task DeleteTimetable(int id)
        {
            await db.DeleteTimetableAsync(id);
        }
    }
}

