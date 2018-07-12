using System;
using Calculator.OneArgument;
using NUnit.Framework;
namespace CalculatorTest.OneArgument
{
    class ClassOneArgumentsFactoryTests
    {
        [TestCase("Module", typeof(Module))]
        [TestCase("Squaring", typeof(Squaring))]
        [TestCase("Logarithm", typeof(Logarithm))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Arcsinus", typeof(Arcsinus))]
        [TestCase("Arctangent", typeof(Arctangent))]
        [TestCase("Arccosinus", typeof(Arccosinus))]
        [TestCase("TwoSquaringArgument", typeof(TwoSquaringArgument))]
        [TestCase("Ctangent", typeof(Ctangent))]
        [TestCase("TenSquaringArgument", typeof(TenSquaringArgument))]
        [TestCase("OneDivisionArgument", typeof(OneDivisionArgument))]
        [TestCase("TenLogarithmArgument", typeof(TenLogarithmArgument))]
        [TestCase("TwoLogarithmArgument", typeof(TwoLogarithmArgument))]
        [TestCase("NegativeArgument", typeof(NegativeArgument))]
        [TestCase("Exponent", typeof(Exponent))]
        public void FirstTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

