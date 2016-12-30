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
    class DepartmentDAL
    {
        public static Department GetById(int id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Department where id = {0}", id));
            Department result = null;
            if (dt.Rows.Count > 0)
            {
                string name = dt.Rows[0]["dept_Name"].ToString();
                result = new Department(id, name);
            }
            return result;
        }

        public static DepartmentCollection GetAll()
        {
            DataTable dt = DBLayer.ExecuteQuery("Select * from Department");
            DepartmentCollection result = new DepartmentCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int departmentID = Convert.ToInt32(dt.Rows[i]["id"]);
                string deptName = dt.Rows[i]["dept_Name"].ToString();
                Department d = new Department(departmentID, deptName);
                result.Add(d);
            }
            return result;
        }
       

    }
}
