using ExaminationSystem.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Exam
    {
        Course course;
        int id;
        bool isFinished; // is it possible to add more questions or it's finshed; 
        Admin admin;
        ExamSessionCollection examSessions;
        public Exam(int id, bool isFinished, Admin admin)
        {
            this.id = id;
            this.isFinished = isFinished;
            this.admin = admin;
        }
        public Exam(Course course) : this(course, false) { }
        public Exam(Course course, bool isFinished)
        {
            this.Course = course;
            this.IsFinished = isFinished;
        }

        public Exam(Course course, bool isFinished, Admin admin)
        {
            this.Course = course;
            this.IsFinished = isFinished;
            this.Admin = admin;
        }

       

        public Exam(int id, bool isFinished, Admin admin, Course course)
        {
            this.id = id;
            this.isFinished = isFinished;
            this.admin = admin;
            this.Course = course;
        }

        public Exam(bool isFinished, Admin admin)
        {
            this.isFinished = isFinished;
            this.admin = admin;
        }

        public Exam()
        {
        }

        public bool IsFinished
        {
            get
            {
                return isFinished;
            }

            set
            {
                isFinished = value;
            }
        }

        internal Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        internal Admin Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        internal ExamSessionCollection ExamSessions
        {
            get
            {
                return examSessions;
            }

            set
            {
                examSessions = value;
            }
        }
    }
}
