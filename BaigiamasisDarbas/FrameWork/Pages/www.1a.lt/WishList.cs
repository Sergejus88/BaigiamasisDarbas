using FrameWork.Pages;

namespace FrameWork
{
    public class WishList
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/wishlists");
        }
        public static void ClickOnItems(string clickOnItems)
        {
            Common.ClickElement(Locators.WishList.clickbutton, clickOnItems);
        }

        public static void ClickLikeButton(string wishItemListPlace)
        {
            Common.ClickElement(Locators.WishList.clickOnWishlist, wishItemListPlace);
        }
    }
}
