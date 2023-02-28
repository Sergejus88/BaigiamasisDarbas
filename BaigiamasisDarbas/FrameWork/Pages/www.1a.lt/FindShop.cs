namespace FrameWork.Pages.www._1a.lt
{
    public  class FindShop
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/stores");
        }

        public static void FindTheshop(string findTheshop)
        {
            Common.SendKeys(Locators.FindShop.findTheshop, findTheshop);
        }

        public static void IsShopExists()
        {
            Common.ClickElement(Locators.FindShop.isShopExists);
        }
    }
}
