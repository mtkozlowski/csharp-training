using System;
using System.Collections.Generic;

namespace Loop_Solutions
{
    class Program
    {
        static void Main()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();

            Console.ReadKey();
        }

        private static void Exercise5()
        {
            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //    Find the maximum of the numbers and display it on the console. 
            //    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma.");
            var input = Console.ReadLine().Split(',');
            var numbersArray = new int[input.Length];
            var maxNumber = 0;
            for (var i = 0; i < numbersArray.Length; i++)
            {
                if (int.TryParse(input[i], out int number))
                    numbersArray[i] = number;

                if (maxNumber < number)
                    maxNumber = number;
            }

            Console.WriteLine("The highest number is {0}", maxNumber);
        }

        private static void Exercise4()
        {
            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.
            //    If the user guesses the number, display “You won"; otherwise, display “You lost".
            //    (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            var randomNumber = new Random().Next(1, 10);
            var guessCount = 4;
            Console.WriteLine("Guess a number, you have 4 guesses");
            while (guessCount != 0)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You did it!");
                    break;
                }
                guessCount--;
                Console.WriteLine("Sorry, you missed that! Only {0} chance(s) left.", guessCount);
            }
        }

        private static void Exercise3()
        {
            // 3- Write a program and ask the user to enter a number. 
            // Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("Give me an input for factorial: ");
            var factorial = Convert.ToInt32(Console.ReadLine());
            var factorialResult = 1;

            for (int i = factorial; i > 1; i--)
            {
                factorialResult *= i;
            }
            Console.WriteLine("Factorial: " + factorialResult);
        }

        private static void Exercise2()
        {
            // 2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.

            var input = "";
            var sumOfInputs = 0;
            do
            {
                if (int.TryParse(input, out int result))
                {
                    sumOfInputs += result;
                }
                Console.WriteLine("Give me a number or type 'ok' to finish and sum it up: ");
                input = Console.ReadLine();
            } while (input != "ok");

            Console.WriteLine("sumOfInputs: " + sumOfInputs);
        }

        private static void Exercise1()
        {
            // 1 - Write a program to count how many numbers between 1 and 100 
            // are divisible by 3 with no remainder.Display the count on the console.

            var dividable = new List<int>();
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                count += i % 3 == 0 ? 1 : 0;
            }

            Console.WriteLine("Total count of these numbers is: " + count);
        }
    }
}
