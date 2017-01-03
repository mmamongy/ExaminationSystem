using ExaminationSystem.Collection;
using ExaminationSystem.database;
using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class QuestionDAL
    {

        public static int Add(string text, int type, QuestionAnswer modelanswer, List<QuestionAnswer> answers, Course course)
        {
            return Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Question values('{0}', {1}, {2}, {3});select @@identity", text, modelanswer.ID, type, course.Id)));
        }

        public static void Add(Question q)
        {
            q.Id = Add(q.QuestionText, q.Type, q.Modelanswer, q.Answers, q.Course);

            for (int i = 0; i < q.Answers.Count; i++)
            {
                q.Answers[i].ID = QuestionAnswerDAL.AddAnswer(q, q.Answers[i]);
            }
            //q.Modelanswer.ID = QuestionAnswerDAL.AddAnswer(q, q.Modelanswer);
        }

        public static QuestionCollection GetByType(int type)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Question where question_type = {0}", type));
            QuestionCollection result = new QuestionCollection();
            if (dt.Rows.Count > 0)
            {
                int questID = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                string text = dt.Rows[0]["question_text"].ToString();
                string modelAns = dt.Rows[0]["question_modelAns"].ToString();
                int courseID = Convert.ToInt32(dt.Rows[0]["Course_ID"].ToString());
                QuestionAnswer questans = new QuestionAnswer();
                questans.Answer = modelAns;
                Course course = new Course();
                course.Id = courseID;
                Question quest = new Question(questID, text, type, questans, course);
                result.Add(quest);
            }
            return result;
        }


        public static string GetQuestionTypeName(int type)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from QuestionType where id = {0}", type));
            string result = "";
            if (dt.Rows.Count > 0)
            {
                result = dt.Rows[0]["Name"].ToString();
            }
            return result;
        }
    }
}
