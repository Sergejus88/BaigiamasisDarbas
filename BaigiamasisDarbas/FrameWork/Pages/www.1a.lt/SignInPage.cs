using FrameWork.Pages;

namespace FrameWork
{
    public class SignInPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_in");
            Common.WaitForElementToBeVisible("//*[@id='cookiebanner' and @style='display: block; bottom: 0px;']");
            Common.ClickElement("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']");
        }

        public static void InputEmail(string valueInputEmail)
        {
            Common.SendKeys(Locators.SignInPage.inputEmail, valueInputEmail);
        }

        public static void InputPassword(string valueinputPassword)
        {
            Common.SendKeys(Locators.SignInPage.inputPassword, valueinputPassword);
        }

        public static void ClickSignIn()
        {
            Common.ScrollToElement(Locators.SignInPage.inputEmail);
            Common.ClickElement(Locators.SignInPage.clickSignIn);
        }

        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
