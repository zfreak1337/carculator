using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ArccosinusTests
    {


        [TestCase(0.5, 1.047)]
        [TestCase(0.7, 0.795)]
        [TestCase(0.8, 0.643)]

        public void ArccosinusTest(double value, double expected)
        {
            var calculator = new Arccosinus();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}