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
    public partial class Login : Form
    {
        DepartmentCollection depts;
        public Login()
        {
            InitializeComponent();
            depts = DepartmentDAL.GetAll();
            for (int i = 0; i < depts.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = depts[i].Name;
                item.Value = depts[i].Id;
                departmentsCombo.Items.Add(item);
                departmentsCombo.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int adID = 1;
            Admin ad = AdminDAL.GetById(adID);
            Department dept = new Department(depts[departmentsCombo.SelectedIndex].Id, depts[departmentsCombo.SelectedIndex].Name);
            StudentDAL.Add(userNameRegTextBox.Text,NameRegTextBox.Text, int.Parse(AgeTextBox.Text), AddressTextBox.Text, PhoneTextBox.Text, EmailTextBox.Text, false ,ad.Id ,dept.Id,PassRegTextBox.Text);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Instructor loggedInstructor = null ;
            Student loggedStudent =null;
            Admin loggedAdmin = null;
            if (insRadBtn.Checked)
            {
                loggedInstructor = InstructorDAL.GetByUserNameAndPassword(UserNameTextBox.Text, PasswordTextBox.Text);
                if (loggedInstructor == null)
                {
                    MessageBox.Show("Please Insert Correct Data For Instructor");
                }
                else
                {
                    loggedInstructor = InstructorDAL.GetByUserNameAndPassword(UserNameTextBox.Text, PasswordTextBox.Text);
                    MyInstructor.Instructor = loggedInstructor;
                    Instructor_Profile f = new Instructor_Profile();
                    f.Show();
                    this.Hide();
                }
            }
            else if (studRadBtn.Checked)
            {
                loggedStudent = StudentDAL.GetByUserNameAndPassword(UserNameTextBox.Text, PasswordTextBox.Text);
                if(loggedStudent==null)
                {
                    MessageBox.Show("Please Insert Correct Data For Student");
                }
                else { 
                MyStudent.Student = loggedStudent;
                    Student_Profile f = new Student_Profile();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                loggedAdmin = AdminDAL.GetByUserNameAndPassword(UserNameTextBox.Text, PasswordTextBox.Text);
                if(loggedAdmin == null)
                {
                    MessageBox.Show("Please Insert Correct Data For Admin");
                }
                else
                {
                    MyAdmin.Admin = loggedAdmin;
                    AdminProfile adm = new AdminProfile();
                    adm.Show();
                    this.Hide();
                }
            }
        }

        private void AdminRegisterBtn_Click(object sender, EventArgs e)
        {
            AdminDAL.Add(userNameAdminRegTextBox.Text, nameAdminRegTextBox.Text, emailAdminRegTextBox.Text, passAdminRegTextBox.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
