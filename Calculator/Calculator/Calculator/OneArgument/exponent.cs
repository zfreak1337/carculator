using System;
namespace Calculator.OneArgument
{
    public class Exponent : IOoneCalculator
    {
        /// <summary>
        /// calculate Exponent function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(Math.E, firstArgument);
        }
    }
}