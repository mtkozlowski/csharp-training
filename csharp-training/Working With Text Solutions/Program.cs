using System;
using System.Linq;

namespace Working_With_Text_Solutions
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
        }

        private static void Exercise5()
        {
            //5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.Make sure the program calculates the number of vowels irrespective of the casing of the word(eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).

            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine()?.ToLower();

            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var numberOfVowels = input.Count(character => vowels.Contains(character));
            Console.WriteLine(numberOfVowels);
        }

        private static void Exercise4()
        {
            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase. For example, if the user types: 
            //    "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by a space.");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var result = "";
            foreach (var s in input.Split(' '))
            {
                var pascalCaseWord = char.ToUpper(s[0]) + s.ToLower().Substring(1);
                result += pascalCaseWord;
            }

            Console.WriteLine(result);
        }

        private static void Exercise3()
        {
            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00).
            //    A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, 
            //    display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("Enter a time value in the 24 - hour time format(e.g. 19:00).");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var inputArray = input.Split(':');
            if (inputArray.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hours = Convert.ToInt32(inputArray[0]);
                var minutes = Convert.ToInt32(inputArray[1]);

                if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        private static void Exercise2()
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately;
            //    otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            Console.WriteLine("enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;

            var inputArray = input.Split('-');
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] != inputArray[i + 1]) continue;
                Console.WriteLine("Duplicate");
                break;
            }
        }

        private static void Exercise1()
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9"
            //        or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("enter a few numbers separated by a hyphen");
            var input = Console.ReadLine()?.Split('-');
            var result = "";
            for (var i = 0; i < input.Length - 1; i++)
            {
                var number = Convert.ToInt32(input[i]);
                if (Math.Abs(number - Convert.ToInt32(input[i + 1])) == 1) continue;
                result = "Not Consecutive";
                break;
            }
            if (result == "")
                result = "Consecutive";

            Console.WriteLine(result);
        }
    }
}
