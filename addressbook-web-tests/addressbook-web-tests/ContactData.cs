using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstName;
        private string lastName;
        private string middleName   = "";
        private string nickName     = "";
        private string photo        = "";
        private string title        = "";
        private string company      = "";
        private string address      = "";
        private string home         = "";
        private string mobile       = "";
        private string work         = "";
        private string fax          = "";
        private string email        = "";
        private string email2       = "";
        private string email3       = "";
        private string homepage     = "";
        private string address2     = "";
        private string phone2       = "";
        private string notes        = "";

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
