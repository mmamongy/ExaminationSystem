using ExaminationSystem.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class ExamQuestion
    {
        int id;
        Question question;
        QuestionAnswerCollection answers;
        //StudentCollection studentAnswers;
        Exam exam;


        public ExamQuestion()
        {
        }
        public ExamQuestion(Question question, Exam exam)
        {
            this.question = question;
            this.exam = exam;
        }

        public ExamQuestion(int id, Question question, Exam exam)
        {
            this.id = id;
            this.question = question;
            this.exam = exam;
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

        internal Question Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
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

        internal QuestionAnswerCollection Answers
        {
            get
            {
                return answers;
            }

            set
            {
                answers = value;
            }
        }

        //internal StudentCollection StudentAnswers
        //{
        //    get
        //    {
        //        return studentAnswers;
        //    }

        //    set
        //    {
        //        studentAnswers = value;
        //    }
        //}
    }
}
