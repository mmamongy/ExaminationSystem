using ExaminationSystem.Collection;
using ExaminationSystem.DAL;
using ExaminationSystem.database;
using ExaminationSystem.entities;
using ExaminationSystem.instatnce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class Student_TakingExam : Form
    {

        RadioButton choiceA;
        RadioButton choiceB;
        RadioButton choiceC;
        RadioButton choiceD;
        RadioButton checkTrue;
        RadioButton checkFalse;

        Label choiceALabel;
        Label choiceBLabel;
        Label choiceCLabel;
        Label choiceDLabel;

        Label checkTrueLabel;
        Label checkFalseLabel;

        RichTextBox questionAnswer;

        int count = 0;


        ExamQuestionCollection examQuestions;

        public Student_TakingExam()
        {
            InitializeComponent();
        }

        private void Student_TakingExam_Load(object sender, EventArgs e)
        {
            //Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True
            //Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True
            //DBLayer.connection = @"Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True";
            DBLayer.connection = @"Data Source=FATMA\FATMAGAMAL;Initial Catalog=ExaminationSystems;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(DBLayer.connection);

            //course_id should come as a parameter to the form in the first place
            //getExamQuestions(sqlConnection, course_id, student_id);
            //MessageBox.Show(MyExam.Exam.ExamSessions[0].Id.ToString() + "   " + MyExam.Exam.Id.ToString());

            examQuestions = ExamQuestionDAL.GetExamQuestions(MyExam.Exam.Id);

            if (count > 0)
            {
                showQuestion(count);
            }
        }

        private void showQuestion(int number)
        {
            int incrementValueLocationX = 10;
            int incrementValueLocationY = 10;
            int type = examQuestions[number].Question.Type;

            questioncontent.Text = examQuestions[number].Question.QuestionText;
            switch (type)
            {

                //MCQ, TF, Essay
                case 1:
                    QuestionPanel.Controls.Clear(); //to remove all controls

                    choiceA = new RadioButton();
                    choiceA.Location = new Point(questioncontent.Location.X, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceA);

                    choiceALabel = new Label();
                    choiceALabel.Location = new Point(choiceA.Location.X + incrementValueLocationX + choiceA.Size.Width, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    choiceALabel.Text = examQuestions[number].Question.Answers[0].Answer;
                    QuestionPanel.Controls.Add(choiceALabel);


                    choiceB = new RadioButton();
                    choiceB.Location = new Point(questioncontent.Location.X, choiceA.Location.Y + choiceA.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceB);

                    choiceBLabel = new Label();
                    choiceBLabel.Location = new Point(choiceB.Location.X + incrementValueLocationX + choiceB.Size.Width, choiceA.Location.Y + choiceA.Height + incrementValueLocationY);
                    choiceBLabel.Text = examQuestions[number].Question.Answers[1].Answer;
                    QuestionPanel.Controls.Add(choiceBLabel);


                    choiceC = new RadioButton();
                    choiceC.Location = new Point(questioncontent.Location.X, choiceB.Location.Y + choiceB.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceC);

                    choiceCLabel = new Label();
                    choiceCLabel.Location = new Point(choiceC.Location.X + incrementValueLocationX + choiceC.Size.Width, choiceB.Location.Y + choiceB.Height + incrementValueLocationY);
                    choiceCLabel.Text = examQuestions[number].Question.Answers[2].Answer;
                    QuestionPanel.Controls.Add(choiceCLabel);


                    choiceD = new RadioButton();
                    choiceD.Location = new Point(questioncontent.Location.X, choiceC.Location.Y + choiceC.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceD);

                    choiceDLabel = new Label();
                    choiceDLabel.Location = new Point(choiceD.Location.X + incrementValueLocationX + choiceD.Size.Width, choiceC.Location.Y + choiceC.Height + incrementValueLocationY);
                    choiceDLabel.Text = examQuestions[number].Question.Answers[3].Answer;
                    QuestionPanel.Controls.Add(choiceDLabel);
                    break;

                case 2:

                    QuestionPanel.Controls.Clear(); //to remove all controls
                    //all radio buttons should be in the same group
                    checkTrue = new RadioButton();
                    checkTrue.Location = new Point(questioncontent.Location.X, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkTrue);

                    checkTrueLabel = new Label();
                    checkTrueLabel.Text = examQuestions[number].Question.Answers[0].Answer;
                    checkTrueLabel.Location = new Point(checkTrue.Location.X + incrementValueLocationX + checkTrue.Size.Width, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkTrueLabel);


                    checkFalse = new RadioButton();
                    checkFalse.Location = new Point(checkTrue.Location.X, checkTrue.Location.Y + checkTrue.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkFalse);

                    checkFalseLabel = new Label();
                    checkFalseLabel.Text = examQuestions[number].Question.Answers[1].Answer;
                    checkFalseLabel.Location = new Point(checkFalse.Location.X + incrementValueLocationX + checkFalse.Size.Width, checkTrue.Location.Y + checkTrue.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkFalseLabel);

                    break;

                case 3:
                    QuestionPanel.Controls.Clear(); //to remove all controls
                    questionAnswer = new RichTextBox();
                    questionAnswer.Location = new Point(questioncontent.Location.X + incrementValueLocationX, questioncontent.Location.Y + incrementValueLocationY + questioncontent.Height);
                    questionAnswer.Height = 150;
                    questionAnswer.Width = 550;
                    QuestionPanel.Controls.Add(questionAnswer);
                    break;
            }
            

        }
        

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (count <= (examQuestions.Count - 1))
            {
            StudentAnswer sa = new StudentAnswer();
            int type = examQuestions[count].Question.Type;
            sa.Q = examQuestions[count].Question;
            //sa.Q.Type = type;
            //sa.S = StudentDAL.GetById(student_id);
            sa.S = MyStudent.Student;
            sa.Solved = true;
            //how to get the exam
            sa.E = MyExam.Exam;

            switch (type)
            {
                case 1:
                    if (!choiceA.Checked && !choiceB.Checked && !choiceC.Checked && !choiceD.Checked)
                    {
                        MessageBox.Show("Please choose the correct answer");
                    }
                    else
                    {
                            //how to get the answer from the question

                            QuestionAnswer answer1 = examQuestions[count].Question.Answers[0];
                            QuestionAnswer answer2 = examQuestions[count].Question.Answers[1];
                            QuestionAnswer answer3 = examQuestions[count].Question.Answers[2];
                            QuestionAnswer answer4 = examQuestions[count].Question.Answers[3];

               
                       
                        sa.Qa = new QuestionAnswer();

                        if (choiceA.Checked)
                            sa.Qa.Answer = choiceALabel.Text;
                        else if (choiceB.Checked)
                            sa.Qa.Answer = choiceBLabel.Text;
                        else if (choiceC.Checked)
                            sa.Qa.Answer = choiceCLabel.Text;
                        else
                            sa.Qa.Answer = choiceDLabel.Text;

                    }
                    break;
                case 2:
                    if (!checkTrue.Checked && !checkFalse.Checked)
                    {
                        MessageBox.Show("Please choose the correct answer");
                    }
                    else
                    {
                        QuestionAnswer trueAnswer = examQuestions[count].Question.Answers[0];
                        QuestionAnswer falseAnswer = examQuestions[count].Question.Answers[1];
                            
                        sa.Qa = new QuestionAnswer();

                        if (checkTrue.Checked)
                            sa.Qa.Answer = checkTrueLabel.Text;
                        else if (checkFalse.Checked)
                            sa.Qa.Answer = checkFalseLabel.Text;

                    }
                    break;
                case 3:
                    if (String.IsNullOrEmpty(questionAnswer.Text))
                    {
                        MessageBox.Show("Please add the answer");
                    }
                    else
                    {
                            QuestionAnswer essayAnswer = examQuestions[count].Question.Answers[0];

                        essayAnswer.Answer = questionAnswer.Text;
                        sa.Qa = new QuestionAnswer();
                            sa.Qa.Answer = questionAnswer.Text;
                            
                    }
                    break;
            }


            //add in Student_Question_Exam
            StudentAnswerDAL.Add(sa);

            if (++count <= (examQuestions.Count - 1))
            {
                showQuestion(count);    
            }
            
            }

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //grading procedure
            /*
            //string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(DBLayer.connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "Exam_Correction";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@Exam_ID", exam_id);
            sqlCommand.Parameters.AddWithValue("@Exam_ID", MyExam.Exam.Id);
            //sqlCommand.Parameters.AddWithValue("@Student_ID", student_id);
            sqlCommand.Parameters.AddWithValue("@Student_ID", MyStudent.Student.Id);
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            */

            StudentDAL.setFinishExam(MyExam.Exam.Id);
            Student_Profile f = new Student_Profile();
            f.Show();
            this.Close();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            if (--count > 0)
            {
                showQuestion(count);
            }
        }
    }
}
