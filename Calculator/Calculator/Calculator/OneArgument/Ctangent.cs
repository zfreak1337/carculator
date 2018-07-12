using System;
namespace Calculator.OneArgument
{
    public class Ctangent : IOneCalculator
    {/// <summary>
        /// calculate Ctangent function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}