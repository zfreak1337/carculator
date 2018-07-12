using System;
namespace Calculator.TwoArguments
{
    public class NegativeDegree : ICalculator
    {/// <summary>
        /// calculate NegativeDegree function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, (secondArgument * (-1)));
        }
    }
}
