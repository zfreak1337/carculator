using System;
namespace Calculator.OneArgument
{
    public class Cosinus : IOoneCalculator
    {/// <summary>
     /// calculate Cosinus function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);

        }
    }
}