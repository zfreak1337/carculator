using System;

namespace Calculator.TwoArguments
{
    public class SquaringDivisionTwoArguments : ICalculator
    {/// <summary>
     /// calculate  SquaringDivisionTwoArguments function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, (1/secondArgument));
        }
    }
}