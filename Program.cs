using System;
using System.Collections.Generic;
using MathTools;

class Program
{
    static void Main()
    {
        int number_a = 5;
        int number_b = 7;

        Calculator calculator = new Calculator(number_a, number_b);

        calculator.Multiply(number_a, number_b);
    }
}

namespace MathTools
{
    class Calculator
    {
        public int a;
        public int b;

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Multiply(int a, int b)
        {            
            int c = b * a;           
            Console.WriteLine($"The sum is: {c} ");
            return c;
        }
    }
}


    