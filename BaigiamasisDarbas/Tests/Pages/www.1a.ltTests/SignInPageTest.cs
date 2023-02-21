using FrameWork;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SignInPageTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            SignInPage.Open();
        }

        [Test]
        public void SignIn()
        {
            string valueInputEmail = "sergejus.semionkinas@gmail.com";
            string valueInputPassword = "Password";

            SignInPage.InputEmail(valueInputEmail);
            SignInPage.InputPassword(valueInputPassword);
            SignInPage.GetSignIn();

            string actualEmail = SignInPage.GetEmailOutput();
            string actualPassword = SignInPage.GetCurrentPasswordOutput();

            Assert.IsTrue(actualEmail.Contains(valueInputEmail));
            Assert.IsTrue(actualPassword.Contains(valueInputPassword));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
