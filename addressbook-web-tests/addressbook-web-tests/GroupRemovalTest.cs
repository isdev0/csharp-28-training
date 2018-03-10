using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.NavigationHelper.OpenMainPage();
            app.LoginHelper.Login(new UserData("admin", "secret"));
            app.NavigationHelper.OpenGroupsPage();
            app.GroupHelper.SelectGroup(1);
            app.GroupHelper.DeleteGroup(1);
            app.NavigationHelper.GoBackToTheGroupPage();
            app.LoginHelper.Logout();
        }
    }
}
