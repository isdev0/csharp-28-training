using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver webDriver;
        protected AppManager appManager;

        public HelperBase(AppManager appManager)
        {
            this.webDriver = appManager.WebDriver;
            this.appManager = appManager;
        }
    }
}