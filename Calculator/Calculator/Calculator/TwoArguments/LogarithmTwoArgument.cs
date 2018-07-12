using System;

namespace Calculator.TwoArguments
{
    public class LogarithmTwoArgument : ICalculator
    {/// <summary>
     /// calculate LogarithmTwoArgument function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}