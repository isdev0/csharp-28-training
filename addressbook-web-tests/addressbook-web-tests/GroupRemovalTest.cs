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
            navigationHelper.OpenMainPage();
            loginHelper.Login(new UserData("admin", "secret"));
            navigationHelper.OpenGroupsPage();
            SelectGroup(1);
            DeleteGroup(1);
            navigationHelper.GoBackToTheGroupPage();
            loginHelper.Logout();
        }
    }
}
