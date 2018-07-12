using System;

namespace Calculator.TwoArguments
{
    public class SquaringTwoArguments : ICalculator
    {/// <summary>
     /// calculate SquaringTwoArguments function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}