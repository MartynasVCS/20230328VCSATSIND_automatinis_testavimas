using OpenQA.Selenium;

namespace SeleniumFramework.Pages
{
    class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void EnterTextToElement(string locator, string text)
        {
            GetElement(locator).SendKeys(text);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }
    }
}
