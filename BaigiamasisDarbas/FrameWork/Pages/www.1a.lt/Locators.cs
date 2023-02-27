namespace FrameWork
{
    internal class Locators
    {
       internal class OrderNumber
       {
            internal static string inputOrderNumber = "//*[@id='new_']";
            internal static string inputEmail = "//*[@id='new_']";
            internal static string submitButton = "//*[@id='new_']";
        }

       internal class RegistrationPage
       {
          internal static string inputFirstName = "//*[@id='user_first_name']";
          internal static string inputLastName = "//*[@id='user_last_name']";
          internal static string inputEmail = "//*[@id='user_email']";
          internal static string inputPassword = "//*[@id='user_password']";
          internal static string inputReapetPassword = "//*[@id='user_password_confirmation']";
          internal static string buttonSubmit = "//*[@id='new_user']";
       }

       internal class SignInPage
       {
          internal static string inputEmail = "//*[@id='user_email']";
          internal static string inputPassword = "//*[@id='user_password']";
          internal static string clickSignIn = "//*[@id='new_user']";
       }

       internal class ShopCart
       {
            internal static string AddItemToShoppingCart = "//*[@id='add_to_cart']";
            internal static string isItemInCart = "//*[@id='cart_item_1587697']";
       }

       internal class SearchingResult
       {
           internal static string inputText = "//*[@id='q']";
           internal static string clickButton = "//*[@id='top-search-form']";
       }  
    }      
}
