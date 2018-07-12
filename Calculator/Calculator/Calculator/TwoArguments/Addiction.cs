namespace Calculator.TwoArguments
{
    public class Addiction:ICalculator
    {
        /// <summary>
        /// calculate Addiction function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
