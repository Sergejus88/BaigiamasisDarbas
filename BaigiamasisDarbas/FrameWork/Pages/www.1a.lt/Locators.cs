namespace FrameWork
{
    internal class Locators
    {
        internal class WishList
        {
            internal static string clickbutton = "<i class=favorite-items__icon icon-svg></i>";
            internal static string clickOnWishlist = "<p class='wishlists-list__item-name'>Išsaugotos prekės</p>"; 

            internal class RegistrationPage
            {
                internal static string inputFirstName = "//*[@id='user_first_name']";
                internal static string inputLastName = "//*[@id='user_last_name']";
                internal static string inputEmail = "//*[@id='user_email']";
                internal static string inputPassword = "//*[@id='user_password']";
                internal static string inputReapetPassword = "//*[@id='user_password_confirmation']";
                internal static string buttonSubmit = "//*[@id='new_user']/div[9]/input";
            }

            internal class SignInPage
            {
                internal static string inputEmail = "//*[@id='user_email']";
                internal static string inputPassword = "//*[@id='user_password']";
                internal static string clickSignIn = "//*[@id='new_user']";
            }

            internal class ShopCart
            {
                internal static string EnterProduct = "//*[@id='cart_item_1582294']";
                internal static string AddProduct = "//*[@id='add_to_cart_form']";
                internal static string clickShoppingCart = "//*[@id='cart_item_1582294']";
            }

            internal class SearchingResult
            {
                internal static string inputText = "//*[@id='q']";
                internal static string clickButton = "//*[@id='top-search-form']";
            }
        }
    }      
}
