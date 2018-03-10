using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CreateNewGroup();
            FillGroupForm(groupData);
            SubmitGroupForm();
            appManager.NavigationHelper.GoBackToTheGroupPage();
            return this;
        }

        public GroupHelper Remove(int groupIndex)
        {
            appManager.NavigationHelper.OpenGroupsPage();
            SelectGroup(groupIndex);
            DeleteGroup(groupIndex);
            appManager.NavigationHelper.GoBackToTheGroupPage();
            return this;
        }

        // lowlevel methods
        public GroupHelper CreateNewGroup()
        {
            webDriver.FindElement(By.Name("new")).Click();
            return this;
        }

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

        public GroupHelper SubmitGroupForm()
        {
            webDriver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int groupIndex)
        {
            webDriver.FindElement(By.XPath("(//input[@name='selected[]'])[" + groupIndex + "]")).Click();
            return this;
        }

        public GroupHelper DeleteGroup(int groupIndex)
        {
            webDriver.FindElement(By.XPath("(//input[@name='delete'])[" + groupIndex + "]")).Click();
            return this;
        }
    }
}
