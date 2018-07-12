using System;
namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {/// <summary>
     /// calculate Factory
     /// </summary>
     /// <param name="calculatorName"></param>
     /// <returns></returns>
        public static IOneCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Module":
                    return new Module();
                case "Squaring":
                    return new Squaring();
                case "Logarithm":
                    return new Logarithm();
                case "Sinus":
                    return new Sinus();
                case "Cosinus":
                    return new Cosinus();
                case "Arcsinus":
                    return new Arcsinus();
                case "Arctangent":
                    return new Arctangent();
                case "Arccosinus":
                    return new Arccosinus();
                case "TwoSquaringArgument":
                    return new TwoSquaringArgument();
                case "Ctangent":
                    return new Ctangent();
                case "Tangent":
                    return new Tangent();
                case "TenSquaringArgument":
                    return new TenSquaringArgument();
                case "OneDivisionArgument":
                    return new OneDivisionArgument();
                case "TenLogarithmArgument":
                    return new TenLogarithmArgument();
                case "TwoLogarithmArgument":
                    return new TwoLogarithmArgument();
                case "NegativeArgument":
                    return new NegativeArgument();
                case "Exponent":
                    return new Exponent();
                case "Negative":
                    return new Negative();
                case "Root":
                    return new Root();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
