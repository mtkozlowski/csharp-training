using System;
using System.Collections.Generic;

namespace Arrays_And_Lists_Solutions
{
    internal class Program
    {
        private static void Main()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();
        }

        private static void Exercise5()
        {
            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.
            Console.WriteLine("please enter a list of at least 5 comma separated numbers(e.g 5, 1, 9, 2, 10).");
            var numbersList = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();
                var inputElements = input.Split(',');

                if (!string.IsNullOrWhiteSpace(input) && inputElements.Length >= 5)
                {
                    for (var i = 0; i < inputElements.Length; i++)
                    {
                        if (int.TryParse(inputElements[i], out int number))
                            numbersList.Add(number);
                    }
                    if (numbersList.Count == inputElements.Length)
                        break;
                }
                Console.WriteLine("Your list is invalid, please write it again: ");
            }

            numbersList.Sort();
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbersList[i]);
            }

        }

        private static void Exercise4()
        {
            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //    The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            var numbersList = new List<int>();
            Console.WriteLine("Give as many numbers you want or type QUIT to display the unique numbers");

            while (true)
            {
                var input = Console.ReadLine();
                if (input?.ToLower() == "quit")
                    break;

                numbersList.Add(Convert.ToInt32(input));
            }
            var uniqueNumbers = new List<int>();
            foreach (var i in numbersList)
            {
                if (!uniqueNumbers.Contains(i))
                    uniqueNumbers.Add(i);
            }

            Console.WriteLine("Your unique numbers: ");
            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.Write("{0} ", uniqueNumber);
            }

            Console.ReadKey();
        }

        private static void Exercise3()
        {
            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered,
            //display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
            //sort them and display the result on the console.

            Console.WriteLine("Give 5 different numbers: ");
            var numbersList = new List<int>();

            while (numbersList.Count != 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbersList.Contains(number))
                {
                    Console.WriteLine("This number was already given, please type another one: ");
                    continue;
                }
                numbersList.Add(number);
            }
            numbersList.Sort();

            Console.WriteLine("Your numbers in a sorted order:");
            foreach (var arg0 in numbersList)
                Console.Write("{0} ", arg0);
        }

        private static void Exercise2()
        {
            Console.WriteLine("Please, give us your name:");
            var nameInput = Console.ReadLine();
            if (nameInput != null)
            {
                var nameArray = new char[nameInput.Length];
                for (var i = nameArray.Length - 1; i >= 0; i--)
                {
                    nameArray[nameInput.Length - i - 1] = nameInput[i];
                }

                Console.WriteLine(nameArray);
            }
        }

        private static void Exercise1()
        {
            var friends = new List<string>();

            Console.Write("Type a name (or hit ENTER to quit): ");
            var inputFriend = Console.ReadLine();

            while (inputFriend != "")
            {
                friends.Add(inputFriend);
                inputFriend = Console.ReadLine();
            }

            if (friends.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", friends[0], friends[1], friends.Count - 2);
            else if (friends.Count == 2)
                Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
            else if (friends.Count == 1)
                Console.WriteLine("{0} likes your post.", friends[0]);
            else
                Console.WriteLine();
        }
    }
}
