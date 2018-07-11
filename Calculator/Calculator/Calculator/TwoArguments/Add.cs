namespace Calculator.TwoArguments
{
 
    public class Add:ICalculator
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
