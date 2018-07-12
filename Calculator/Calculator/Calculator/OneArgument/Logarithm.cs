using System;
namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator
    {
        /// <summary>
        /// calculate Logarithm function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0 || firstArgument == -1)
            {
                throw new Exception("Doest exsist");
            }
            return Math.Log(firstArgument);

        }
    }
}

