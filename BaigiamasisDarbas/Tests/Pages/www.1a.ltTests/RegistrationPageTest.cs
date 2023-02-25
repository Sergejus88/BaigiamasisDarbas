using FrameWork.Pages._1a;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests
{
    internal class RegistrationPageTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            RegistrationPage.Open();
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

            RegistrationPage.inputFirstName(inputFirstName);
            RegistrationPage.inputLastName(inputLastname);
            RegistrationPage.inputEmailSignUP(inputEmail);
            RegistrationPage.inputPassword(inputPassword);
            RegistrationPage.inputReapetPassword(inputReapetPassword);
            RegistrationPage.ClickSubmitButton();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
