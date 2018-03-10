using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class AppManager
    {
        private StringBuilder verificationErrors;

        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper       loginHelper;
        protected NavigationHelper  navigationHelper;
        protected GroupHelper       groupHelper;
        protected ContactHelper     contactHelper;

        public LoginHelper      LoginHelper         { get { return loginHelper; } }
        public NavigationHelper NavigationHelper    { get { return navigationHelper; } }
        public GroupHelper      GroupHelper         { get { return groupHelper; } }
        public ContactHelper    ContactHelper       { get { return contactHelper; } }

        public AppManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox ESR 45.7.0\firefox.exe";
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();

            loginHelper         = new LoginHelper(driver);
            navigationHelper    = new NavigationHelper(driver, baseURL);
            groupHelper         = new GroupHelper(driver);
            contactHelper       = new ContactHelper(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

    }
}
