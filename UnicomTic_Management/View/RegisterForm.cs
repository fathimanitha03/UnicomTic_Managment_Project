using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTic_Management.Model;
using UnicomTic_Management.Repostory;

namespace UnicomTic_Management.View
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

       
           private async void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };

            bool result = await DatabaseManager.Instance.RegisterUserAsync(user);

            if (result)
            {
                MessageBox.Show("User registered successfully.");
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0; // default selected
        }

    }
}


