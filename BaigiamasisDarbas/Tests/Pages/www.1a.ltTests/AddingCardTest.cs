using FrameWork;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests 
{
    internal class AddingCardTest : BaseTest
    {   
        [SetUp]
        public void Open()
        {
            AddingCard.Open();
        }

        [Test]
        public void AddNumbersToGetSmartNetCard()
        {
            string valueInputNumbers = "InvalidNumbers";

            AddingCard.EnterNumbers(valueInputNumbers);
            AddingCard.ClickSubmitButton();

            Assert.IsTrue(AddingCard.CheckIfErrorIsDisplayed());
        } 
    }
}

