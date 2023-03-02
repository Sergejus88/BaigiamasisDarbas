namespace FrameWork
{
    internal class Locators
    {
        internal class SmartUp
        {
            internal static string inputNumber = "//*[@id='mobile_application_phone_number']";
            internal static string inputEmail = "//*[@id='mobile_application_email']";
            internal static string submitButton = "//*[@id='new_mobile_application']//input[@type='submit']";
        }
        internal class RegistrationPage
        {
            internal static string inputFirstName = "//*[@id='user_first_name']";
            internal static string inputLastName = "//*[@id='user_last_name']";
            internal static string inputEmail = "//*[@id='user_email']";
            internal static string inputPassword = "//*[@id='user_password']";
            internal static string inputReapetPassword = "//*[@id='user_password_confirmation']";
            internal static string buttonSubmit = "//*[@id='new_user']//input[@type='submit']";
        }

        internal class SignInPage
        {
            internal static string inputEmail = "//*[@id='user_email']";
            internal static string inputPassword = "//*[@id='user_password']";
            internal static string clickSignIn = "//*[@id='new_user']//input[@type='submit']";
        }

        internal class FindShop
        {
            internal static string findTheshop = "//*[@id='Klaipėda']";
        }

        internal class SearchingResult
        {
            internal static string inputText = "//*[@id='q']";
            internal static string clickButton = "//*[@id='top-search-form']//button";
        }
    }
}
