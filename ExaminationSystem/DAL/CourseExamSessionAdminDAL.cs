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
    class CourseExamSessionAdminDAL
    {
        public static int GenerateExamSessionForCourse(ExamSession examSession, Admin adm, Course course)
        {
            int result = 0;
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "insertCourse_ExamSession_Admin";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@courseID", course.Id);
            sqlCommand.Parameters.AddWithValue("@examSession", examSession.Id);
            sqlCommand.Parameters.AddWithValue("@adminID", adm.Id);
            sqlCommand.Connection = sqlConnection;
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
    }
}
