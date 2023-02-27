namespace FrameWork.Pages.www._1a.lt
{
    public  class ShopCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static void InputProductName(string enterProductName)
        {
            Common.SendKeys(Locators.ShopCart.searchAndClickProduct, enterProductName);
        }

        public static void AddToCartButton(string addCartProduct)
        {
            Common.ClickElement(Locators.ShopCart.AddProduct, addCartProduct);
        }

        public static void ClickIsProductIsInShoppingCart()
        {
            Common.ClickElement(Locators.ShopCart.clickShoppingCart);
        }
    }
}
