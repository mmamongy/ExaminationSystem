using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class QuestionAnswer
    {
        private int id;
        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
