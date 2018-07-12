using System;
using Calculator.TwoArguments;
using NUnit.Framework;
namespace CalculatorTest.TwoArgument
{
   class ClassTwoArgumentsFactoryTests
    {
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Add", typeof(Addiction))]
        [TestCase("Substraction", typeof(Substraction))]
        [TestCase("SquaringTwoArguments", typeof(SquaringTwoArguments))]
        [TestCase("SquarinigDivisionTwoArgument", typeof(SquaringDivisionTwoArguments))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("Multiply", typeof(Multiply))]
        public void FirstTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}



