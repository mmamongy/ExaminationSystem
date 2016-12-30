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
    public partial class ExamGeneration : Form
    {
        CourseCollection courses;
        ExamSessionCollection sessions;
        ExamCollection exams;

        //Admin adm = MyAdmin.Admin;
        Admin adm;
        Exam exam;
        Course course = new Course();

        public ExamGeneration()
        {
            InitializeComponent();

            course = new Course();
            adm = new Admin();
            adm.Id = 1;
            exam = new Exam(false, adm);

            courses = CourseDAL.SelectAll();

            for (int i = 0; i < courses.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = courses[i].Name;
                item.Value = courses[i].Id;
                CourseNameComboBox.Items.Add(item);
                CourseNameComboBox.SelectedIndex = 0;
            }
            updateCourse();

            exams = ExamDAL.getAll(adm);
            for (int i = 0; i < exams.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = exams[i].Id.ToString();
                item.Value = exams[i].Id;
                ExamsComboBox.Items.Add(item);
                ExamsComboBox.SelectedIndex = 0;
            }

            QuestionCollection col = QuestionDAL.GetByType(1);
            MCQnumLabel.Text = col.Count.ToString();
            QuestionCollection col2 = QuestionDAL.GetByType(2);
            TFnumLabel.Text = col2.Count.ToString();
            QuestionCollection col3 = QuestionDAL.GetByType(3);
            EssaynumLabel.Text = col3.Count.ToString();

            updateExamSessions();
        }

        private void GenerateExamBtn_Click(object sender, EventArgs e)
        {
            ExamQuestionDAL.GenerateExam(Convert.ToInt32(NumOfMCQTextBox.Text), Convert.ToInt32(NumOfTFTextBox.Text), Convert.ToInt32(NumOfEssayTextBox.Text), course);
            updateCourse();
        }

        private void createExamSessionBtn_Click(object sender, EventArgs e)
        {
            ExamSessionDAL.Add(new DateTime(2017, 6, 27), adm, exams[ExamsComboBox.SelectedIndex].Id);
            updateExamSessions();

        }

        private void updateExamSessions()
        {
            sessions = ExamSessionDAL.SelectAll();
            if (sessions.Count != 0)
            {
                sessionsComboBox.Items.Clear();
                for (int i = 0; i < sessions.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = sessions[i].Id.ToString();
                    item.Value = sessions[i].Id;
                    sessionsComboBox.Items.Add(item);
                    sessionsComboBox.SelectedIndex = 0;
                }
            }
        }

        private void AssignSessionForCourseBtn_Click(object sender, EventArgs e)
        {
            ComboboxItem cb = (ComboboxItem)sessionsComboBox.SelectedItem;
            ExamSession session = ExamSessionDAL.GetById((int)cb.Value);//el id ele rage3 mn el session ele et3amalaha create

            updateCourse();

            CourseExamSessionAdminDAL.GenerateExamSessionForCourse(session, adm, course);
        }

        private void updateCourse()
        {
            course.Id = courses[CourseNameComboBox.SelectedIndex].Id;
            course.Name = courses[CourseNameComboBox.SelectedIndex].Name;

        }

        private void ExamGeneration_Load(object sender, EventArgs e)
        {

        }
    }
}
