using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ExamGeneration());
            //Application.Run(new Admin_addCourse());
            //Application.Run(new Teacher_AddQuestion());
            //Application.Run(new Admin_deleteCourse());
            Application.Run(new Login());
            //Application.Run(new Admin_addCourse());
            //Application.Run(new Admin_deleteCourse());
            //Application.Run(new Admin_UpdateCourse());
            //Application.Run(new Admin_viewCourses());
            //Application.Run(new Teacher_AddQuestion());
            //Application.Run(new Admin_viewCourses());
            //Application.Run(new Student_Profile());
            //Application.Run(new AdminProfile());
        }
    }
}
