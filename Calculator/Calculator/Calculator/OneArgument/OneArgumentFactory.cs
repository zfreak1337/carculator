using System;

namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {
        public static IOoneCalculator CreateCalculator(string calculatorName)
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
