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
    class ExamDAL
    {
        public static Exam Add(Course course, Admin adm)
        {
            Exam exam = new Exam(course, false, adm);
            exam.Id = Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Exam values('{0}',{1});select @@identity", exam.IsFinished, adm.Id)));
            return exam;
        }

        public static Exam getById(int id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Exam where id = {0}", id));
            Exam result = null;
            if (dt.Rows.Count > 0)
            {
                bool isFinished = Convert.ToBoolean(dt.Rows[0]["flag"]);
                Admin ad = new Admin();
                ad.Id = Convert.ToInt32(dt.Rows[0]["FK_AdminID"]);
                
                result = new Exam(id, isFinished, ad);
            }
            return result;
        }

        public static ExamCollection getAll(Admin adm)
        {
            DataTable dt = database.DBLayer.ExecuteQuery("select * from Exam");
            ExamCollection result = new ExamCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int examId = Convert.ToInt32(dt.Rows[i]["id"]);
                bool flag = Convert.ToBoolean(dt.Rows[i]["flag"]);
                adm.Id = Convert.ToInt32(dt.Rows[i]["FK_AdminID"]);

                Exam exam = new Exam(examId, flag, adm);
                result.Add(exam);
            }
            return result;
        }
    }
}
