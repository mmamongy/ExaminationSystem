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
    public partial class Instructor_Profile : Form
    {
        Instructor ins;
        ExamQuestionCollection examquestions;
        public Instructor_Profile()
        {
            InitializeComponent();
        }

        private void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            Teacher_AddQuestion f = new Teacher_AddQuestion();
            f.Show();
            this.Hide();
        }

        private void Instructor_Profile_Load(object sender, EventArgs e)
        {
            ins = MyInstructor.Instructor;

            //just for test
            MyAdmin.Admin = new Admin();
            MyAdmin.Admin.Id = 1;

            ExamCollection exams = ExamDAL.getAll(MyAdmin.Admin);
            if (exams.Count != 0)
            {
                examsCombobox.Items.Clear();
                for (int i = 0; i < exams.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = exams[i].Id.ToString();
                    item.Value = exams[i].Id;
                    examsCombobox.Items.Add(item);
                    examsCombobox.SelectedIndex = 0;
                }
            }
        }

        private void ViewExamBtn_Click(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)examsCombobox.SelectedItem;
            int exam_id = Int32.Parse(item.Value.ToString());


            examquestions = ExamQuestionDAL.GetExamQuestions(exam_id);


            for (int i = 0; i < examquestions.Count; i++)
            {
                string name = QuestionDAL.GetQuestionTypeName(examquestions[i].Question.Type);

                dataGridView1.Rows.Add(name, examquestions[i].Question.QuestionText);


            }

        }

    }
}
