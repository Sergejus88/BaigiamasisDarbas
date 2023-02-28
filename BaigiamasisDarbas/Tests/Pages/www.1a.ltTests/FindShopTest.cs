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
            string expectedResult = "The shop is in Klaipeda";
            string actualResult = "The shop is in Klaipeda";
            string yes = "";

            FindShop.FindTheshop(yes);
           
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
