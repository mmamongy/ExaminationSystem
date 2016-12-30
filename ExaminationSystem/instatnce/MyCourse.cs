using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.instatnce
{
    static class MyCourse
    {
        private static Course c;

        internal static Course C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }
    }
}
