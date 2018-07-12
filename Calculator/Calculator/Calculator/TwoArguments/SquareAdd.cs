using System;
namespace Calculator.TwoArguments
{
    public class SquareAdd : ICalculator
    {/// <summary>
        /// calculate SquareAdd function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) + Math.Pow(secondArgument, 2);
        }
    }
}
