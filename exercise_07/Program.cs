using System;

namespace exercise_07
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and 
            dividing of two numbers which will be entered by the user. */
            
            Console.Write("Type the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
        }
    }
}
