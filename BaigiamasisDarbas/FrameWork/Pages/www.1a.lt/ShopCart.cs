namespace FrameWork.Pages.www._1a.lt
{
    public  class ShopCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static void AddToCartButton(string addProduct)
        {
            Common.ClickElement(Locators.ShopCart.AddProduct, addProduct);
        }

        public static void ClickIsProductIsInShoppingCart()
        {
            Common.ClickElement(Locators.ShopCart.clickShoppingCart);
        }

        public static void IsItemInCart()
        {
            Common.ClickElement(Locators.ShopCart.isItemInCart);
        } 
    }
}
