using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class AttendanceService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task Add(Attendance a) => await db.AddAttendanceAsync(a);
        public async Task<List<Attendance>> GetAll() => await db.GetAllAttendanceAsync();
        public async Task Update(Attendance a) => await db.UpdateAttendanceAsync(a);
        public async Task Delete(int id) => await db.DeleteAttendanceAsync(id);
    }
}

