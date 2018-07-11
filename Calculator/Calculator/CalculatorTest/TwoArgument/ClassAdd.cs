using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class ClassAdd
    {

        [TestFixture]
        public class AddTests
        {


            [TestCase(1, 1,2)]
            [TestCase(2, 2,4)]
            [TestCase(3,3,6)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Add();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }

}
