using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class SeleniumEasy
    {
        [Test]
        public void SingleInputField()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']//button"));
            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id='display']"));

            string expectedMessage = "Labas";

            inputMessage.SendKeys(expectedMessage);
            buttonShowMessage.Click();
            string actualMessage = spanMessage.Text;

            Assert.AreEqual(expectedMessage, actualMessage);

            driver.Quit();
        }

        [Test]
        public void TwoInputFields()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputA = driver.FindElement(By.XPath("//*[@id='value1']"));
            IWebElement inputB = driver.FindElement(By.XPath("//*[@id='value2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']//button"));
            IWebElement spanTotal = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            string valueA = "7";
            string valueB = "8";
            string expectedResult = "15";

            inputA.SendKeys(valueA);
            inputB.SendKeys(valueB);
            buttonGetTotal.Click();
            string actualResult = spanTotal.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }
    }
}
