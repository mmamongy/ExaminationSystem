using ExaminationSystem.Collection;
using ExaminationSystem.database;
using ExaminationSystem.entities;
using ExaminationSystem.instatnce;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL
{
    class StudentDAL
    {
        public static Student GetByUserNameAndPassword(string userName , string pass)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Student where st_userName = '{0}' and st_password = '{1}'", userName,pass));
            Student result = null;
            if (dt.Rows.Count > 0)
            {
                int id = int.Parse(dt.Rows[0]["id"].ToString());
                string name = dt.Rows[0]["st_Name"].ToString();
                int age = int.Parse(dt.Rows[0]["st_age"].ToString());
                string address = dt.Rows[0]["st_address"].ToString();
                string phone = dt.Rows[0]["st_phone"].ToString();
                string email = dt.Rows[0]["st_email"].ToString();
                int adID = int.Parse(dt.Rows[0]["FK_AdminID"].ToString());
                Admin ad = AdminDAL.GetById(adID);
                int deptID = int.Parse(dt.Rows[0]["FK_DeptID"].ToString());
                Department dp = DepartmentDAL.GetById(deptID);
                result = new Student(userName,name,age, address ,phone,email,pass , ad,dp);
                result.Id = id;
            }
            return result;
        }

        public static bool SetInstructor(Student stu)
        {
            bool flag = false;
            int result = 0;
            string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.CommandText = "Update_Student_Set_Instructor";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Std_ID", stu.Id);
            sqlCommand.Parameters.AddWithValue("@flag", true);
            sqlCommand.Connection = sqlConnection;
            result= sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(result==1)
            {
                flag = true;
            }
            return flag;
        }

        public static int Add(string userName, string name , int age, string address, string phone, string email, bool ins_flag, int adID , int depID , string pass)
        {
            int result = 0;
            if (ins_flag==false)
            {
                string connection = @"Data Source=BASMA-HP\SQLEXPRESS;Initial Catalog=ExaminationSystems;Integrated Security=True";
                SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand();
                sqlConnection.Open();
                sqlCommand.CommandText = "insertStudent";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@userName", userName);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@age", age);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@flag", ins_flag);
                sqlCommand.Parameters.AddWithValue("@adminID", adID);
                sqlCommand.Parameters.AddWithValue("@dep", depID);
                sqlCommand.Parameters.AddWithValue("@password", pass);
                sqlCommand.Connection = sqlConnection;
                result= sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                result = InstructorDAL.Add(userName, name, age, address, phone, email, false, adID, depID, pass);
            }
            return result;
        }

        public static Student GetById(int id)
        {
            DataTable dt = DBLayer.ExecuteQuery(string.Format("select * from Student where id = {0}", id));
            Student result =null;
            if (dt.Rows.Count > 0)
            {
                string username = dt.Rows[0]["st_userName"].ToString();
                string name = dt.Rows[0]["st_Name"].ToString();
                int age = Convert.ToInt32(dt.Rows[0]["st_age"]);
                string address = dt.Rows[0]["st_address"].ToString();
                string phone = dt.Rows[0]["st_phone"].ToString();
                string email = dt.Rows[0]["st_email"].ToString();
                string password = dt.Rows[0]["st_password"].ToString();

                Admin ad = new Admin();
                ad.Id = Convert.ToInt32(dt.Rows[0]["FK_AdminID"]);

                Department dept = new Department();
                dept.Id = Convert.ToInt32(dt.Rows[0]["FK_DeptID"]);

                result = new Student(id,username, name, age, address, phone, email, password, ad, dept);
            }
            return result;
        }
        
        public static bool setFinishExam(int exam_id)
        {
            return DBLayer.ExecuteNonQuery(string.Format("update Exam set flag = '{1}' where id = {0}", exam_id,true)) > 0;
        }


    // get availabe exams for student without course type
    public static ExamCollection GetAvailabeExams(int id)
    {
        ExamCollection result = new ExamCollection();
            string s = String.Format(
" select  DISTINCT * from Exam, ExamSession "+
" where {0} not in (select Student_Exam.FK_StudID from Student_Exam where Exam.id "+
" <> Student_Exam.FK_ExamID) and Exam.flag <> 0 "+
            " and Exam.id in (Select ExamSession.FK_ExamID from ExamSession) "+
            " and Exam.id in (select Exam_Course_Instructor.FK_ExamID "+
                           "from Exam_Course_Instructor,Course_Student "+
                          "where Course_Student.FK_CourseID = Exam_Course_Instructor.FK_CourseID) "+
            " and Exam.id = ExamSession.FK_ExamID ", id);
            DataTable dt = DBLayer.ExecuteQuery(s);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Admin admin = new Admin(int.Parse(dt.Rows[i]["FK_AdminID"].ToString()));
            int ids = int.Parse(dt.Rows[i]["session_ID"].ToString());
            ExamSession examSession = new ExamSession(ids,DateTime.Parse(dt.Rows[i]["session_date"].ToString()), new Exam(int.Parse(dt.Rows[i]["id"].ToString()), true, admin), admin);
            Exam exam = new Exam(Convert.ToInt32(dt.Rows[i]["id"]), (bool)dt.Rows[i]["flag"], admin);
            exam.ExamSessions = new ExamSessionCollection();
            exam.ExamSessions.Add(examSession);
            result.Add(exam);
         }
            result = RearangeExams(result);
            result = getExamCourse(result);
        return result;
        }

        private static ExamCollection getExamCourse(ExamCollection exams)
        {
            for (int i = 0; i < exams.Count; i++)
            {
                Course c = new Course();
                string s = String.Format("select Course.course_Name , Course.id from Course , Exam_Course_Instructor where  Exam_Course_Instructor.FK_ExamID = {0} and Course.id = Exam_Course_Instructor.FK_CourseID", exams[i].Id);
                DataTable dt = DBLayer.ExecuteQuery(s);
                if (dt.Rows.Count > 0)
                {
                    c.Id = int.Parse(dt.Rows[0]["id"].ToString());
                    c.Name = dt.Rows[0]["course_Name"].ToString();
                }
                exams[i].Course = c;
            }
            return exams;
        }
        
        private static ExamCollection RearangeExams(ExamCollection exams)
        {
            ExamCollection result = new ExamCollection();
            for (int i=0; i<exams.Count; i++)
            {
                for (int j=0; j<exams.Count; j++)
                {
                    if ((exams[i].ExamSessions.Count!=0 && exams[j].ExamSessions.Count != 0) &&exams[i].ExamSessions[0].Id != exams[j].ExamSessions[0].Id
                        && exams[i].Id == exams[j].Id)
                    {
                        exams[i].ExamSessions.Add(exams[j].ExamSessions[0]);
                        exams[j].ExamSessions.RemoveAt(0); 
                       
                    }
                }

            }
            for (int i=0;i<exams.Count; i++) { 
                if (exams[i].ExamSessions.Count == 0)
                {
                    exams.RemoveAt(i);
                }
            }
            result = exams;
            return result;
        }
        public static  StudentGradeCollection getStudentGrades(int id)
        {
            StudentGradeCollection sgc = new StudentGradeCollection();
            string s = String.Format("select Course.course_Name, Course.id, Student_Exam.exam_garde , Student_Exam.FK_StudID  from Course, Student_Exam, Exam_Course_Instructor where Student_Exam.FK_StudID = 7 and Exam_Course_Instructor.FK_ExamID = Student_Exam.FK_ExamID and Student_Exam.FK_ExamID = Exam_Course_Instructor.FK_ExamID and Course.id = Exam_Course_Instructor.FK_CourseID", id);
            Student student = new Student();
            student.Id = 7;
            DataTable dt = DBLayer.ExecuteQuery(s);
            for( int i=0; i<  dt.Rows.Count; i++)
            {
                
                StudentGrades sss = new StudentGrades();
                Course c = new Course();
                c.Id = int.Parse(dt.Rows[i]["id"].ToString());
                c.Name = dt.Rows[i]["course_Name"].ToString();
                sss.Crs = c;
                sss.Grade = int.Parse(dt.Rows[i]["exam_garde"].ToString());
                sss.S = student;
                sgc.Add(sss);
            }

            return sgc;
        }
        
        public static StudentCollection SelectAll()
        {
            DataTable dt = database.DBLayer.ExecuteQuery("select * from Student");
            StudentCollection result = new StudentCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Department dept = new Department();
                Admin adm = new Admin();
                int id = Convert.ToInt32(dt.Rows[i]["id"]);
                string userName = dt.Rows[i]["st_userName"].ToString();
                string name = dt.Rows[i]["st_Name"].ToString();
                string address = dt.Rows[i]["st_address"].ToString();
                string phone = dt.Rows[i]["st_phone"].ToString();
                string email = dt.Rows[i]["st_email"].ToString();
                int age = Convert.ToInt32(dt.Rows[i]["st_age"]);
                int flag = Convert.ToInt32(dt.Rows[i]["ins_flag"]);
                adm.Id = Convert.ToInt32(dt.Rows[i]["FK_AdminID"]);
                dept.Id = Convert.ToInt32(dt.Rows[i]["FK_DeptID"]);
                string pass = dt.Rows[i]["st_password"].ToString();
                Student session = new Student(id,userName,name,age,address,phone,email,pass,adm,dept);
                result.Add(session);
            }
            return result;
        }

        public static bool DeleteById(int id)
        {
            SqlCommand sqlCommand = new SqlCommand(string.Format("delete from Student where id = {0}", id));
            return DBLayer.ExecuteNonQuery(sqlCommand) > 0;

        }
    }
}
