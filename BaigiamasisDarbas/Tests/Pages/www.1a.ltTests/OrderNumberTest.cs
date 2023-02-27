using FrameWork;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests 
{
    internal class OrderNumberTest : BaseTest
    {   
        [SetUp]
        public void Open()
        {
            OrderNumber.Open();
        }

        [Test]

        public void IsOrderCorrect()
        {
            string InputOrderNumber = "54546645";
            string InputEmail = "sergejus.semionkinas@gmail.com";

            string expectedResult = ("Order does not exist");
            string actualResult = ("Order does not exist");

            OrderNumber.InputOrder(InputOrderNumber);
            OrderNumber.InputEmailAddress(InputEmail);
            OrderNumber.SubmitButton();
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

