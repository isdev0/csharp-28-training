using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager appManager) : base(appManager) { }

        public void Login(UserData userData)
        {
            webDriver.FindElement(By.Name("user")).Clear();
            webDriver.FindElement(By.Name("user")).SendKeys(userData.Username);
            webDriver.FindElement(By.Name("pass")).Clear();
            webDriver.FindElement(By.Name("pass")).SendKeys(userData.Password);
            webDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        public void Logout()
        {
            webDriver.FindElement(By.LinkText("Logout")).Click();
            webDriver.FindElement(By.Name("user")).Clear();
            webDriver.FindElement(By.Name("user")).SendKeys("admin");
        }
    }
}
