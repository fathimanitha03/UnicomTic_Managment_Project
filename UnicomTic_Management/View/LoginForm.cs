using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Controller;

namespace UnicomTic_Management.View
{
    public partial class LoginForm : Form
    {
        private readonly UserController controller = new UserController();

        public LoginForm()
        {
            InitializeComponent();
            cmbRole.Items.AddRange(new string[] { "Admin", "Lecturer", "Student" });
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            var user = await controller.Login(username, password);

            if (user != null)
            {
                MessageBox.Show("Welcome, " + user.Username + " (" + user.Role + ")");
                this.Hide();
                MainForm main = new MainForm(user);
                main.Show();
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required for registration.");
                return;
            }

            await controller.Register(username, password, role);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
