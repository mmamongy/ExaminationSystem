using ExaminationSystem.database;
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
    class SessionStudentAdminDAL
    {
        public static int Add(ExamSession session, Admin admin, Student student)
        {
            int result = 0;
            //string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(DBLayer.connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "insertExamSessionStudentAdmin";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@session", session.Id);
            sqlCommand.Parameters.AddWithValue("@stID", student.Id);
            sqlCommand.Parameters.AddWithValue("@adminID", admin.Id);
            sqlCommand.Connection = sqlConnection;
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
    }
}
