using FrameWork.Pages.www._1a.lt;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests
{
    internal class SearchingResultTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SearchingResult.Open();
        }

        [Test]
        public void SearchForTheProduct()
        {
            string valueInputText = "Apple";

            SearchingResult.SearchField(valueInputText);
            SearchingResult.ClickSearchButton();

            string expectedResult = "Apple products";
            string actualResult = "Apple products";

            string WaitForElementToBeVisible = "results";
            Assert.AreEqual(expectedResult, actualResult, WaitForElementToBeVisible);
        }
    }
}
