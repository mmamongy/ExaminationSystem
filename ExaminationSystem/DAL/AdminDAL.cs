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
    class AdminDAL
    { 
        public static Admin GetById(int id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Administrator where adm_ID = {0}", id));
            Admin result = null;
            if (dt.Rows.Count > 0)
            {
                string userName = dt.Rows[0]["adm_userName"].ToString();
                string name = dt.Rows[0]["adm_name"].ToString();
                string email = dt.Rows[0]["adm_email"].ToString();
                string pass = dt.Rows[0]["adm_pass"].ToString();
                result = new Admin(id, userName ,name , email, pass );
            } 
            return result;
        }

        public static Admin GetByUserNameAndPassword(string userName, string pass)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Administrator where adm_userName = '{0}' and adm_pass = '{1}'", userName, pass));
            Admin result = null;
            if (dt.Rows.Count > 0)
            {
                int id = int.Parse(dt.Rows[0]["adm_ID"].ToString());
                string name = dt.Rows[0]["adm_name"].ToString();
                string email = dt.Rows[0]["adm_email"].ToString();
                result = new Admin(id , userName, name,email, pass);
            }
            return result;
        }

        public static void Add(string userName, string name, string email, string pass)
        {
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "InsertIntoAdministrator";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userName", userName);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", pass);
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
