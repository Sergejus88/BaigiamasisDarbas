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
        public void IsProductIsAddedToCart()
        {
            string expectedResult = "Your product is in shopping cart";
            string actualResult = "Your product is in shopping cart";

            string enterProductName = null;
            string addCartProduct = null;
            ShopCart.InputProductName(enterProductName);
            ShopCart.AddToCartButton(addCartProduct);

            ShopCart.ClickIsProductIsInShoppingCart();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
