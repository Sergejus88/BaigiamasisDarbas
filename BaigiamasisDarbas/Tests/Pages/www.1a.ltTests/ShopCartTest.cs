using FrameWork;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class ShopCartTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            // Testuose negali būti šio kodo.
            // Jis susijęs su Selenium ir mes siekiame atskyrimo.
            // Šiam veiksmui turime Driver klasę ir metodą joje.
            // Viršuje turite du importus kurie testuose neturėtų būti naudojami:
            //   using OpenQA.Selenium;
            //   using OpenQA.Selenium.Chrome;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.1a.lt/");
        }

        [Test]
        public void TestProductIsAddedToCart()
        {
            IWebElement product = driver.FindElement(By.XPath("//*[@id='cart_item_1582294']"));
            product.Click();
            IWebElement addToCartButton = driver.FindElement(By.XPath("//*[@id='add_to_cart_form']"));
            addToCartButton.Click();

            driver.Navigate().GoToUrl("https://www.example.com/cart");
            IWebElement cartProduct = driver.FindElement(By.XPath("//*[@id='cart_item_1582294']"));
            Assert.IsNotNull(cartProduct);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
