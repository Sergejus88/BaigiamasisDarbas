using FrameWork;
using NUnit.Framework;
using Tests.Pages.BaseTests;

namespace Tests 
{
    internal class WishListTest : BaseTest
    {   
        [SetUp]
        public void Open()
        {
            WishList.Open();
        }

        [Test]

        public void AddItemToWishlist()
        {
            string expectedResult = ("Added item in wishlist");
            string actualResult = ("Added item in wishlist");

            string ClickOnItem = "ClickOnItem";
            string ClickLikeButton = "ClickLikeButton";
                
            WishList.ClickOnItem(ClickOnItem);
            WishList.ClickLikeButton(ClickLikeButton);

            Assert.AreEqual(expectedResult, actualResult);
        } 
    }
}

