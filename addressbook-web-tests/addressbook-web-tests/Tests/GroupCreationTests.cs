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
            GroupData groupData = new GroupData("111");
            groupData.Header = "222";
            groupData.Footer = "333";
            appManager.GroupHelper.Create(groupData);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData groupData = new GroupData("");
            appManager.GroupHelper.Create(groupData);
        }
    }
}
