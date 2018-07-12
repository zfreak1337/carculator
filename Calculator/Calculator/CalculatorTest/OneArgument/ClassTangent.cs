using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class TangentTests
    {


        [TestCase(10, 0.648)]
        [TestCase(15, -0.855)]
        [TestCase(20, 2.237)]

        public void TangentTest(double value, double expected)
        {
            var calculator = new Tangent();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}