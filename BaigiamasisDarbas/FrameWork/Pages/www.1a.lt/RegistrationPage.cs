using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Pages._1a
{ 
   public class RegistrationPage
   {
      public static void Open()
      {
          // Čia ta pati problema
          Common.Open("https://www.1a.lt/users/sign_up");
      }

      public static void inputFirstName(string inputFirstName)
      {
          Common.SendKeys(Locators.RegistrationPage.inputFirstName, inputFirstName);
      }

      public static void inputLastName(string ValueInputLastname)
      {
          Common.SendKeys(Locators.RegistrationPage.inputLastName, ValueInputLastname);
      }

      public static void inputEmailSignUP(string valueInputEmail)
      {
          Common.SendKeys(Locators.RegistrationPage.inputEmail, valueInputEmail);
      }

      public static void inputPassword(string valueInputPassword)
      {
          Common.SendKeys(Locators.RegistrationPage.inputPassword, valueInputPassword);
      }

      public static void inputReapetPassword(string valueInputRepeatPassword)
      {
          Common.SendKeys(Locators.RegistrationPage.inputFirstName, valueInputRepeatPassword);
      }

      public static void ClickSubmitButton()
      {
            Common.ClickElement(Locators.RegistrationPage.inputFirstName);
      }
   }
}
