﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(IWebDriver driver) : base(driver) { }

        public void CreateGroup()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        public void FillGroupForm(GroupData groupData)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(groupData.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
        }

        public void SubmitGroupForm()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void SelectGroup(int groupIndex)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + groupIndex + "]")).Click();
        }

        public void DeleteGroup(int groupIndex)
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[" + groupIndex + "]")).Click();
        }
    }
}
