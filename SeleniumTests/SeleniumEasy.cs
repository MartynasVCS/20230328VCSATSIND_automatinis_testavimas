using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class SeleniumEasy
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
        }

        [Test]
        public void SingleInputField()
        {
            string expectedMessage = "Labas";

            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id='get-input']//input"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']//button"));
            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id='display']"));
            inputMessage.SendKeys(expectedMessage);
            buttonShowMessage.Click();
            string actualMessage = spanMessage.Text;

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void TwoInputFields()
        {
            string valueA = "7";
            string valueB = "8";
            string expectedResult = "15";

            IWebElement inputA = driver.FindElement(By.XPath("//*[@id='value1']"));
            IWebElement inputB = driver.FindElement(By.XPath("//*[@id='value2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']//button"));
            IWebElement spanTotal = driver.FindElement(By.XPath("//*[@id='displayvalue']"));
            inputA.SendKeys(valueA);
            inputB.SendKeys(valueB);
            buttonGetTotal.Click();
            string actualResult = spanTotal.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
