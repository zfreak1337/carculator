using System;

namespace Calculator.OneArgument
{
    public class Negative : IOoneCalculator
    {/// <summary>
        /// calculate Negative function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
