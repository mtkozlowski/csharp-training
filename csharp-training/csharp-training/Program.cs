using System;

namespace csharp_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid number");
            else
            {
                Console.WriteLine("Invalid number");
            }

            Console.WriteLine("Give me 2 numbers, now 1st one:");
            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the second one:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The bigger number is: " + Math.Max(firstNumber, secondNumber));



            Console.ReadKey();
        }
    }
}
