using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassLogarithm
    {

        [TestFixture]
        public class LogarithmTests
        {
            [Test]

            public void SquaringTest()
            {
                var calculator = new Logarithm();
                Assert.AreEqual(3, calculator.Calculate(100));
            }
        }
    }

}