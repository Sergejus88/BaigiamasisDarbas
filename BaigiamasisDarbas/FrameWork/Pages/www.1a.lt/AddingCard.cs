using FrameWork.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public class AddingCard
    {
        public static void Open()
        {
            Common.Open("https://www.1a.lt/physical_smart_card/new");
        }
        public static void EnterNumbers(string valueInputNumbers)
        {
            Common.SendKeys(valueInputNumbers);
        }

        public static void ClickSubmitButton()
        {
            Common.ClickElement(Locators.buttonSubmit);
        }

        public static bool CheckIfErrorIsDisplayed()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.inputNumbers, "class");

            if (attributeClassValue.Contains("flash-alert-block"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
