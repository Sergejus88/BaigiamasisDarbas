using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;

namespace FrameWork
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url, string temp)
        {
            driver.Url = url;
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

        public static void TakeScreenshot()
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}/screenshots";
            string screenshotName = $"screenshot-{Guid.NewGuid()}.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            Directory.CreateDirectory(screenshotsDirectoryPath);
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
        }

        internal static void OpenUrl(string v)
        {
            Driver.OpenUrl(v);
        }
    }
}
