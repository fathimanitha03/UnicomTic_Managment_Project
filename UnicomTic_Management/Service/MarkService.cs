using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
   
        internal class MarkService
        {
            private readonly DatabaseManager db = DatabaseManager.Instance;

            public async Task AddMark(Mark mark)
            {
                if (mark.Score < 0 || mark.Score > 100)
                    throw new ArgumentException("Mark must be between 0 and 100.");
                await db.AddMarkAsync(mark);
            }

            public async Task<List<Mark>> GetAllMarks()
            {
                return await db.GetMarksAsync();
            }

            public async Task UpdateMark(Mark mark)
            {
                await db.UpdateMarkAsync(mark);
            }

            public async Task DeleteMark(int id)
            {
                await db.DeleteMarkAsync(id);
            }
        }
    }

