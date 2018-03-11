using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(AppManager appManager) : base(appManager) { }

        // uplevel methods
        public GroupHelper Create(GroupData groupData)
        {
            appManager.NavigationHelper.OpenGroupsPage();
            ButtonClickByName("new");
            FillGroupForm(groupData);
            ButtonClickByName("submit");
            appManager.NavigationHelper.GoBackToTheGroupPage();
            return this;
        }

        public GroupHelper Update(int groupIndex, GroupData groupData)
        {
            appManager.NavigationHelper.OpenGroupsPage();
            SelectGroup(groupIndex);
            ButtonClickByName("edit");
            FillGroupForm(groupData);
            ButtonClickByName("update");
            appManager.NavigationHelper.GoBackToTheGroupPage();
            return this;
        }

        public GroupHelper Delete(int groupIndex)
        {
            appManager.NavigationHelper.OpenGroupsPage();
            SelectGroup(groupIndex);
            ButtonClickByName("delete");
            appManager.NavigationHelper.GoBackToTheGroupPage();
            return this;
        }

        // lowlevel methods
        public GroupHelper FillGroupForm(GroupData groupData)
        {
            webDriver.FindElement(By.Name("group_name")).Clear();
            webDriver.FindElement(By.Name("group_name")).SendKeys(groupData.Name);
            webDriver.FindElement(By.Name("group_header")).Clear();
            webDriver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            webDriver.FindElement(By.Name("group_footer")).Clear();
            webDriver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
            return this;
        }

        public GroupHelper ButtonClickByName(string buttonName)
        {
            webDriver.FindElement(By.Name(buttonName)).Click();
            return this;
        }

        public GroupHelper SelectGroup(int groupIndex)
        {
            webDriver.FindElement(By.XPath("(//input[@name='selected[]'])[" + groupIndex + "]")).Click();
            return this;
        }
    }
}
