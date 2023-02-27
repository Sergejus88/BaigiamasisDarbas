namespace FrameWork.Pages.www._1a.lt
{
    public  class ShopCart
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/p/zaidimu-konsole-microsoft-xbox-series-s-usb-3-1-hdmi-wi-fi/imu1?mtd=search-popup&pos=autocoplete&src=searchnode");
        }

        public static void EnterToCartButton(string addProduct)
        {
            Common.ClickElement(Locators.ShopCart.AddItemToShoppingCart, addProduct);
        }

        public static void IsItemInCart()
        {
            Common.ClickElement(Locators.ShopCart.isItemInCart);
        } 
    }
}
