using System;
using UtilityLibrary;

class Program
{
    static void Main()
    {
        SimpleCalculator calculator = new SimpleCalculator();

        int number_a = 5;
        int number_b = 7;

        Console.WriteLine("Sum of a and b: " + calculator.Add(number_a, number_b));
        Console.WriteLine("Multiply a and b: " + calculator.Multiply(number_a, number_b));
        Console.WriteLine("Is a greater than b? " + calculator.IsGreater(number_a, number_b));
    }
}