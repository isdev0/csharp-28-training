using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(AppManager appManager) : base(appManager)
        {
            this.baseURL = appManager.BaseURL;
        }

        public void OpenMainPage()
        {
            webDriver.Navigate().GoToUrl(baseURL + "addressbook");
        }

        public void OpenGroupsPage()
        {
            webDriver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoBackToTheGroupPage()
        {
            webDriver.FindElement(By.LinkText("group page")).Click();
        }

        public void OpenContactEditPage(string contactId="")
        {
            webDriver.Navigate().GoToUrl(baseURL + "addressbook/edit.php?id=" + contactId);
        }
    }
}
