using FrameWork.Pages;

namespace FrameWork
{
    public class SignInPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_in");
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
            Common.ClickElement(Locators.SignInPage.clickSignIn);
        }
    }
}
