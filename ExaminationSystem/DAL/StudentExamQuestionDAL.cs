using ExaminationSystem.database;
using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class StudentExamQuestionDAL
    {
        public static int Add(int stdID,int examID,QuestionAnswer answer)
        {
            return Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Student_Exam_Question values('{0},{1},{2},{3},{4},{5}');select @@identity", stdID,examID,0,false,answer,0)));
        }
    }
}
