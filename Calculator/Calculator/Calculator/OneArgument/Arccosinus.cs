using System;
namespace Calculator.OneArgument
{
    public class Arccosinus : IOneCalculator
    {/// <summary>
    /// calculate arccosinus function
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Doest exsist");
            }
            return Math.Acos(firstArgument);
        }
    }
}
