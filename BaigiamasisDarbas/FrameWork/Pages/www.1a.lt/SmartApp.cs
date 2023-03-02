using FrameWork.Pages;

namespace FrameWork
{
    public class SmartUp
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/mobile_applications");
            Common.WaitForElementToBeVisible("//*[@id='cookiebanner' and @style='display: block; bottom: 0px;']");
            Common.ClickElement("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']");
        }

        public static void InputOrder(string inputNumber)
        {
           
            Common.SendKeys(Locators.SmartUp.inputNumber, inputNumber);
        }

        public static void InputEmailAddress(string inputEmail)
        {
            Common.SendKeys(Locators.SmartUp.inputEmail, inputEmail);
        }

        public static void SubmitButton()
        {
            Common.ClickElement(Locators.SmartUp.submitButton);
        }
    }
}
