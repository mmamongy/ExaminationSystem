using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.instatnce
{
    class MyInstructor
    {
        private static Instructor instructor;

        internal static Instructor Instructor
        {
            get
            {
                return instructor;
            }

            set
            {
                instructor = value;
            }
        }
    }
}
