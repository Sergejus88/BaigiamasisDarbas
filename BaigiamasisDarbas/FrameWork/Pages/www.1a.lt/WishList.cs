using FrameWork.Pages;

namespace FrameWork
{
    public class WishList
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_in");
        }
        public static void InputEmail(string valueInputEmail)
        {
            Common.SendKeys(Locators.SignInPage.inputEmail, valueInputEmail);
        }

        public static void InputPassword(string valueinputPassword)
        {
            Common.SendKeys(Locators.SignInPage.inputPassword, valueinputPassword);
        }

        public static void ClickSignIn()
        {
            Common.ClickElement(Locators.SignInPage.clickSignIn);
        }

        public static void ClickOnItems(string clickOnItems)
        {
            Common.ClickElement(Locators.WishList.clickbutton, clickOnItems);
        }

        public static void ClickLikeButton(string wishItemListPlace)
        {
            Common.ClickElement(Locators.WishList.clickOnWishlist, wishItemListPlace);
        }

        public static void OpenUrl()
        {
            Driver.OpenUrl("https://www.1a.lt/wishlists");
        }
    }
}
