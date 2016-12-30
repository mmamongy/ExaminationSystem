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
    static class CourseDAL
    {
        public static int Add(string name, Department dept)
        {
            int result = 0;
            string s = string.Format("INSERT INTO Course(course_Name, FK_department) VALUES ('{0}' , {1})", name, dept.Id);
            SqlCommand sqlCommand = new SqlCommand(s);
            database.DBLayer.ExecuteNonQuery(sqlCommand);
            Console.WriteLine("RESULTTT  " + result);
            return result;
        }
        public static CourseCollection SelectAll()
        {
            DataTable dt = database.DBLayer.ExecuteQuery("select * from Course");
            CourseCollection result = new CourseCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int courseId = Convert.ToInt32(dt.Rows[i]["id"]);
                string courseName = dt.Rows[i]["course_Name"].ToString();
                int deptid = int.Parse(dt.Rows[i]["FK_department"].ToString());
                Course c = new Course(courseId, courseName, deptid);
                result.Add(c);
            }
            return result;
        }
        public static List<bool> DeleteSomeids(CourseCollection c)
        {
            List<bool> b = new List<bool>();
            for (int i = 0; i < c.Count; i++)
            {
                SqlCommand sqlCommand = new SqlCommand(string.Format("delete from Course where id = {0}", c[i].Id));
                b.Add(DBLayer.ExecuteNonQuery(sqlCommand) > 0);
            }
            return b;

        }
        public static bool DeleteById(int id)
        {   
                SqlCommand sqlCommand = new SqlCommand(string.Format("delete from Course where id = {0}", id));
                return DBLayer.ExecuteNonQuery(sqlCommand) > 0;
         
        }
        public static bool Update(Course c)
        {
            SqlCommand sqlCommand = new SqlCommand(string.Format("UPDATE Course set course_Name = '{0}', FK_department = {2} where id = {1}", c.Name, c.Id, c.Deparment.Id));
            return DBLayer.ExecuteNonQuery(sqlCommand) > 0;
        }



    }
}
