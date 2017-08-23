using System;
using System.Collections.Generic;

namespace Loop_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Write a program to count how many numbers between 1 and 100 
            // are divisible by 3 with no remainder.Display the count on the console.

            var dividable = new List<int>();
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                var i1 = i % 3 == 0 ? ++count : count;
            }

            Console.WriteLine("Total count of these numbers is: " + count);

            // 2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.

            var input = "";
            var sumOfInputs = 0;
            while (input != "ok")
            {
                Console.WriteLine("Give me a number or type 'ok' to finish and sum it up: ");
                input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                sumOfInputs += Convert.ToInt32(input);
            }

            Console.WriteLine("sumOfInputs: " + sumOfInputs);

            // 3- Write a program and ask the user to enter a number. 
            // Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("Give me an input for factorial: ");
            var factorial = Convert.ToInt32(Console.ReadLine());
            int factorialResult = 1;
            while (factorial != 0)
            {
                factorialResult *= factorial;
                factorial--;
            }
            Console.WriteLine("Factorial: " + factorialResult);

            Console.ReadKey();
        }
    }
}
