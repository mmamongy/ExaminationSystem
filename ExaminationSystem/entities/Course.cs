using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Course
    {
        int id;
        string name;
        Department deparment;
        

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

        internal Department Deparment
        {
            get
            {
                return deparment;
            }

            set
            {
                deparment = value;
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

        public Course(int id, string name, int deparmentID)
        {
            Deparment = new Department();
            this.id = id;
            this.Name = name;
            this.Deparment.Id = deparmentID;
        }
        public Course(int id, string name, Department deparment)
        {
            this.id = id;
            this.Name = name;
            this.Deparment = deparment;
        }
        public Course(string name, Department deparment)
        {
            this.Name = name;
            this.Deparment = deparment;
        }

        public Course()
        {
            deparment = null;
        }
        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
