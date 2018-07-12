using System;
namespace Calculator.OneArgument
{
    public class TwoLogarithmArgument : IOoneCalculator
    {
        /// <summary>
        /// calculate TwoLogarithmArgument function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Log(2, firstArgument);

        }
    }
}
