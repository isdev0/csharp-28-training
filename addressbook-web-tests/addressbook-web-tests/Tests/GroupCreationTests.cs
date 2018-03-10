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
            app.NavigationHelper.OpenMainPage();
            app.LoginHelper.Login(new UserData("admin","secret"));
            app.NavigationHelper.OpenGroupsPage();
            app.GroupHelper.CreateGroup();
            app.GroupHelper.FillGroupForm(groupData);
            app.GroupHelper.SubmitGroupForm();
            app.NavigationHelper.GoBackToTheGroupPage();
            app.LoginHelper.Logout();
        }
    }
}
