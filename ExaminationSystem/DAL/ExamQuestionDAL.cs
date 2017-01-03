using ExaminationSystem.Collection;
using ExaminationSystem.database;
using ExaminationSystem.entities;
using ExaminationSystem.instatnce;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class ExamQuestionDAL
    {
        public static int GenerateExam(int numMCQ, int numTF, int numEssay, Course course)
        {
            Admin adm = new Admin();//el admin ele 3mal login
            adm.Id = 1;
            Exam exam = ExamDAL.Add(course, adm);///////////////////
            ////////////////////////////////////
            int result = 0;
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "Exam_generation";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Multiple_choices_num", numMCQ);
            sqlCommand.Parameters.AddWithValue("@Tru_False_num", numTF);
            sqlCommand.Parameters.AddWithValue("@Essay_Questions_num", numEssay);
            sqlCommand.Parameters.AddWithValue("@courseID", course.Id);
            sqlCommand.Connection = sqlConnection;
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public static ExamQuestionCollection GetExamQuestions(int exam_id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Question_Exam where FK_ExamID = {0}", exam_id));
            List<int> questions_id = new List<int>();
            ExamQuestionCollection questions = new ExamQuestionCollection();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    questions_id.Add(Convert.ToInt32(dt.Rows[i]["FK_QuestionID"].ToString()));
                }
            }

            for (int i = 0; i < questions_id.Count; i++)
            {
                DataTable dt2 = DBLayer.ExecuteQuery(string.Format("select * from Question where id = {0}", questions_id[i]));

                Question q = new Question();
                q.Id = Convert.ToInt32(dt2.Rows[0]["id"].ToString());
                q.QuestionText = dt2.Rows[0]["question_text"].ToString();

                q.Course = new Course();
                q.Course.Id = Convert.ToInt32(dt2.Rows[0]["Course_ID"].ToString());

                q.Modelanswer = new QuestionAnswer();
                q.Modelanswer.ID = Convert.ToInt32(dt2.Rows[0]["question_modelAns"].ToString());

                q.Answers = new QuestionAnswerCollection();
                q.Type = Convert.ToInt32(dt2.Rows[0]["question_type"].ToString());
                DataTable dt3 = DBLayer.ExecuteQuery(string.Format("select * from Quest_ans where Quest_ID = {0}", q.Id));

                for (int j = 0; j < dt3.Rows.Count; j++)
                {
                    QuestionAnswer qa = new QuestionAnswer();
                    qa.ID = Convert.ToInt32(dt3.Rows[j]["id"].ToString());
                    qa.Answer = dt3.Rows[j]["text"].ToString();
                    q.Answers.Add(qa);
                }
                ExamQuestion qe = new ExamQuestion();
                qe.Question = q;
                qe.Exam = MyExam.Exam;
                questions.Add(qe);
            }
            return questions;
        }
    }
}
