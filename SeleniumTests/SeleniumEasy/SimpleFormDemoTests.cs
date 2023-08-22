using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    class SimpleFormDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedMessage = "Labas";

            SimpleFormDemo.EnterMessage(expectedMessage);
            SimpleFormDemo.ClickShowMessageButton();
            string actualMessage = SimpleFormDemo.GetMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void TwoInputFields()
        {
            string valueA = "7";
            string valueB = "8";
            string expectedResult = "15";

            SimpleFormDemo.EnterValueA(valueA);
            SimpleFormDemo.EnterValueB(valueB);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTotalText();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TwoInputFields2()
        {
            string valueA = "77777";
            string valueB = "88888";
            string expectedResult = "15";

            SimpleFormDemo.EnterValueA(valueA);
            SimpleFormDemo.EnterValueB(valueB);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTotalText();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
