using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests
{
    public class DayLt
    {
        [Test]
        public void CheckCurrentYearAndDay()
        {
            string expectedYear = DateTime.Now.Year.ToString();
            string expectedDay = DateTime.Now.Day.ToString();

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
