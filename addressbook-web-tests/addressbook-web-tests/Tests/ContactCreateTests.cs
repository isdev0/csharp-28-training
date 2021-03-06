﻿using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreateTests : TestBase
    {
        [Test]
        public void ContactCreateTest()
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
            appManager.ContactHelper.Create(contactData);
        }

        [Test]
        public void ContactCreateEmptyTest()
        {
            ContactData contactData = new ContactData("","");
            appManager.ContactHelper.Create(contactData);
        }
    }
}