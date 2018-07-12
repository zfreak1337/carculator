using Calculator.OneArgument;
using NUnit.Framework;
namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class TwoLogarithmArgumentTest
    {
        [TestCase(60, 0.169)]
        [TestCase(90, 0.154)]
        [TestCase(180, 0.1334)]
        public void TwoLogarithmArgument(double value, double expected)
        {
            var calculator = new TwoLogarithmArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
