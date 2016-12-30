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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void ExamGenerationFormBtn_Click(object sender, EventArgs e)
        {
            ExamGeneration exam = new ExamGeneration();
            exam.Show();
            this.Hide();
        }

        private void AssignToExamSession_Click(object sender, EventArgs e)
        {
            AssignStudentToExamSession assign = new AssignStudentToExamSession();
            assign.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_AddQuestion frm = new Teacher_AddQuestion();
            frm.Show();
            
        }

        private void assignInsBtn_Click(object sender, EventArgs e)
        {
            MakeStudentInstructor make = new MakeStudentInstructor();
            make.Show();
            this.Hide();
        }
    }
}
