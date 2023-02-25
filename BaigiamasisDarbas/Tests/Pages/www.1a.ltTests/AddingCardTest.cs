using FrameWork;
using FrameWork.Pages._1a;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

