using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected AppManager appManager;

        [SetUp]
        public void SetupTest()
        {
            appManager = new AppManager();
            appManager.NavigationHelper.OpenMainPage();
            appManager.LoginHelper.Login(new UserData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            appManager.LoginHelper.Logout();
            appManager.Stop();
        }
    }
}
