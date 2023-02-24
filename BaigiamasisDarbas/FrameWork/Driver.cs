using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Kas yra string temp?
        public static void OpenUrl(string url, string temp)
        {
            // Čia nereikia abiejų kvietimų
            // Pirmasis mums atidaro langą "švariai"
            // Antrasis išlaiko mūsų ankstesnius veiksmus svetainėje taigi naudojamas specifinėse situacijose
            // Bendriniu atveju svetainės atidarymui naudojame driver.Url = ""
            driver.Url = url;
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
