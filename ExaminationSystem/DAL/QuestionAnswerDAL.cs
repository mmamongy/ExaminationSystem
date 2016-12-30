using ExaminationSystem.database;
using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class QuestionAnswerDAL
    {

        public static int AddAnswer(QuestionAnswer ans)
        {
            return Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Quest_ans(text) values('{0}');select @@identity", ans.Answer)));
        }
        
    }
}
