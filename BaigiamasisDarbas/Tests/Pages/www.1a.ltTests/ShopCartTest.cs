using FrameWork.Pages.www._1a.lt;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests
{
    internal class ShopCartTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ShopCart.Open();
        }

        [Test]
        public void IsItemAddedToCart()
        {
            string expectedResult = "Your product is in shopping cart";
            string actualResult = "Your product is in shopping cart";
            
            string addCartProduct = "Lenovo";
            
            ShopCart.EnterToCartButton(addCartProduct);
            ShopCart.IsItemInCart();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
