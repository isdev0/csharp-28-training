namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstName;
        private string lastName;
        private string middleName   = null;
        private string nickName     = null;
        private string photo        = null;
        private string title        = null;
        private string company      = null;
        private string address      = null;
        private string home         = null;
        private string mobile       = null;
        private string work         = null;
        private string fax          = null;
        private string email        = null;
        private string email2       = null;
        private string email3       = null;
        private string homepage     = null;
        private string address2     = null;
        private string phone2       = null;
        private string notes        = null;

        public ContactData(string firstName, string lastName)
        {
            this.firstName  = firstName;
            this.lastName   = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string NickName
        {
            get
            {
                return this.nickName;
            }
            set
            {
                this.nickName = value;
            }
        }

        public string Photo
        {
            get
            {
                return this.photo;
            }
            set
            {
                this.photo = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string Home
        {
            get
            {
                return this.home;
            }
            set
            {
                this.home = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }

        public string Work
        {
            get
            {
                return this.work;
            }
            set
            {
                this.work = value;
            }
        }

        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Email2
        {
            get
            {
                return this.email2;
            }
            set
            {
                this.email2 = value;
            }
        }

        public string Email3
        {
            get
            {
                return this.email3;
            }
            set
            {
                this.email3 = value;
            }
        }

        public string Homepage
        {
            get
            {
                return this.homepage;
            }
            set
            {
                this.homepage = value;
            }
        }

        public string Address2
        {
            get
            {
                return this.address2;
            }
            set
            {
                this.address2 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return this.phone2;
            }
            set
            {
                this.phone2 = value;
            }
        }

        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }

    }
}
