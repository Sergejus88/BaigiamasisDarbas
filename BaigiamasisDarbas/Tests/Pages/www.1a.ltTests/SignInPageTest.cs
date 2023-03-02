using FrameWork;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests
{
    internal class SignInPageTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SignInPage.Open();
        }

        [Test]
        public void SignIn()
        {
            string valueInputEmail = "email51d43eff-e8ff-417a-8d67-217afbb11ded@gmail.com";
            string valueInputPassword = "Password";

            string expectedResult = "https://www.1a.lt/";

            SignInPage.InputEmail(valueInputEmail);
            SignInPage.InputPassword(valueInputPassword);
            SignInPage.ClickSignIn();

            Assert.AreEqual(expectedResult, SignInPage.GetRedirectedUrl());
        }
    }
}
