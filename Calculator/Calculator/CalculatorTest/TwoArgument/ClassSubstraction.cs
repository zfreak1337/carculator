using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class ClassSupstraction
    {

        [TestFixture]
        public class SubstractionTests
        {


            [TestCase(1, 1, 0)]
            [TestCase(6, 2, 4)]
            [TestCase(9, 3, 6)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Substraction();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }
}

