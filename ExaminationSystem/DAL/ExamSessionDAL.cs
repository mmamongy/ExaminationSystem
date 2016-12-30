using ExaminationSystem.Collection;
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
    class ExamSessionDAL
    {
        public static ExamSession GetById(int id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from ExamSession where session_ID = {0}", id));
            ExamSession result = new ExamSession();
            if (dt.Rows.Count > 0)
            {
                DateTime date = Convert.ToDateTime(dt.Rows[0]["session_date"]);
                Exam exam = new Exam();
                exam.Id = Convert.ToInt32(dt.Rows[0]["FK_ExamID"]);
                Admin adm = new Admin();
                adm.Id = Convert.ToInt32(dt.Rows[0]["FK_AdminID"]);
                result.Id = id;
                result.SessionDate = date;
                result.Exam = exam;
                result.Admin = adm;
            }
            return result;
        }

        public static void Add(DateTime date, Admin adm, int examID)
        {
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "insertExamSession";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@sessionDate", date);
            sqlCommand.Parameters.AddWithValue("@examId", examID);
            sqlCommand.Parameters.AddWithValue("@adminId", adm.Id);
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static ExamSessionCollection SelectAll()
        {
            DataTable dt = DBLayer.ExecuteQuery("select * from ExamSession");
            ExamSessionCollection result = new ExamSessionCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Exam exam = new Exam();
                Admin adm = new Admin();
                int sessionID = Convert.ToInt32(dt.Rows[i]["session_ID"]);
                DateTime dateTime = Convert.ToDateTime(dt.Rows[i]["session_date"]);
                exam.Id = Convert.ToInt32(dt.Rows[i]["FK_ExamID"]);
                adm.Id = Convert.ToInt32(dt.Rows[i]["FK_AdminID"]);
                ExamSession session = new ExamSession(sessionID, dateTime, exam, adm);
                result.Add(session);
            }
            return result;
        }
    }
}
