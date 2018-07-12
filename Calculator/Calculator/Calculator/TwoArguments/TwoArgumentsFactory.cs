using System;
namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {/// <summary>
     ///  Factory 
     /// </summary>
     /// <param name="calculatorName"></param>
     /// <returns></returns>

        public static ICalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return  new Multiply();
                case "Division":
                    return  new Division();
                case "Add":
                    return  new Addiction();
                case "Substraction":
                    return  new Substraction();
                case "SquaringTwoArguments":
                    return new SquaringTwoArguments();
                case "SquarinigDivisionTwoArgument":
                    return new SquaringDivisionTwoArguments();
                case "SquareAdd":
                    return new SquareAdd();
                case "SquareSum":
                    return new SquareSum();
                case "percent":
                    return new Percent();
                case "negativeDegree":
                    return new NegativeDegree();
                case "SquareDifference":
                    return new SquareDifference();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
