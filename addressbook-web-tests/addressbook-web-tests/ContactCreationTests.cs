using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            // Prepair data
            ContactData contactData = new ContactData("Ivan","Ivanov");
            contactData.MiddleName  = "mname";
            contactData.NickName    = "nname";
            contactData.Title       = "title";
            contactData.Company     = "company";
            contactData.Address     = "address1\naddress2\naddress3";
            contactData.Home        = "thome";
            contactData.Mobile      = "tmobile";
            contactData.Work        = "twork";
            contactData.Fax         = "tfax";
            contactData.Email       = "email1";
            contactData.Email2      = "email2";
            contactData.Email3      = "email3";
            contactData.Homepage    = "hpage";
            contactData.Address2    = "secaddress1\nsecaddress2\nsecaddress3";
            contactData.Phone2      = "sechome";
            contactData.Notes       = "note1\nnote2\nnote3";

            // Do tests
            navigationHelper.OpenMainPage();
            loginHelper.Login(new UserData("admin", "secret"));
            CreateContact();
            FillContactForm(contactData);
            SubmitContactForm();
            loginHelper.Logout();
        }
    }
}