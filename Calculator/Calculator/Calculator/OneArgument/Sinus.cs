using System;
namespace Calculator.OneArgument
{
    public class Sinus : IOneCalculator
    {/// <summary>
        /// calculate sinus function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }
    }
}
