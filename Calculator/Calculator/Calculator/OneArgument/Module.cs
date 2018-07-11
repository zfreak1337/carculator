using System;

namespace Calculator.OneArgument
{
    public class Module : IOoneCalculator
    {/// <summary>
        /// calculate Module function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }
    }
}
