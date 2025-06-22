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
    


        public class AttendanceController
    {
        private readonly AttendanceService service = new AttendanceService();

        public async Task AddAttendance(Attendance a)
        {
            try { await service.Add(a); MessageBox.Show("Attendance added."); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        public async Task<List<Attendance>> GetAttendance() => await service.GetAll();

        public async Task UpdateAttendance(Attendance a)
        {
            try { await service.Update(a); MessageBox.Show("Attendance updated."); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        public async Task DeleteAttendance(int id)
        {
            try { await service.Delete(id); MessageBox.Show("Attendance deleted."); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }

}

