using NUnit.Framework;

namespace UnitTests
{
    internal class SkaiciuotuvoTestai
    {
        [Test]
        public void SumTest()
        {
            int number1 = 2;
            int number2 = 7;
            int expectedResult = 9;

            int actualResult = Skaiciuotuvas.Skaiciuotuvas.Suma(number1, number2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ProductTest()
        {
            int number1 = 3;
            int number2 = 4;
            int expectedResult = 11;

            int actualResult = Skaiciuotuvas.Skaiciuotuvas.Sandauga(number1, number2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
