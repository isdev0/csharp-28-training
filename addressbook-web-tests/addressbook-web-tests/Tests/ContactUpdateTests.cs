using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactUpdateTests : TestBase
    {
        [Test]
        public void ContactUpdateTest()
        {
            // Prepair data
            ContactData contactData = new ContactData("Petr", "Petrov");
            contactData.MiddleName  = "mname2";
            contactData.NickName    = "nname2";
            contactData.Title       = "title2";
            contactData.Company     = "company2";
            contactData.Address     = "address21\naddress22\naddress23";
            contactData.Home        = "thome2";
            contactData.Mobile      = "tmobile2";
            contactData.Work        = "twork2";
            contactData.Fax         = "tfax2";
            contactData.Email       = "email21";
            contactData.Email2      = "email22";
            contactData.Email3      = "email23";
            contactData.Homepage    = "hpage2";
            contactData.Address2    = "secaddress21\nsecaddress22\nsecaddress23";
            contactData.Phone2      = "sechome2";
            contactData.Notes       = "note21\nnote22\nnote23";

            // Do tests
            appManager.ContactHelper.Update(1,contactData);
        }

        [Test]
        public void ContactUpdatePartialTest()
        {
            // Prepair data
            ContactData contactData = new ContactData("Sergey", "Ivanov");
            contactData.MiddleName  = "Petrovitch";
            contactData.Mobile      = "+7-917-777-77-77";
            contactData.Email       = "s.ivanov@testmail.rus";

            // Do tests
            appManager.ContactHelper.Update(1, contactData);
        }
    }
}
