using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassaTeller
{
    class Worker
    {
        int id;
        public int ID
        {
            get
            {
                return id;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("ID cant be 0 of negitave");
                }
                id = value;
            }
        }

        string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("First Name cant be empty");
                }
                firstName = value;
            }
        }

        string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Last Name cant be empty");
                }
                lastName = value;
            }
        }

        public Worker(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
