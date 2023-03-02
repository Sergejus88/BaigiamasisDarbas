using FrameWork.Pages.www._1a.lt;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests
{
    internal class FindShopTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            FindShop.Open();
        }

        [Test]
        public void FindShopInKlaipeda()
        {
            string expectedResult = "Klaipėda";
           
            Assert.AreEqual(expectedResult, FindShop.FindTheshop());
        }
    }
}
