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

        TextBox choiceALabel;
        TextBox choiceBLabel;
        TextBox choiceCLabel;
        TextBox choiceDLabel;

        Label checkTrueLabel;
        Label checkFalseLabel;

        RichTextBox questionAnswer;

        int count=0;


        ExamQuestionCollection examQuestions;

        public Student_TakingExam()
        {
            InitializeComponent();
        }

        private void Student_TakingExam_Load(object sender, EventArgs e)
        {
            //Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True
            //Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True
            DBLayer.connection = @"Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(DBLayer.connection);

            //course_id should come as a parameter to the form in the first place
            //getExamQuestions(sqlConnection, course_id, student_id);
            MessageBox.Show(MyExam.Exam.ExamSessions[0].Id.ToString()+"   " + MyExam.Exam.Id.ToString());
             
             getExamQuestions(sqlConnection, 1, 1);

            do
            {
                showQuestion(count);
            }
            while (count <= examQuestions.Count - 1);
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
                    choiceA.Location = new Point(questioncontent.Location.X, questioncontent.Location.Y + questioncontent.Height+incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceA);

                    choiceALabel = new TextBox();
                    choiceALabel.Location = new Point(choiceA.Location.X + incrementValueLocationX + choiceA.Size.Width, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceALabel);


                    choiceB = new RadioButton();
                    choiceB.Location = new Point(questioncontent.Location.X, choiceA.Location.Y + choiceA.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceB);

                    choiceBLabel = new TextBox();
                    choiceBLabel.Location = new Point(choiceB.Location.X + incrementValueLocationX + choiceB.Size.Width, choiceA.Location.Y + choiceA.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceBLabel);


                    choiceC = new RadioButton();
                    choiceC.Location = new Point(questioncontent.Location.X, choiceB.Location.Y + choiceB.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceC);

                    choiceCLabel = new TextBox();
                    choiceCLabel.Location = new Point(choiceC.Location.X + incrementValueLocationX + choiceC.Size.Width, choiceB.Location.Y + choiceB.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceCLabel);


                    choiceD = new RadioButton();
                    choiceD.Location = new Point(questioncontent.Location.X, choiceC.Location.Y + choiceC.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceD);

                    choiceDLabel = new TextBox();
                    choiceDLabel.Location = new Point(choiceD.Location.X + incrementValueLocationX + choiceD.Size.Width, choiceC.Location.Y + choiceC.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(choiceDLabel);
                    break;

                case 2:
                    
                    QuestionPanel.Controls.Clear(); //to remove all controls
                    //all radio buttons should be in the same group
                    checkTrue = new RadioButton();
                    checkTrue.Location = new Point(questioncontent.Location.X, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkTrue);
                    
                    checkTrueLabel = new Label();
                    checkTrueLabel.Text = "True";
                    checkTrueLabel.Location = new Point(checkTrue.Location.X + incrementValueLocationX + checkTrue.Size.Width, questioncontent.Location.Y + questioncontent.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkTrueLabel);


                    checkFalse = new RadioButton();
                    checkFalse.Location = new Point(checkTrue.Location.X, checkTrue.Location.Y + checkTrue.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkFalse);
                    
                    checkFalseLabel = new Label();
                    checkFalseLabel.Text = "False";
                    checkFalseLabel.Location = new Point(checkFalse.Location.X + incrementValueLocationX + checkFalse.Size.Width, checkTrue.Location.Y + checkTrue.Height + incrementValueLocationY);
                    QuestionPanel.Controls.Add(checkFalseLabel);

                    break;

                case 3:
                    QuestionPanel.Controls.Clear(); //to remove all controls
                    questionAnswer = new RichTextBox();
                    questionAnswer.Location = new Point(questioncontent.Location.X + incrementValueLocationX, questioncontent.Location.Y+ incrementValueLocationY + questioncontent.Height);
                    questionAnswer.Height = 150;
                    questionAnswer.Width = 550;
                    QuestionPanel.Controls.Add(questionAnswer);
                    break;
            }
         
        }

        private void getExamQuestions(SqlConnection sqlConnection, int course_id, int student_id)
        {
            //get examsession id
            SqlCommand sqlCommandM = new SqlCommand(string.Format("select FK_ExamSessionID from Course_ExamSession_Admin inner join ExamSession_Student_Admin on ExamSession_Student_Admin.FK_Exam_ExamSessionID = Course_ExamSession_Admin.FK_Exam_ExamSessionID where FK_CourseID = {0} and FK_StudentID = {1}", course_id, student_id), sqlConnection);
            SqlDataAdapter sqlAdapterM = new SqlDataAdapter(sqlCommandM);
            DataTable resultTable = new DataTable();
            sqlAdapterM.Fill(resultTable);

            //get exam id
            sqlCommandM.CommandText = string.Format("select FK_ExamID from ExamSession where session_ID = {0}", resultTable.Rows[0]);
            sqlAdapterM.SelectCommand = sqlCommandM;
            sqlAdapterM.Fill(resultTable);

            //get questions ids of exam
            sqlCommandM.CommandText = string.Format("select FK_QuestionID from Question_Exam where FK_ExamID = {0}", resultTable.Rows[0]);
            sqlAdapterM.SelectCommand = sqlCommandM;
            sqlAdapterM.Fill(resultTable);


            //get questions 
            SqlCommand sqlCommandQ = new SqlCommand(string.Format("select * from Question where id = {0}", resultTable.Rows[0]), sqlConnection);
            SqlDataAdapter sqlAdapterQ = new SqlDataAdapter(sqlCommandQ);
            DataTable resultAnswerTable = new DataTable();
            sqlAdapterM.Fill(resultTable);

            //get questions answers
            sqlCommandM.CommandText = string.Format("select * from Question_ans where Quest_ID = {0}", resultTable.Rows[0]);
            sqlAdapterM.SelectCommand = sqlCommandM;
            sqlAdapterM.Fill(resultTable);

            examQuestions = new ExamQuestionCollection();

            for (int i = 0; i < resultTable.Rows.Count; i++)
            {
                DataRow dr = resultTable.Rows[i];
                ExamQuestion q = new ExamQuestion();
                q.Exam = new Exam();
                q.Exam.Id = Convert.ToInt32(dr["id"]);
                q.Question = new Question();
                q.Question.Id = Convert.ToInt32(dr["id"]);
                q.Question.QuestionText = dr["question_text"].ToString();

                q.Question.Modelanswer = new QuestionAnswer();
                q.Question.Modelanswer = (QuestionAnswer)dr["question_modelAns"];

                q.Question.Type = Convert.ToInt32(dr["question_type"]);

                q.Question.Course = new Course();
                q.Question.Course.Id = Convert.ToInt32(dr["Course_ID"]);

                q.Answers = new QuestionAnswerCollection();
                for (int j = 0; j < resultAnswerTable.Rows.Count; j++)
                {
                    DataRow dra = resultAnswerTable.Rows[i];
                    QuestionAnswer qa = new QuestionAnswer();
                    qa.ID = Convert.ToInt32(dr["id"]);
                    qa.Answer = dr["text"].ToString();
                    q.Answers.Add(qa);
                }

                examQuestions.Add(q);
            }

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            StudentAnswer sa = new StudentAnswer();
            int type = examQuestions[count].Question.Type;
            sa.Q = examQuestions[count].Question;
            //sa.S = StudentDAL.GetById(student_id);
            sa.S = StudentDAL.GetById(1);
            sa.Solved = true;
            //how to get the exam
            //sa.E = ExamDAL.getById(ex)

            switch (type)
            {
                case 1:
                    if (!choiceA.Checked && !choiceB.Checked && !choiceC.Checked && !choiceD.Checked)
                    {
                        MessageBox.Show("Please choose the correct answer");
                    }
                    else
                    {

                        QuestionAnswer answer1 = new QuestionAnswer();
                        QuestionAnswer answer2 = new QuestionAnswer();
                        QuestionAnswer answer3 = new QuestionAnswer();
                        QuestionAnswer answer4 = new QuestionAnswer();

                        answer1.Answer = choiceALabel.Text;
                        answer2.Answer = choiceBLabel.Text;
                        answer3.Answer = choiceCLabel.Text;
                        answer4.Answer = choiceDLabel.Text;

                        //get student
                        //get examsessions
                        //get exam
                        //get exam from examquestion
                        //get question from exams of student
                        
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
                        QuestionAnswer trueAnswer = new QuestionAnswer();
                        QuestionAnswer falseAnswer = new QuestionAnswer();

                        trueAnswer.Answer = checkTrueLabel.Text;
                        falseAnswer.Answer = checkFalseLabel.Text;

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

                        QuestionAnswer essayAnswer = new QuestionAnswer();

                        essayAnswer.Answer = questionAnswer.Text;
                        sa.Qa = new QuestionAnswer();

                        sa.Qa.Answer = "";

                    }
                    break;
            }


            //add in Student_Question_Exam
            StudentAnswerDAL.Add(sa);
            count++;

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "Exam_Correction";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@Exam_ID", exam_id);
            sqlCommand.Parameters.AddWithValue("@Exam_ID", 1);
            //sqlCommand.Parameters.AddWithValue("@Student_ID", student_id);
            sqlCommand.Parameters.AddWithValue("@Student_ID", 1);
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            count--;
        }
    }
}
