using System;

namespace Calculator.OneArgument
{
    public class Arccosinus : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
