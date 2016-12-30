using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.instatnce
{
    class MyStudent
    {
        private static Student student ;

        internal static Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }
    }
}
