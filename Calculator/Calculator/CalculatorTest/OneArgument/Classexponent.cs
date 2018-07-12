using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ExponentTests
    {


        [TestCase(10, 22026.465)]
        [TestCase(15, 3269017.372)]
        [TestCase(20, 485165195.409)]

        public void ExponentTest(double value, double expected)
        {
            var calculator = new Exponent();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}