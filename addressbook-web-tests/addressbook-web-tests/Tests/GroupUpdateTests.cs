using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupUpdateTests : TestBase
    {
        [Test]
        public void GroupUpdateTest()
        {
            GroupData groupData = new GroupData("111 updated");
            groupData.Header = "111 updated";
            groupData.Footer = "111 updated";
            appManager.GroupHelper.Update(1,groupData);
        }
    }
}
