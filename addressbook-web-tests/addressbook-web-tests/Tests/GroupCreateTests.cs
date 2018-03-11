using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreateTests : TestBase
    {
        [Test]
        public void GroupCreateTest()
        {
            GroupData groupData = new GroupData("111");
            groupData.Header = "222";
            groupData.Footer = "333";
            appManager.GroupHelper.Create(groupData);
        }

        [Test]
        public void GroupCreateEmptyTest()
        {
            GroupData groupData = new GroupData("");
            appManager.GroupHelper.Create(groupData);
        }
    }
}
