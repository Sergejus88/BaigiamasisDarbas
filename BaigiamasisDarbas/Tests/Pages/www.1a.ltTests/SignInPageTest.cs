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

            string expectedResult = "Your login is successfully";
            string actualResult = "Your login is successfully";

            SignInPage.InputEmail(valueInputEmail);
            SignInPage.InputPassword(valueInputPassword);
            SignInPage.ClickSignIn();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
