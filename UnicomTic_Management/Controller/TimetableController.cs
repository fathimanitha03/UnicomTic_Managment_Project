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
    internal class TimetableController
    {
        private readonly TimetableService service = new TimetableService();

        public async Task AddTimetable(Timetable t)
        {
            try
            {
                await service.AddTimetable(t);
                MessageBox.Show("Timetable added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Timetable>> GetTimetables()
        {
            return await service.GetAllTimetables();
        }

        public async Task UpdateTimetable(Timetable t)
        {
            try
            {
                await service.UpdateTimetable(t);
                MessageBox.Show("Timetable updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteTimetable(int id)
        {
            try
            {
                await service.DeleteTimetable(id);
                MessageBox.Show("Timetable deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
