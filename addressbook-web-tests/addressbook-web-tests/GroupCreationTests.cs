using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            // Prepair data
            GroupData groupData = new GroupData("111");
            groupData.Header = "222";
            groupData.Footer = "333";

            // Do tests
            navigationHelper.OpenMainPage();
            loginHelper.Login(new UserData("admin","secret"));
            navigationHelper.OpenGroupsPage();
            CreateGroup();
            FillGroupForm(groupData);
            SubmitGroupForm();
            navigationHelper.GoBackToTheGroupPage();
            loginHelper.Logout();
        }
    }
}
