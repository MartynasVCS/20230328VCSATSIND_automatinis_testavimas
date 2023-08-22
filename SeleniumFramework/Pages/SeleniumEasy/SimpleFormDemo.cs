namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class SimpleFormDemo
    {
        public static void Open()
        {
            string url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Driver.OpenPage(url);
        }

        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='get-input']//input";
            Common.EnterTextToElement(locator, message);
        }

        public static void ClickShowMessageButton()
        {
            string locator = "//*[@id='get-input']//button";
            Common.ClickElement(locator);
        }

        public static string GetMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);
        }

        public static void EnterValueA(string value)
        {
            string locator = "//*[@id='value1']";
            Common.EnterTextToElement(locator, value);
        }

        public static void EnterValueB(string value)
        {
            string locator = "//*[@id='value2']";
            Common.EnterTextToElement(locator, value);
        }

        public static void ClickGetTotalButton()
        {
            string locator = "//*[@id='gettotal']//button";
            Common.ClickElement(locator);
        }

        public static string GetTotalText()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }
    }
}
