namespace Asg2
{
    class Person
    {
        private string _firstname, _lastname, _addr1, _addr2, _city, _state, _email, _zip, _phone, _starttime, _endtime;
            
        private bool _proof;

        private string _date;

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

        public string DateReceived
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

        public string TimeStarted
        {
            get
            {
                return _starttime;
            }
            set
            {
                _starttime = value;
            }
        }

        public string TimeEnded
        {
            get
            {
                return _endtime;
            }
            set
            {
                _endtime = value;
            }
        }

        public override string ToString()
        {
            return FirstName + "\t" +
                MiddleInitial + "\t" +
                LastName + "\t" +
                AddressLine1 + "\t" +
                AddressLine2 + "\t" +
                City + "\t" +
                State + "\t" +
                ZipCode + "\t" +
                PhoneNumber + "\t" +
                Email + "\t" +
                Proof + "\t" +
                DateReceived + "\t" +
                TimeStarted + "\t" +
                TimeEnded;

        }

        public string GetInfo() {
            return FirstName + " " + 
                MiddleInitial + " " +
                LastName + "\t" +
                PhoneNumber;
        }

        public static Person GetObject(string[] str) {
            return new Person {
                FirstName = str[0],
                MiddleInitial = str[1][0],
                LastName = str[2],
                AddressLine1 = str[3],
                AddressLine2 = str[4],
                City = str[5],
                State = str[6],
                ZipCode = str[7],
                PhoneNumber = str[8],
                Email = str[9],
                Proof = str[10] == "True" ? true: false,
                DateReceived = str[11],
                TimeStarted = str[12],
                TimeEnded = str[13]
            };
        } 
    }
}
