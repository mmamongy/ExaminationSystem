using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.entities
{
    class Admin
        //Maryam
    {
        int id;
        string userName;
        string name;
        string email;
        string pass;

        public Admin()
        {

        }

        public Admin(int id)
        {
            this.id = id;

        }

        public Admin(int id, string userName, string name, string email, string pass)
        {
            this.id = id;
            this.userName = userName;
            this.name = name;
            this.email = email;
            this.pass = pass;
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
