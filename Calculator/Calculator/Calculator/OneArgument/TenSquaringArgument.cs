using System;
namespace Calculator.OneArgument
{
    public class TenSquaringArgument : IOneCalculator
    {/// <summary>
        /// calculate TwoSquaringArgument function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);

        }
    }
}