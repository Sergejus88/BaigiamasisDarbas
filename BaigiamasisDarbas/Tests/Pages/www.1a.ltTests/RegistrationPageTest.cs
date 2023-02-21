using FrameWork;
using FrameWork.Pages._1a;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class RegistrationPageTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
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

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
