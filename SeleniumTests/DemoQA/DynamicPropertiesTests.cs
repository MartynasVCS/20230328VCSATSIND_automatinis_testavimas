using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    public class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeEnabled()
        {
            DynamicProperties.WaitForButtonToBeEnabled();
        }

        [Test]
        public void WaitForButtonTextToBeRed()
        {
            DynamicProperties.WaitForButtonTextToBeRed();
        }

        [Test]
        public void WaitForButtonToBePresent()
        {
            DynamicProperties.WaitForButtonToBePresent();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
