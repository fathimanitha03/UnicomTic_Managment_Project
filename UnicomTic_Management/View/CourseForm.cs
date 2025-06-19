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
using UnicomTic_Management.Model;

namespace UnicomTic_Management.View
{
    
        public partial class CourseForm : Form
        {
            private readonly CourseController controller = new CourseController();
            private List<Course> currentCourses = new List<Course>();

            public CourseForm()
            {
                InitializeComponent();
                LoadCourses();
            }

            private async void LoadCourses()
            {
                currentCourses = await controller.GetCourses();
                dgvCourses.DataSource = null;
                dgvCourses.DataSource = currentCourses;
                dgvCourses.Columns["CourseID"].HeaderText = "ID";
                dgvCourses.Columns["CourseName"].HeaderText = "Name";
            }

            private void ClearForm()
            {
                txtCourseID.Text = "";
                txtCourseName.Text = "";
            }

            private async void btnAdd_Click(object sender, EventArgs e)
            {
                string name = txtCourseName.Text.Trim();
                await controller.AddCourse(name);
                LoadCourses();
                ClearForm();
            }

            private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.RowIndex < currentCourses.Count)
                {
                    var selected = currentCourses[e.RowIndex];
                    txtCourseID.Text = selected.CourseID.ToString();
                    txtCourseName.Text = selected.CourseName;
                }
            }

            private async void btnUpdate_Click(object sender, EventArgs e)
            {
                int id;
                if (int.TryParse(txtCourseID.Text, out id) && !string.IsNullOrWhiteSpace(txtCourseName.Text))
                {
                    Course updatedCourse = new Course
                    {
                        CourseID = id,
                        CourseName = txtCourseName.Text.Trim()
                    };

                    await controller.UpdateCourse(updatedCourse);
                    LoadCourses();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please select a valid course to update.");
                }
            }

            private async void btnDelete_Click(object sender, EventArgs e)
            {
                int id;
                if (int.TryParse(txtCourseID.Text, out id))
                {
                    await controller.DeleteCourse(id);
                    LoadCourses();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please select a valid course to delete.");
                }
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            private void CourseForm_Load(object sender, EventArgs e)
            {

            }

            private void txtCourseID_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter) { }
            }

            private void dgvCourses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {

            }
        }
    }
