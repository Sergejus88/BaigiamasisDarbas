namespace FrameWork.Pages.www._1a.lt
{
    public class RegistrationPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_up");
        }

        public static void EnterFirstName(string inputFirstName)
        {
            Common.SendKeys(Locators.RegistrationPage.inputFirstName, inputFirstName);
        }

        public static void EnterLastName(string inputLastname)
        {
            Common.SendKeys(Locators.RegistrationPage.inputLastName, inputLastname);
        }

        public static void EnterEmail(string inputEmail)
        {
            Common.SendKeys(Locators.RegistrationPage.inputEmail, inputEmail);
        }

        public static void EnterPassword(string inputPassword)
        {
            Common.SendKeys(Locators.RegistrationPage.inputPassword, inputPassword);
        }

        public static void EnterReapetPassword(string inputRepeatPassword)
        {
            Common.SendKeys(Locators.RegistrationPage.inputReapetPassword, inputRepeatPassword);
        }

        public static void ClickSubmitButton()
        {
            Common.ClickElement(Locators.RegistrationPage.buttonSubmit);
        }
    }        
}

