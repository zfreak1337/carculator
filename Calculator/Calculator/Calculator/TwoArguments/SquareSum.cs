using System;
namespace Calculator.TwoArguments
{
    public class SquareSum : ICalculator
    {/// <summary>
        /// calculate SquareSum function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow((firstArgument + secondArgument), 2);
        }
    }
}
