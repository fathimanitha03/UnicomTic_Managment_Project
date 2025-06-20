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
    internal class MarkController
    {
        private readonly MarkService service = new MarkService();

        public async Task AddMark(Mark mark)
        {
            try
            {
                await service.AddMark(mark);
                MessageBox.Show("Mark added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<List<Mark>> GetMarks()
        {
            return await service.GetAllMarks();
        }

        public async Task UpdateMark(Mark mark)
        {
            try
            {
                await service.UpdateMark(mark);
                MessageBox.Show("Mark updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task DeleteMark(int markID)
        {
            try
            {
                await service.DeleteMark(markID);
                MessageBox.Show("Mark deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

