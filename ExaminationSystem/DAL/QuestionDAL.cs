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
                for (int i=0; i<answers.Count; i++)
            {
                answers[i].ID = QuestionAnswerDAL.AddAnswer(answers[i]);
            }
            modelanswer.ID = QuestionAnswerDAL.AddAnswer(modelanswer);
                return Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Question values('{0}', {1}, {2}, {3});select @@identity", text, modelanswer.ID, type, course.Id)));
        }

        public static void Add(Question q)
        {
            q.Id = Add(q.QuestionText, q.Type, q.Modelanswer, q.Answers, q.Course);
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
                int courseID = Convert.ToInt32( dt.Rows[0]["Course_ID"].ToString());
                QuestionAnswer questans = new QuestionAnswer();
                questans.Answer = modelAns;
                Course course = new Course();
                course.Id = courseID;
                Question quest = new Question(questID,text,type,questans,course);
                result.Add(quest);
            }
            return result;
        }
    }
}
