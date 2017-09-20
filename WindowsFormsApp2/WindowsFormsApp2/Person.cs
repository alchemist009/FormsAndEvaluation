using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Person
    {
        private string _firstname, _lastname, _addr1, _addr2, _city, _state, _email, _zip, _phone;
            
        private bool _proof;

        private DateTime _date;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public char MiddleInitial
        {
            get;
            set;
        }

        public string AddressLine1
        {
            get
            {
                return _addr1;
            }
            set
            {
                _addr1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return _addr2;
            }
            set
            {
                _addr2 = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return _zip;
            }
            set
            {
                _zip = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public bool Proof
        {
            get
            {
                return _proof;
            }
            set
            {
                _proof = value;
            }
        }

        public DateTime DateReceived
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public override string ToString()
        {
            return FirstName + ", " +
                MiddleInitial + ", " +
                LastName + ", " +
                AddressLine1 + ", " +
                AddressLine2 + ", " +
                City + ", " +
                State + ", " +
                ZipCode + ", " +
                PhoneNumber + ", " +
                Email + ", " +
                Proof + ", " +
                DateReceived;

        }
    }
}
