using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class Demo
    {
        [Test]
        public void OpenGoogle()
        {
            string expectedYear = "2023";
            string expectedDay = "8";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.day.lt/";
            IWebElement spanYear = driver.FindElement(By.XPath("//*[@title='Metai']"));
            IWebElement spanDay = driver.FindElement(By.XPath("//*[@title='Data']"));
            string actualYear = spanYear.Text;
            string actualDay = spanDay.Text;
            driver.Quit();

            Assert.AreEqual(expectedYear, actualYear);
            Assert.AreEqual(expectedDay, actualDay);
        }
    }
}
