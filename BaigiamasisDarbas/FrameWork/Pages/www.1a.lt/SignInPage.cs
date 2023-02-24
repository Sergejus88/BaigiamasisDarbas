using FrameWork.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public class SignInPage
    {
        public static void Open()
        {
            // Čia ta pati problema
            Common.Open("https://www.1a.lt/users/sign_in");
        }

        public static string InputEmail(string expectedResult)
        {
            string locator = "//*[@id='user_email']";
            return Common.GetElementText(locator);
        }

        public static string InputPassword(string inputPassword)
        {
            string locator = "//*[@id='user_password']";
            return Common.GetElementText(locator);
        }

        public static string GetSignIn()
        {
            string locator = "//*[@id='new_user']/div[4]/input";
            return Common.GetElementText(locator);
        }

        public static string GetEmailOutput()
        {
            string locator = "//*[@id='user_email']";
            return Common.GetElementText(locator);
        }

        public static string GetCurrentPasswordOutput()
        {
            string locator = "//*[@id='user_password']";
            return Common.GetElementText(locator);
        }
    }
}
