using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class AppManager
    {
        private StringBuilder verificationErrors;

        protected IWebDriver webDriver;
        protected string baseURL;

        protected LoginHelper       loginHelper;
        protected NavigationHelper  navigationHelper;
        protected GroupHelper       groupHelper;
        protected ContactHelper     contactHelper;

        public AppManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox ESR 45.7.0\firefox.exe";
            webDriver = new FirefoxDriver(options);
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();

            loginHelper         = new LoginHelper(this);
            navigationHelper    = new NavigationHelper(this);
            groupHelper         = new GroupHelper(this);
            contactHelper       = new ContactHelper(this);
        }

        public IWebDriver       WebDriver           { get { return webDriver; } }
        public string           BaseURL             { get { return baseURL; } }
        public LoginHelper      LoginHelper         { get { return loginHelper; } }
        public NavigationHelper NavigationHelper    { get { return navigationHelper; } }
        public GroupHelper      GroupHelper         { get { return groupHelper; } }
        public ContactHelper    ContactHelper       { get { return contactHelper; } }

        public void Stop()
        {
            try
            {
                webDriver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

    }
}
