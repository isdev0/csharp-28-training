using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager appManager) : base(appManager) { }

        // uplevel methods
        public void Create(ContactData contactData)
        {
            appManager.NavigationHelper.OpenMainPage();
            CreateNewContact();
            FillContactForm(contactData);
            ButtonClickByValue("Enter");
        }

        public void Update(int contactIndex, ContactData contactData)
        {
            appManager.NavigationHelper.OpenMainPage();
            EditContactByIndex(contactIndex);
            //EditContactById(SelectContact(contactIndex));         // alternative
            FillContactForm(contactData);
            ButtonClickByValue("Update");
        }

        public void Delete(int contactIndex)
        {
            appManager.NavigationHelper.OpenMainPage();
            SelectContact(contactIndex);
            ButtonClickByValue("Delete");
            CloseAlertAndGetItsText();
            appManager.NavigationHelper.OpenMainPage();
        }

        // lowlevel methods
        public void CreateNewContact()
        {
            webDriver.FindElement(By.LinkText("add new")).Click();
            //appManager.NavigationHelper.OpenContactEditPage();    // alternative
        }

        public void FillContactForm(ContactData contactData)
        {
            if(contactData.FirstName != null)
            {
                webDriver.FindElement(By.Name("firstname")).Clear();
                webDriver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            }

            if (contactData.MiddleName != null)
            {
                webDriver.FindElement(By.Name("middlename")).Clear();
                webDriver.FindElement(By.Name("middlename")).SendKeys(contactData.MiddleName);
            }

            if (contactData.LastName != null)
            {
                webDriver.FindElement(By.Name("lastname")).Clear();
                webDriver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            }

            if (contactData.NickName != null)
            {
                webDriver.FindElement(By.Name("nickname")).Clear();
                webDriver.FindElement(By.Name("nickname")).SendKeys(contactData.NickName);
            }

            if (contactData.Photo != null)
            {
                webDriver.FindElement(By.Name("photo")).Clear();
                webDriver.FindElement(By.Name("photo")).SendKeys(contactData.Photo);
            }

            if (contactData.Title != null)
            {
                webDriver.FindElement(By.Name("title")).Clear();
                webDriver.FindElement(By.Name("title")).SendKeys(contactData.Title);
            }

            if (contactData.Company != null)
            {
                webDriver.FindElement(By.Name("company")).Clear();
                webDriver.FindElement(By.Name("company")).SendKeys(contactData.Company);
            }

            if (contactData.Address != null)
            {
                webDriver.FindElement(By.Name("address")).Clear();
                webDriver.FindElement(By.Name("address")).SendKeys(contactData.Address);
            }

            if (contactData.Home != null)
            {
                webDriver.FindElement(By.Name("home")).Clear();
                webDriver.FindElement(By.Name("home")).SendKeys(contactData.Home);
            }

            if (contactData.Mobile != null)
            {
                webDriver.FindElement(By.Name("mobile")).Clear();
                webDriver.FindElement(By.Name("mobile")).SendKeys(contactData.Mobile);
            }

            if (contactData.Work != null)
            {
                webDriver.FindElement(By.Name("work")).Clear();
                webDriver.FindElement(By.Name("work")).SendKeys(contactData.Work);
            }

            if (contactData.Fax != null)
            {
                webDriver.FindElement(By.Name("fax")).Clear();
                webDriver.FindElement(By.Name("fax")).SendKeys(contactData.Fax);
            }

            if (contactData.Email != null)
            {
                webDriver.FindElement(By.Name("email")).Clear();
                webDriver.FindElement(By.Name("email")).SendKeys(contactData.Email);
            }

            if (contactData.Email2 != null)
            {
                webDriver.FindElement(By.Name("email2")).Clear();
                webDriver.FindElement(By.Name("email2")).SendKeys(contactData.Email2);
            }

            if (contactData.Email3 != null)
            {
                webDriver.FindElement(By.Name("email3")).Clear();
                webDriver.FindElement(By.Name("email3")).SendKeys(contactData.Email3);
            }

            if (contactData.Homepage != null)
            {
                webDriver.FindElement(By.Name("homepage")).Clear();
                webDriver.FindElement(By.Name("homepage")).SendKeys(contactData.Homepage);
            }

            //new SelectElement(webDriver.FindElement(By.Name("bday"))).SelectByText("1");
            //new SelectElement(webDriver.FindElement(By.Name("bmonth"))).SelectByText("January");

            //webDriver.FindElement(By.Name("byear")).Clear();
            //webDriver.FindElement(By.Name("byear")).SendKeys("2001");

            //new SelectElement(webDriver.FindElement(By.Name("aday"))).SelectByText("2");
            //new SelectElement(webDriver.FindElement(By.Name("amonth"))).SelectByText("February");

            //webDriver.FindElement(By.Name("ayear")).Clear();
            //webDriver.FindElement(By.Name("ayear")).SendKeys("2010");

            if (contactData.Address2 != null)
            {
                webDriver.FindElement(By.Name("address2")).Clear();
                webDriver.FindElement(By.Name("address2")).SendKeys(contactData.Address2);
            }

            if (contactData.Phone2 != null)
            {
                webDriver.FindElement(By.Name("phone2")).Clear();
                webDriver.FindElement(By.Name("phone2")).SendKeys(contactData.Phone2);
            }

            if (contactData.Notes != null)
            {
                webDriver.FindElement(By.Name("notes")).Clear();
                webDriver.FindElement(By.Name("notes")).SendKeys(contactData.Notes);
            }
        }

        public string SelectContact(int contactIndex)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath("(//input[@name='selected[]'])[" + contactIndex + "]"));
            webElement.Click();
            return webElement.GetAttribute("id");
        }

        public void EditContactByIndex(int contactIndex)
        {
            webDriver.FindElement(By.XPath("(//img[@alt='Edit'])[" + contactIndex + "]")).Click();
        }

        public void EditContactById(string contactId)
        {
            appManager.NavigationHelper.OpenContactEditPage(contactId);
        }

        public void ButtonClickByValue(string value)
        {
            webDriver.FindElement(By.XPath("//input[@value='" + value + "']")).Click();
        }

        public string CloseAlertAndGetItsText()
        {
            IAlert alert = webDriver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            return alertText;
        }
    }
}
