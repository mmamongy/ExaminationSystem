using ExaminationSystem.Collection;
using ExaminationSystem.DAL;
using ExaminationSystem.entities;
using ExaminationSystem.instatnce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class Admin_viewCourses : Form
    {
        CourseCollection courses;
        DepartmentCollection departments;
        public Admin_viewCourses()
        {
            InitializeComponent();
        }

        private void Admin_viewCourses_Load(object sender, EventArgs e)
        {
                   
            courses = new CourseCollection();
            departments = new DepartmentCollection();
            Course c = new Course();
            courses = CourseDAL.SelectAll();
            departments = DepartmentDAL.GetAll();
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < departments.Count; j++)
                {
                    if (courses[i].Deparment.Id == departments[j].Id)
                    {
                        courses[i].Deparment.Name = departments[j].Name;
                        break;
                    }
                }
                this.dataGridView1.Rows.Add((i+1).ToString(), courses[i].Name, courses[i].Deparment.Name, "Update");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show(index.ToString());
            MyCourse.C = courses[index];
            Admin_UpdateCourse frm = new Admin_UpdateCourse();
            frm.Show();
        }
    }
}
