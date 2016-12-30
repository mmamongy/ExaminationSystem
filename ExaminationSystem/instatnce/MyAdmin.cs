using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.instatnce
{
    class MyAdmin
    {
        private static Admin admin;

        internal static Admin Admin
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

    }
}
