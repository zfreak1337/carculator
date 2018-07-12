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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
