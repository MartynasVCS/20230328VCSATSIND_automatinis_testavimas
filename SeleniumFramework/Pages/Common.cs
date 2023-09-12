using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

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

        internal static void WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(60));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Enabled == true);
        }

        internal static void WaitForButtonToBePresent(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(60));
            //wait.Until(ExpectedConditions.ElementExists(By.XPath(locator))); // alternatyva su ExpectedConditions klase
            wait.Until(driver => driver.FindElement(By.XPath(locator)));
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string propertyName, string expectedPropertyValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(60));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(propertyName) == expectedPropertyValue);
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }
    }
}
