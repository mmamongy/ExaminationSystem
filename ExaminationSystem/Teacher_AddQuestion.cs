using ExaminationSystem.DAL;
using ExaminationSystem.database;
using ExaminationSystem.entities;
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
    public partial class Teacher_AddQuestion : Form
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

        public Teacher_AddQuestion()
        {
            InitializeComponent();
        }

        private void Teacher_AddQuestion_Load(object sender, EventArgs e)
        {
            //Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True
           // DBLayer.connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            DBLayer.connection = @"Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(DBLayer.connection);

            //connect to database to get types of questions available and set combobox to their values
            getQuestionTypesAvailable(sqlConnection);
            getCoursesAvailable(sqlConnection);
            //draw the question type
            //when add is pressed validate if the answer is selected or not
            //for True of False and MCQ, one must be chosen
            //for essay, richtextbox must not be empty
        }

        private void getQuestionTypesAvailable(SqlConnection sqlConnection)
        {
            SqlCommand sqlCommandM = new SqlCommand("select * from QuestionType", sqlConnection);
            SqlDataAdapter sqlAdapterM = new SqlDataAdapter(sqlCommandM);

            DataTable questionTypeTable = new DataTable();
            sqlAdapterM.Fill(questionTypeTable);

            QuestionType.DisplayMember = "Name";
            QuestionType.ValueMember = "id";
            QuestionType.DataSource = questionTypeTable;
        }

        private void getCoursesAvailable(SqlConnection sqlConnection)
        {
            SqlCommand sqlCommandM = new SqlCommand("select * from Course", sqlConnection);
            SqlDataAdapter sqlAdapterM = new SqlDataAdapter(sqlCommandM);

            DataTable courseTable = new DataTable();
            sqlAdapterM.Fill(courseTable);

            QuestionCourse.DisplayMember = "course_Name";
            QuestionCourse.ValueMember = "id";
            QuestionCourse.DataSource = courseTable;
        }

        private void QuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int incrementValueLocationX = 10;
            int incrementValueLocationY = 10;

            int type = (int)QuestionType.SelectedValue;
            TextBox questioncontent = new TextBox();
            questioncontent.Text = "Enter Question";
            questioncontent.Location = new Point(QuestionType.Location.X, incrementValueLocationY + QuestionType.Height + QuestionType.Location.X);
            questioncontent.AutoSize = true;
            Controls.Add(questioncontent);
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

        private void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            Question newQuestion = new Question();
            int type = (int)QuestionType.SelectedValue;
            newQuestion.Type = type;
            switch (type)
            {
                case 1:
                    if (!choiceA.Checked && !choiceB.Checked && !choiceC.Checked &&!choiceD.Checked)
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

                        newQuestion.Answers = new List<QuestionAnswer>();
                        newQuestion.Answers.Add(answer1);
                        newQuestion.Answers.Add(answer2);
                        newQuestion.Answers.Add(answer3);
                        newQuestion.Answers.Add(answer4);

                        newQuestion.Modelanswer = new QuestionAnswer();

                        if (choiceA.Checked)
                            newQuestion.Modelanswer.Answer = choiceALabel.Text;
                        else if (choiceB.Checked)
                            newQuestion.Modelanswer.Answer = choiceBLabel.Text;
                        else if (choiceC.Checked)
                            newQuestion.Modelanswer.Answer = choiceCLabel.Text;
                        else
                            newQuestion.Modelanswer.Answer = choiceDLabel.Text;

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

                        newQuestion.Answers = new List<QuestionAnswer>();

                        newQuestion.Answers.Add(trueAnswer);
                        newQuestion.Answers.Add(falseAnswer);
                        newQuestion.Modelanswer = new QuestionAnswer();


                        if (checkTrue.Checked)
                            newQuestion.Modelanswer.Answer = checkTrueLabel.Text;
                        else if (checkFalse.Checked)
                            newQuestion.Modelanswer.Answer = checkFalseLabel.Text;

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
                        newQuestion.Answers = new List<QuestionAnswer>();
                        newQuestion.Modelanswer = new QuestionAnswer();

                        newQuestion.Answers.Add(essayAnswer);
                        newQuestion.Modelanswer.Answer = "";

                    }
                    break;
            }

            newQuestion.Course = new Course();
            newQuestion.Course.Id = (int)QuestionCourse.SelectedValue;
            QuestionDAL.Add(newQuestion);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
