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
    class InstructorDAL
    {
        public static Instructor GetByUserNameAndPassword(string userName, string pass)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Instructor where ins_userName = '{0}' and ins_password = '{1}'", userName, pass));
            Instructor result = null;
            if (dt.Rows.Count > 0)
            {
                string name = dt.Rows[0]["ins_Name"].ToString();
                int id = int.Parse(dt.Rows[0]["id"].ToString());
                int age = int.Parse(dt.Rows[0]["ins_age"].ToString());
                string address = dt.Rows[0]["ins_address"].ToString();
                string phone = dt.Rows[0]["ins_phone"].ToString();
                string email = dt.Rows[0]["ins_email"].ToString();
                //bool isout = dt.Rows[0]["isout"].ToString();
                int adID =int.Parse(dt.Rows[0]["FK_AdminID"].ToString());
                Admin ad = AdminDAL.GetById(adID);
                int deptID = int.Parse(dt.Rows[0]["FK_DeptID"].ToString());
                Department dp = DepartmentDAL.GetById(deptID);
                result = new Instructor(userName,name,age,phone,address,email,ad,dp,pass);
            }
            return result;
        }
   
        public static int Add(string userName,string name, int age, string address, string phone, string email, bool is_out, int adID, int depID, string pass)
        {
            int result = 0;
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "insertInstructor";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userName", userName);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@age", age);
            sqlCommand.Parameters.AddWithValue("@address", address);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@flag", is_out);
            sqlCommand.Parameters.AddWithValue("@adminID", adID);
            sqlCommand.Parameters.AddWithValue("@dept", depID);
            sqlCommand.Parameters.AddWithValue("@password", pass);
            sqlCommand.Connection = sqlConnection;
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
    }
}
