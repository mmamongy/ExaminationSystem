using ExaminationSystem.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class StudentGrades
    {
        Student s;
        int grade;
        Course crs;

        internal Student S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        internal Course Crs
        {
            get
            {
                return crs;
            }

            set
            {
                crs = value;
            }
        }

        StudentGrades(int sid , int grade , Course crs)
        {
            S.Id  = sid;
            this.Grade = grade;
            this.Crs = crs;
        }

        public StudentGrades()
        {
        }

        
    }
}
