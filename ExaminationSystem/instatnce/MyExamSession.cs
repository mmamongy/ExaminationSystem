using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.instatnce
{
    class MyExamSession
    {
        private static ExamSession examSession;

        internal static ExamSession ExamSession
        {
            get
            {
                return examSession;
            }

            set
            {
                examSession = value;
            }
        }
    }
}
