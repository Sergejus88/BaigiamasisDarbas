namespace FrameWork.Pages.www._1a.lt
{
    public  class SearchingResult
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static void SearchField(string valueInputText)
        {
            Common.ClickElement(Locators.SearchingResult.inputText, valueInputText);
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.SearchingResult.clickButton);
        }
    }
}
