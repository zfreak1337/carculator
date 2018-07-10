using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class TwoArgumentsFactory
    {
        public static WindowsFormsApp5 CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return new Multiply();
                case "Division":
                    return new Division();
                case "Add":
                    return new Add();
                case "Substraction":
                    return new Substraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
