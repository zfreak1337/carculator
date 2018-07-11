namespace Calculator.TwoArguments
{
   public class Multiply:ICalculator
    {/// <summary>
        /// calculate Multiply function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
