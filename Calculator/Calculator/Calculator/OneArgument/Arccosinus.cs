using System;

namespace Calculator.OneArgument
{
    public class Arccosinus : IOoneCalculator
    {/// <summary>
    /// calculate arccosinus function
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
