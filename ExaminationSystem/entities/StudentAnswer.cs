using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class StudentAnswer
    {
        int id;
        Student s;
        Exam e;
        //Question currentQuestion;
        bool solved = true;
        QuestionAnswer qa;
        Question q;

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

        internal Exam E
        {
            get
            {
                return e;
            }

            set
            {
                e = value;
            }
        }

        public bool Solved
        {
            get
            {
                return solved;
            }

            set
            {
                solved = value;
            }
        }

        internal QuestionAnswer Qa
        {
            get
            {
                return qa;
            }

            set
            {
                qa = value;
            }
        }

        internal Question Q
        {
            get
            {
                return q;
            }

            set
            {
                q = value;
            }
        }
    }
}
