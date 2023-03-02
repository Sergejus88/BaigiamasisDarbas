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

            string expectedResult = "Sveiki atvykę į 1a.lt Apple parduotuvę";

            Assert.AreEqual(expectedResult, SearchingResult.GetRedirectedTitle());
        }
    }
}
