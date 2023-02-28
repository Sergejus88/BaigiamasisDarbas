using FrameWork;
using NUnit.Framework;
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
            string inputNumbers = "+37067147870";
            string inputEmail = "sergejus.semionkinas@gmail.com";

            string expectedResult = ("Link is sent to my phone");
            string actualResult = ("Link is sent to my phone");

            SmartUp.InputOrder(inputNumbers);
            SmartUp.InputEmailAddress(inputEmail);
            SmartUp.SubmitButton();
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

