using Calculator.OneArgument;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassModule
    {

        [TestFixture]
        public class ModuleTests
        {
            [Test]

            public void SquaringTest()
            {
                var calculator = new Module();
                Assert.AreEqual(3, calculator.Calculate(-3));
            }
        }
    }

}