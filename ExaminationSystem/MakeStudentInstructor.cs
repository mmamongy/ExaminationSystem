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
    public partial class MakeStudentInstructor : Form
    {
        StudentCollection students;
        Student student = new Student();
        public MakeStudentInstructor()
        {
            InitializeComponent();
            students = StudentDAL.SelectAll();
            for (int i = 0; i < students.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = students[i].Name;
                item.Value = students[i].Id;
                studentsComboBox.Items.Add(item);
                //studentsComboBox.SelectedIndex = 0;
            }
        } 

        private void setInstructorBtn_Click(object sender, EventArgs e)
        {
            Admin adm = MyAdmin.Admin;
            //Student stu = new Student(students[studentsComboBox.SelectedIndex].Id, students[studentsComboBox.SelectedIndex].Name);
            student = StudentDAL.GetById(students[studentsComboBox.SelectedIndex].Id);
            //student.Id = students[studentsComboBox.SelectedIndex].Id;
            bool isInst = StudentDAL.SetInstructor(student);
            int res = StudentDAL.Add(student.UserName,student.Name,student.Age,student.Address,student.Phone,student.Email,isInst,student.Admin.Id,student.Department.Id,student.Password);
            if (res != 0)
            {
                StudentDAL.DeleteById(student.Id);
            }
        }
    }
}
