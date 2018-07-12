using System;
namespace Calculator.TwoArguments
{
    public class SquareDifference : ICalculator
    {/// <summary>
        /// calculate SquareDifference function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) - Math.Pow(secondArgument, 2);
        }
    }
}
