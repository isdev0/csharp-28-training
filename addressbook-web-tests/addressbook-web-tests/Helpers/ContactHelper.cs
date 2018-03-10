using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager appManager) : base(appManager) { }

        // uplevel methods
        public void Create(ContactData contactData)
        {
            CreateNewContact();
            FillContactForm(contactData);
            SubmitContactForm();
        }

        // lowlevel methods
        public void CreateNewContact()
        {
            webDriver.FindElement(By.LinkText("add new")).Click();
        }

        public void FillContactForm(ContactData contactData)
        {
            webDriver.FindElement(By.Name("firstname")).Clear();
            webDriver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);

            webDriver.FindElement(By.Name("middlename")).Clear();
            webDriver.FindElement(By.Name("middlename")).SendKeys(contactData.MiddleName);

            webDriver.FindElement(By.Name("lastname")).Clear();
            webDriver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);

            webDriver.FindElement(By.Name("nickname")).Clear();
            webDriver.FindElement(By.Name("nickname")).SendKeys(contactData.NickName);

            webDriver.FindElement(By.Name("photo")).Clear();
            webDriver.FindElement(By.Name("photo")).SendKeys(contactData.Photo);

            webDriver.FindElement(By.Name("title")).Clear();
            webDriver.FindElement(By.Name("title")).SendKeys(contactData.Title);

            webDriver.FindElement(By.Name("company")).Clear();
            webDriver.FindElement(By.Name("company")).SendKeys(contactData.Company);

            webDriver.FindElement(By.Name("address")).Clear();
            webDriver.FindElement(By.Name("address")).SendKeys(contactData.Address);

            webDriver.FindElement(By.Name("home")).Clear();
            webDriver.FindElement(By.Name("home")).SendKeys(contactData.Home);

            webDriver.FindElement(By.Name("mobile")).Clear();
            webDriver.FindElement(By.Name("mobile")).SendKeys(contactData.Mobile);

            webDriver.FindElement(By.Name("work")).Clear();
            webDriver.FindElement(By.Name("work")).SendKeys(contactData.Work);

            webDriver.FindElement(By.Name("fax")).Clear();
            webDriver.FindElement(By.Name("fax")).SendKeys(contactData.Fax);

            webDriver.FindElement(By.Name("email")).Clear();
            webDriver.FindElement(By.Name("email")).SendKeys(contactData.Email);

            webDriver.FindElement(By.Name("email2")).Clear();
            webDriver.FindElement(By.Name("email2")).SendKeys(contactData.Email2);

            webDriver.FindElement(By.Name("email3")).Clear();
            webDriver.FindElement(By.Name("email3")).SendKeys(contactData.Email3);

            webDriver.FindElement(By.Name("homepage")).Clear();
            webDriver.FindElement(By.Name("homepage")).SendKeys(contactData.Homepage);

            //new SelectElement(webDriver.FindElement(By.Name("bday"))).SelectByText("1");
            //new SelectElement(webDriver.FindElement(By.Name("bmonth"))).SelectByText("January");

            //webDriver.FindElement(By.Name("byear")).Clear();
            //webDriver.FindElement(By.Name("byear")).SendKeys("2001");

            //new SelectElement(webDriver.FindElement(By.Name("aday"))).SelectByText("2");
            //new SelectElement(webDriver.FindElement(By.Name("amonth"))).SelectByText("February");

            //webDriver.FindElement(By.Name("ayear")).Clear();
            //webDriver.FindElement(By.Name("ayear")).SendKeys("2010");

            webDriver.FindElement(By.Name("address2")).Clear();
            webDriver.FindElement(By.Name("address2")).SendKeys(contactData.Address2);

            webDriver.FindElement(By.Name("phone2")).Clear();
            webDriver.FindElement(By.Name("phone2")).SendKeys(contactData.Phone2);

            webDriver.FindElement(By.Name("notes")).Clear();
            webDriver.FindElement(By.Name("notes")).SendKeys(contactData.Notes);
        }

        public void SubmitContactForm()
        {
            webDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}
