using NUnit.Framework;

namespace UnitTests
{
    internal class Demo
    {
        [Test]
        public void Testas()
        {
            int sk1 = 2;
            int sk2 = 7;
            int expectedResult = -5;

            int actualResult = sk1 - sk2;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
