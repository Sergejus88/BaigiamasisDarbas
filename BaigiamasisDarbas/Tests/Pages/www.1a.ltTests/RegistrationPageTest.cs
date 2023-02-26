using FrameWork;
using FrameWork.Pages.www._1a.lt;
using NUnit.Framework;

namespace Tests
{
    internal class RegistrationPageTest 
    {

        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            Driver.Open();
        }

        [Test]
        public void FillFormSignUp()
        {
            string expectedResult = ("Registration is completed");
            string actualResult = ("Registration is completed");

            string inputFirstName = "Sergejus";
            string inputLastname = "Semionkinas";
            string inputEmail = "sergejus.semionkinas@gmail.com";
            string inputPassword = "Password";
            string inputReapetPassword = "Password";

            RegistrationPage.EnterFirstName(inputFirstName);
            RegistrationPage.EnterLastName(inputLastname);
            RegistrationPage.EnterEmail(inputEmail);
            RegistrationPage.EnterPassword(inputPassword);
            RegistrationPage.EnterReapetPassword(inputReapetPassword);
            RegistrationPage.ClickSubmitButton();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
