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
    }
}
