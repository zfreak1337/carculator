using Calculator.TwoArguments;
using NUnit.Framework;
namespace CalculatorTest.TwoArgument
{
    public class MultiplyTest
    {
            [TestCase(1, 1, 1)]
            [TestCase(3, 2, 6)]
            [TestCase(5, 3, 15)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Multiply();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }
