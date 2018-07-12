using System;
namespace Calculator.OneArgument
{
    public class Arcsinus : IOoneCalculator
    {/// <summary>
        /// calculate Arcsinus function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
