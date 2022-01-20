using System;

namespace exercise_05
{
    class Program
    {
        // Write a C# Sharp program to swap two numbers.
        static void Main(string[] args)
        {
            int num1 = 5; int num2 = 6; int x;
            x = num1;
            num1 = num2;
            num2 = x;
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
        }
    }
}
