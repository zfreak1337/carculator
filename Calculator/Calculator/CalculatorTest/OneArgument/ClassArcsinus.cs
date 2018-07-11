using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ArcsinusTests
    {


        [TestCase(0.5, 0.523)]
        [TestCase(0.6, 0.643)]
        [TestCase(0.7, 0.775)]

        public void ArcsinusTest(double value, double expected)
        {
            var calculator = new Arcsinus();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
