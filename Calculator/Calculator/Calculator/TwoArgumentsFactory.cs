﻿using System;

namespace Calculator
{
    public class TwoArgumentsFactory
    {
        public static Calculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return  new Multiply();
                case "Division":
                    return  new Division();
                case "Add":
                    return  new Add();
                case "Substraction":
                    return  new Substraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
