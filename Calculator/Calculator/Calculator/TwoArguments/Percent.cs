namespace Calculator.TwoArguments
{
    public class Percent : ICalculator
    {/// <summary>
        /// calculate Percent function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / 100) * (secondArgument + 100);
        }
    }
}
