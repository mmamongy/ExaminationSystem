using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExaminationSystem.database
{
    static class DBLayer
    {
        //add your own connection here
        //public static string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
        //public static string connection = @"Data Source=FATMA\FATMAGAMAL;Initial Catalog=ExaminationSystems;Integrated Security=True";
        //public static string connection = @"Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True";
        public static string connection = @"Data Source=.;Initial Catalog=ExaminationSystems;Integrated Security=True";

        public static DataTable ExecuteQuery(string selectCommand)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(selectCommand, connection);

            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(SqlCommand sqlCommand)
        {
            int result;
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }

        public static object ExecuteScalar(string selectCommand)
        {
            object result;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection);
            sqlConnection.Open();
            result = sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return result;
        }
    }
}
