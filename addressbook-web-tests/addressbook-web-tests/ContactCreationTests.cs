﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox ESR 45.7.0\firefox.exe";
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

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
            OpenMainPage();
            Login(new UserData("admin", "secret"));
            CreateContact();
            FillContactForm(contactData);
            SubmitContactForm();
            Logout();
        }

        private void OpenMainPage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

        private void Login(UserData userData)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(userData.Username);

            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(userData.Password);

            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void CreateContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactForm(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);

            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contactData.MiddleName);

            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);

            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contactData.NickName);

            driver.FindElement(By.Name("photo")).Clear();
            driver.FindElement(By.Name("photo")).SendKeys(contactData.Photo);

            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contactData.Title);

            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contactData.Company);

            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contactData.Address);

            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contactData.Home);

            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contactData.Mobile);

            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contactData.Work);

            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(contactData.Fax);

            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contactData.Email);

            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(contactData.Email2);

            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(contactData.Email3);

            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(contactData.Homepage);

            //new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");

            //driver.FindElement(By.Name("byear")).Clear();
            //driver.FindElement(By.Name("byear")).SendKeys("2001");

            //new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("2");
            //new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("February");

            //driver.FindElement(By.Name("ayear")).Clear();
            //driver.FindElement(By.Name("ayear")).SendKeys("2010");

            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contactData.Address2);

            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(contactData.Phone2);

            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(contactData.Notes);
        }

        private void SubmitContactForm()
        {
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}