using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace SeleniumTests
{
    public class DemoQA
    {
        [Test]
        public void TextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string expectedName = "Petras";

            IWebElement inputFullName = driver.FindElement(By.Id("userName"));
            inputFullName.SendKeys(expectedName);
            
            IWebElement buttonSubmit = driver.FindElement(By.Id("submit"));

            int maxTries = 20;
            int currentTry = 0;

            while(currentTry < maxTries)
            {
                try
                {
                    buttonSubmit.Click();
                    break;
                }
                catch (ElementClickInterceptedException)
                {
                    driver.ExecuteJavaScript("window.scrollBy(0, 10);");
                    currentTry++;
                    Console.WriteLine($"Current try: {currentTry}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            IWebElement spanFullName = driver.FindElement(By.Id("name"));
            string actualName = spanFullName.Text;

            Assert.AreEqual($"Name:{expectedName}", actualName);
            StringAssert.Contains(expectedName, actualName);
        }
    }
}
