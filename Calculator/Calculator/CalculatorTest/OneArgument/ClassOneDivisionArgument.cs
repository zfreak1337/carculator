using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class OneDivisionArgumentTests
    {


        [TestCase(10, 0.100)]
        [TestCase(15, 0.066)]
        [TestCase(20, 0.050)]

        public void OneDivisionArgumentTest(double value, double expected)
        {
            var calculator = new OneDivisionArgument();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}