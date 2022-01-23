using System;

namespace exercise_06
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to print the output of multiplication of three numbers which 
            will be entered by the user. */

            Console.Write("Type the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} * {num2} * {num3} = {num1 * num2 * num3}");
        }
    }
}
