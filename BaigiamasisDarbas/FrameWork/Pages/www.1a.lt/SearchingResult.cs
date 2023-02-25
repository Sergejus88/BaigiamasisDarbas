using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;

namespace FrameWork.Pages.www._1a.lt
{
    public  class SearchingResult
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static void SearchField(string valueInputText)
        {
            Common.ClickElement(Locators.SearchingResult.inputText, valueInputText);
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.SearchingResult.clickButton);
        }

        public static void WaitForElementToBeVisible(string SerchingResult)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(Locators.SearchingResult.clickButton)));
        }
    }
}
