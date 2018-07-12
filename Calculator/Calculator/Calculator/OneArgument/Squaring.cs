using System;
namespace Calculator.OneArgument
{
    public class Squaring : IOneCalculator
    {/// <summary>
        /// calculate Squaring function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);

        }
    }
}
