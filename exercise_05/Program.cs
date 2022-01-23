using System;

namespace exercise_05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Write a C# Sharp program to swap two numbers.
            
            int num1 = 5; int num2 = 6; int x;
            x = num1;
            num1 = num2;
            num2 = x;
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
        }
    }
}
