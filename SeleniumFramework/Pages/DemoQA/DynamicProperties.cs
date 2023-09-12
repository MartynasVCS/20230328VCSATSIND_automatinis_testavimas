using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static void Open()
        {
            string url = "https://demoqa.com/dynamic-properties";
            Driver.OpenPage(url);
        }

        public static void WaitForButtonToBeEnabled()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitForElementToBeEnabled(locator);
        }

        public static void WaitForButtonTextToBeRed()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementCssPropertyToBe(locator, "color", "rgba(220, 53, 69, 1)");
        }

        public static string GetButtonTextColorValue()
        {
            string locator = "//*[@id='colorChange']";
            return Common.GetElementCssPropertyValue(locator, "color");
        }

        public static void WaitForButtonToBePresent()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.WaitForButtonToBePresent(locator);
        }
    }
}
