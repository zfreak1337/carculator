using Calculator.OneArgument;
using NUnit.Framework;
namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(10, -0.839)]
        [TestCase(15, -0.759)]
        [TestCase(20, 0.408)]
        public void CosinusTest(double value, double expected)
        {
            var calculator = new Cosinus();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}