﻿namespace Calculator.TwoArguments
{
    public class Add:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
