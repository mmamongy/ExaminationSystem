using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Topic
    {
        string name;
        Course course;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public Topic(string name, Course course)
        {
            this.Name = name;
            this.Course = course;
        }
    }
}
