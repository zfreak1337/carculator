using System;
namespace Calculator.OneArgument
{
    public class Cosinus : IOneCalculator
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