using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Instructor
    {
        string userName;
        string name;
        int age;
        string phone;
        string address;
        string email;
        Admin admin;
        Department department;
        string password;

       //as2al fatma el chain da 3yza a7otelo username wla blash 
        public Instructor(string name, int age, string phone, string address,  Admin admin, Department department,string password): this("",name, age, phone, address, "", admin, department, password) { }

        public Instructor(string userName, string name, int age, string phone, string address, string email, Admin admin, Department department, string password)
        {
            this.userName = userName;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.admin = admin;
            this.department = department;
            this.password = password;
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

        public string Password
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
    }
}
