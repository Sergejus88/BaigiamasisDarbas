using FrameWork;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SearchingResultTest
    {
        [SetUp]
        public void SetUp()
        {
            // Čia atidarote naršyklę
            Driver.SetupDriver();
        }

        [Test]
        public void SearchForProduct()
        {
            // Čia dar kartą sukuriate driver objektą kuris vėl atidarys antrą naršyklės langą
            // Na ir taip pat komentaras kaip ir ankstesniame komentare: čia nenaudojate POM
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.1a.lt/");

            var searchBox = driver.FindElement(By.Id("//*[@id='q']"));
            searchBox.SendKeys("Product Name");

            var searchButton = driver.FindElement(By.Id("//*[@id='top-search-form']"));
            searchButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("//*[@id='top-search-form']")));
            var searchResults = driver.FindElement(By.Id("//*[@id='top-search-form']"));

            Assert.IsTrue(searchResults.Text.Contains("Product Name"));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
