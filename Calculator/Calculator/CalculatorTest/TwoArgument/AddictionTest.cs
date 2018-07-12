using Calculator.TwoArguments;
using NUnit.Framework;
namespace CalculatorTest.TwoArgument
{
    [TestFixture]
    public class AddictionTest
    {
            [TestCase(1, 1,2)]
            [TestCase(2, 2,4)]
            [TestCase(3,3,6)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Addiction();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }


