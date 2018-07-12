using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class NegativeArgumentTests
    {


        [TestCase(10, -10.0)]
        [TestCase(15, -15.0)]
        [TestCase(20, -20.0)]

        public void ArctangentTest(double value, double expected)
        {
            var calculator = new NegativeArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}