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
    internal class UserController
    {
        private readonly UserService service = new UserService();

        public async Task<User> Login(string username, string password)
        {
            var user = await service.Login(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid credentials.");
            }
            return user;
        }

        public async Task Register(string username, string password, string role)
        {
            var user = new User { Username = username, Password = password, Role = role };
            var success = await service.Register(user);
            if (success)
                MessageBox.Show("User registered successfully.");
            else
                MessageBox.Show("Username already exists.");
        }
    }
}

