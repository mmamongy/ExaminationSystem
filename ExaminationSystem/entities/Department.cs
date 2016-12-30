using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Department
    {
        int id;
        string name;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Department(string name)
        {
            this.Name = name;
        }

        public Department()
        {
        }

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
    }
}
