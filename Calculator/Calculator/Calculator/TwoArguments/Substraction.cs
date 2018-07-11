namespace Calculator.TwoArguments
{
    public class Substraction: ICalculator
    {/// <summary>
        /// calculate Subsraction function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument-secondArgument;
        }
    }
}
