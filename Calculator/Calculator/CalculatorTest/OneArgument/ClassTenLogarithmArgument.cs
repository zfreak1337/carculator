using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class TenLogarithmArgumentTest
    {


        [TestCase(60, 0.5623)]
        [TestCase(90, 0.511)]
        [TestCase(180, 0.443)]

        public void TenLogarithmArgument(double value, double expected)
        {
            var calculator = new TenLogarithmArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

