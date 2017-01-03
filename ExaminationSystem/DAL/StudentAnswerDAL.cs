using ExaminationSystem.database;
using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class StudentAnswerDAL
    {

        public static StudentAnswer Add(StudentAnswer sa)
        {
            sa.Id = Convert.ToInt32(DBLayer.ExecuteScalar(string.Format("insert into Student_Exam_Question values({0}, {1}, {2}, '{3}', '{4}', {5});select @@identity", sa.S.Id, sa.E.Id, sa.Q.Id, sa.Solved, sa.Qa.Answer, sa.Q.Id)));
            return sa;
        }
    }
}
