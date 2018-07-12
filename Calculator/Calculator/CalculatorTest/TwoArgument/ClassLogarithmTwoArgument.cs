using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class ClassLogarithmTwoArgument
    {

        [TestFixture]
        public class LogarithmTwoArgumentTests
        {


            [TestCase(150, 6, 2.796)]
            [TestCase(3, 2, 1.584)]
            [TestCase(5, 3, 1.464)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new LogarithmTwoArgument();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }
}