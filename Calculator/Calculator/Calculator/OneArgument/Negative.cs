namespace Calculator.OneArgument
{
    public class Negative : IOneCalculator
    {/// <summary>
        /// calculate Negative function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
