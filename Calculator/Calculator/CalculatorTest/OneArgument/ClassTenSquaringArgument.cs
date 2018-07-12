using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class TenSquaringArgumentTest
    {


        [TestCase(1, 9.9999)]
        [TestCase(5, 100000.0)]
        [TestCase(3, 1000.0)]

        public void TenSquaringArgument(double value, double expected)
        {
            var calculator = new TenSquaringArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
