using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassSquaring
    {

        [TestFixture]
        public class SquaringTests
        {
            [Test]

            public void SquaringTest()
            {
                var calculator = new Squaring();
                Assert.AreEqual(3, calculator.Calculate(3));
            }
        }
    }

}