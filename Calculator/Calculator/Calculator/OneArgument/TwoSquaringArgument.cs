using System;

namespace Calculator.OneArgument
{
    public class TwoSquaringArgument : IOoneCalculator
    {/// <summary>
     /// calculate TwoSquaringArgument function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);

        }
    }
}