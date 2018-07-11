namespace Calculator.TwoArguments
{
 
    public class Addiction:ICalculator
    {/// <summary>
        /// calculate Addiction function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
