using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Question
    {
        int id; 
        string questionText;
        int type;
        QuestionAnswer modelanswer;
        Course course;
        List<QuestionAnswer> answers;
        
        List<ExamSession> exam;

        public string QuestionText
        {
            get
            {
                return questionText;
            }

            set
            {
                questionText = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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

        public QuestionAnswer Modelanswer
        {
            get
            {
                return modelanswer;
            }

            set
            {
                modelanswer = value;
            }
        }

        public List<QuestionAnswer> Answers
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

        internal List<ExamSession> Exam
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

        public Question()
        {
            // TODO: Complete member initialization
        }

        public Question(int id, string questionText, int type, QuestionAnswer modelanswer, List<QuestionAnswer> answers, Course course, List<ExamSession> exam)
        {
            this.id = id;
            this.questionText = questionText;
            this.type = type;
            this.modelanswer = modelanswer;
            this.answers = answers;
            this.course = course;
            this.exam = exam;
        }

        public Question(int id, string questionText, int type, QuestionAnswer modelanswer, Course course)
        {
            this.id = id;
            this.questionText = questionText;
            this.type = type;
            this.modelanswer = modelanswer;
            this.course = course;
        }

        //public Question(int id, string questionText, string type, string answer, Course course, Exam exam)
        //{
        //    this.id = id;
        //    this.questionText = questionText;
        //    this.type = type;
        //    this.answer = answer;
        //    this.course = course;
        //    this.exam = exam;
        //}
    }
}
