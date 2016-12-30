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
    public partial class AssignStudentToExamSession : Form
    {
        StudentCollection students;
        ExamSessionCollection sessions;
        public AssignStudentToExamSession()
        {
            InitializeComponent();
            students = StudentDAL.SelectAll();
            for (int i = 0; i < students.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = students[i].Name;
                item.Value = students[i].Id;
                StudentsComboBox.Items.Add(item);
                StudentsComboBox.SelectedIndex = 0;
            }
            sessions = ExamSessionDAL.SelectAll();
            for (int i = 0; i < sessions.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = sessions[i].Id.ToString();
                item.Value = sessions[i].Id;
                ExamSessionsComboBox.Items.Add(item);
                ExamSessionsComboBox.SelectedIndex = 0;
            }
        }

        private void AssignStudentToExamSession_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adm = MyAdmin.Admin;
            Student stu = new Student(students[StudentsComboBox.SelectedIndex].Id, students[StudentsComboBox.SelectedIndex].Name);
            ExamSession session = new ExamSession(sessions[ExamSessionsComboBox.SelectedIndex].Id);
            SessionStudentAdminDAL.Add(session, adm, stu);
        }
    }
}
