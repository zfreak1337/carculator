using Calculator.OneArgument;
using NUnit.Framework;
namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class TwoSquaringArgumentTest
    {
        [TestCase(1, 2.0)]
        [TestCase(2, 4.0)]
        [TestCase(3, 8.0)]
        public void TwoSquaringArgument(double value, double expected)
        {
            var calculator = new TwoSquaringArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
