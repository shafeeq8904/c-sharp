using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
                return;
            }

            int factorial = 1;
            for(int i=number;i>= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }
}