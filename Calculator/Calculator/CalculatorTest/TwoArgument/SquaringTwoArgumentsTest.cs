using Calculator.TwoArguments;
using NUnit.Framework;
namespace CalculatorTest.TwoArgument
{
    [TestFixture]
    public class SquaringTwoArgumentsTest
    {
            [TestCase(1, 1, 1)]
            [TestCase(3, 2, 9.0)]
            [TestCase(5, 3, 125.0)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new SquaringTwoArguments();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);
            }
        }
    }
