namespace Calculator.OneArgument
{
    public class OneDivisionArgument : IOneCalculator
    {/// <summary>
     /// calculate OneDivisionArgument function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return 1 / firstArgument;

        }
    }
}