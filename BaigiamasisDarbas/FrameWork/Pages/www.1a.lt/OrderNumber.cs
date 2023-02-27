using FrameWork.Pages;

namespace FrameWork
{
    public class OrderNumber
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/order_search");
        }

        public static void InputOrder(string number)
        {
           
            Common.SendKeys(Locators.OrderNumber.inputOrderNumber, number);
        }

        public static void InputEmailAddress(string email)
        {
            Common.SendKeys(Locators.OrderNumber.inputEmail, email);
        }

        public static void SubmitButton()
        {
            Common.ClickElement(Locators.OrderNumber.submitButton);
        }
    }
}
