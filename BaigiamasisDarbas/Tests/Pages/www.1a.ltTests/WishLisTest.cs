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

        public void AddSomeProductToWishlist()
        {
            string valueInputEmail = "sergejus.semionkinas@gmail.com";
            string valueInputPassword = "Password";

            SignInPage.InputEmail(valueInputEmail);
            SignInPage.InputPassword(valueInputPassword);
            SignInPage.ClickSignIn();

            string expectedResult = ("Added items in wishlist");
            string actualResult = ("Added items in wishlist");

            string ClickOnItems = "ClickOnItems";
            string ClickLikeButton = "ClickLikeButton";
                
            WishList.ClickOnItems(ClickOnItems);
            WishList.ClickLikeButton(ClickLikeButton);

            Assert.AreEqual(expectedResult, actualResult);
        } 
    }
}

