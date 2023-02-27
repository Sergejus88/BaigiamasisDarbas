using FrameWork.Pages;

namespace FrameWork
{
    public class WishList
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static void ClickOnItem(string clickOnItem)
        {
            Common.ClickElement(Locators.WishList.clickbutton, clickOnItem);
        }

        public static void ClickLikeButton(string wishItemListPlace)
        {
            Common.ClickElement(Locators.WishList.clickOnWishlist, wishItemListPlace);
        }
    }
}
