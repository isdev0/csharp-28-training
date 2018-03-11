using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactDeleteTests : TestBase
    {
        [Test]
        public void ContactDeleteTest()
        {
            appManager.ContactHelper.Delete(1);
        }
    }
}
