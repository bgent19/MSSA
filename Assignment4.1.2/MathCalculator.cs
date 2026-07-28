using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4._1._2
{
    public class MathCalculator : ICalculator
    {
        public double Add(double a, double b) { return a + b; }
        public double Subtract(double a, double b) { return a - b; }
        public double Multiply(double a, double b) { return a * b; }
        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b; }
    }
}
