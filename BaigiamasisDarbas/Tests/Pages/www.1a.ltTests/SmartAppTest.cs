using FrameWork;
using NUnit.Framework;
using System;
using Tests.Pages.BaseTests;

namespace Tests 
{
    internal class SmartUpTest : BaseTest
    {   
        [SetUp]
        public void Open()
        {
            SmartUp.Open();
        }

        [Test]

        public void IsDownloadAvailable()
        {
            Random random = new Random();
            string inputNumbers = $"+370671{random.Next(10000, 99999)}";
            string inputEmail = $"email{Guid.NewGuid()}@gmail.com";

            string expectedResult = "Sėkmingai išsiųsta. Patikrink savo mobilųjį telefoną";

            SmartUp.InputOrder(inputNumbers);
            SmartUp.InputEmailAddress(inputEmail);
            SmartUp.SubmitButton();
            
            Assert.AreEqual(expectedResult, SmartUp.GetSuccessMessage());
        }
    }
}

