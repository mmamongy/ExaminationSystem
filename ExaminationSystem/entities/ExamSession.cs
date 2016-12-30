using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class ExamSession
    {
        int id;
        DateTime sessionDate;
        Exam exam;
        Admin admin;

        public DateTime SessionDate
        {
            get
            {
                return sessionDate;
            }

            set
            {
                sessionDate = value;
            }
        }

        internal Exam Exam
        {
            get
            {
                return exam;
            }

            set
            {
                exam = value;
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

        public ExamSession()
        {
        }

        public ExamSession(DateTime sessionDate, Exam exam, Admin admin)
        {
            this.SessionDate = sessionDate;
            this.Exam = exam;
            this.Admin = admin;
        }

        public ExamSession(int id, DateTime sessionDate, Exam exam, Admin admin)
        {
            this.id = id;
            this.sessionDate = sessionDate;
            this.exam = exam;
            this.admin = admin;
        }

        public ExamSession(int id)
        {
            this.id = id;
        }
    }
}
