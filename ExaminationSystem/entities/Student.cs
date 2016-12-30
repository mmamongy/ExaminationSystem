using ExaminationSystem.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Student
    {
        // hello
        // hello 2   
        int id;
         
        string name;
        string userName;
        int age;
        string address;
        string phone;
        string email;
        string password;
        Admin admin;
        Department department;
        ExamSessionCollection exams;

        public Student(string userName, string name, int age, string address, string phone, string email, string password, Admin admin, Department department)
        {
            this.userName = userName;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.admin = admin;
            this.department = department;
        }

        public Student(int id, string userName, string name, int age, string address, string phone, string email, string password, Admin admin, Department department)
        {
            this.id = id;
            this.userName = userName;
            this.name = name;
            this.age = age;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.admin = admin;
            this.department = department;
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Student()
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

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return Password1;
            }

            set
            {
                Password1 = value;
            }
        }

        public string Password1
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        internal Admin Admin
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

        internal Department Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        internal ExamSessionCollection Exams
        {
            get
            {
                return Exams1;
            }

            set
            {
                Exams1 = value;
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

        internal ExamSessionCollection Exams1
        {
            get
            {
                return exams;
            }

            set
            {
                exams = value;
            }
        }
    }
}
