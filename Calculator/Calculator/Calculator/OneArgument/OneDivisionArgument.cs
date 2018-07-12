using System;

namespace Calculator.OneArgument
{
    public class OneDivisionArgument : IOoneCalculator
    {/// <summary>
        /// calculate sinus function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return 1/firstArgument;

        }
    }
}