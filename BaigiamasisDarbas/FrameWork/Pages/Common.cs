﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace FrameWork.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
        
        internal static void ClickElement(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void ScrollToElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Driver.GetDriver().ExecuteJavaScript("arguments[0].scrollIntoView();", element);
            System.Threading.Thread.Sleep(1000);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }
    }
}
   