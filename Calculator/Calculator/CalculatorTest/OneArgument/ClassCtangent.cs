using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class CtangentTests
    {


        [TestCase(10, 1.542)]
        [TestCase(15, -1.168)]
        [TestCase(20, 0.446)]

        public void ArctangentTest(double value, double expected)
        {
            var calculator = new Ctangent();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}