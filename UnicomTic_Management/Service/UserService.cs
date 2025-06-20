using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.Service
{
    internal class UserService
    {
        private readonly DatabaseManager db = DatabaseManager.Instance;

        public async Task<User> Login(string username, string password)
        {
            return await db.LoginAsync(username, password);
        }

        public async Task<bool> Register(User user)
        {
            return await db.RegisterUserAsync(user);
        }
    }
}
    

