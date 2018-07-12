using System;
namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator
    {
        /// <summary>
        /// calculate Logarithm function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);

        }
    }
}

