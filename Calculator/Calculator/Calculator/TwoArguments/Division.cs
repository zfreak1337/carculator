namespace Calculator.TwoArguments
{
   public class Division: ICalculator
    {/// <summary>
        /// calculate Division function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
