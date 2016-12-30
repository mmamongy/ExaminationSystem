using ExaminationSystem.entities;
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
    }
}
