using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassSinus
    {

        [TestFixture]
        public class SinusTests
        {
            [Test]

            public void SquaringTest()
            {
                var calculator = new Sinus();
                Assert.AreEqual(3, calculator.Calculate(60));
            }
        }
    }

}