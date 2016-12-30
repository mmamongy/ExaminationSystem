using ExaminationSystem.Collection;
using ExaminationSystem.DAL;
using ExaminationSystem.database;
using ExaminationSystem.entities;
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
    public partial class ViewCourses :Form
    {
        //private System.ComponentModel.IContainer components = null;
        //private System.ComponentModel.IContainer components = null;
        CourseCollection courses;
        DepartmentCollection deparments;
        Course c;
        
        
        public ViewCourses()
        {
            InitializeComponent();
        Label label11= new Label();
        Label label22 = new Label();
        Button button11 = new Button();
        courses = new CourseCollection();
            deparments = new DepartmentCollection();
            c = new Course();
            courses = CourseDAL.SelectAll();
            deparments = DepartmentDAL.GetAll();
            for (int i=0; i < courses.Count; i++)
            {
                for ( int j=0; j<deparments.Count; j++)
                {
                    if (courses[i].Deparment.Id == deparments[i].Id)
                    {
                      courses[i].Deparment.Name = deparments[i].Name;
                      
                    }
                }
             
            }

        }

        private void ViewCourses_Load(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
     
    }
}
