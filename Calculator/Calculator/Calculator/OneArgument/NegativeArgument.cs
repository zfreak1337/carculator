using System;
namespace Calculator.OneArgument
{
    public class NegativeArgument : IOoneCalculator
    {
        /// <summary>
        /// calculate NegativeArgument function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return -firstArgument;

        }
    }
}