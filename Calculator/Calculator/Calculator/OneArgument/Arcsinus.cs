using System;

namespace Calculator.OneArgument
{
    public class Arcsinus : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
