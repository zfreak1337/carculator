using System;

namespace Calculator.OneArgument
{
    public class Tangent : IOoneCalculator
    {/// <summary>
        /// calculate Ctangent function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}