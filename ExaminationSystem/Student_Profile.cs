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
    public partial class Student_Profile : Form
    {
        Student student;
        CourseCollection courses;
        ExamCollection exams;
        ExamSessionCollection examSessions;
        StudentGradeCollection grades1;
        public Student_Profile()
        {
            InitializeComponent();
        }
        private void Student_Profile_Load(object sender, EventArgs e)
        {
            //if (MyStudent.Student == null)
            //{
            //    MessageBox.Show("You Shoul Login as a stuent");
            //    MyStudent.Student = null;
            //    this.Close();
            //    Login login = new Login();
            //    login.Show();
            //    return;
            //}
            dataGridView1.Hide();
            dataGridView2.Hide();
            student = MyStudent.Student;
            MyAdmin.Admin = new Admin();
            MyAdmin.Admin.Id = 1;

            exams = StudentDAL.GetAvailabeExams(student.Id);
            grades1 = StudentDAL.getStudentGrades(student.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            dataGridView2.Hide();
            dataGridView1.Rows.Clear();
            dataGridView1.Show();
            for (int i = 0; i < exams.Count; i++)
            {
               
                    dataGridView1.Rows.Add(exams[i].Course.Name, "Take Exam");
               

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Rows.Clear();
            dataGridView2.Show();
            for ( int i=0; i<grades1.Count; i++)
            {
                dataGridView2.Rows.Add(grades1[i].Crs.Name, grades1[i].Grade);

            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

         //   MessageBox.Show("starting to close profile");
            int index = dataGridView1.CurrentCell.RowIndex;
            MyExam.Exam = exams[index];
            MyExam.Exam.Id = exams[index].Id;
            
            Student_TakingExam ste = new Student_TakingExam();
           
            ste.Show();
            this.Close();
           
            //MessageBox.Show("student profile should be off");
        }
    }
}
