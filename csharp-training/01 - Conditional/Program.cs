using System;

namespace conditional_solutions
{
    class Program
    {
        static void Main()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();

            Console.ReadKey();
        }

        private static void Exercise4()
        {
            //4 - Your job is to write a program for a speed camera.For simplicity, 
            //    ignore the details such as camera, sensors, etc and focus purely on the logic.
            //    Write a program that asks the user to enter the speed limit.Once set, the program 
            //    asks for the speed of a car.If the user enters a value less than the speed limit, 
            //    program should display Ok on the console.If the value is above the speed limit, 
            //    the program should calculate the number of demerit points.
            //    For every 5km / hr above the speed limit, 1 demerit points should be incurred 
            //    and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Please write a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give speed of a car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok.");
            }
            else
            {
                var demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("You were fined {0} demerit points!", demeritPoints);
                if (demeritPoints >= 12)
                    Console.WriteLine("Your license is SUSPENDED!");
            }
        }

        private static void Exercise3()
        {
            //3 - Write a program and ask the user to enter the width and height of an image.
            //    Then tell if the image is landscape or portrait.

            Console.WriteLine("Please give me width and height of a rectangle. First width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var answer = width >= height ? "It's landscape" : "It's portrait";
            Console.WriteLine(answer);
        }

        private static void Exercise2()
        {
            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Give me 2 numbers, now 1st one:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the second one:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The bigger number is: " + Math.Max(firstNumber, secondNumber));
        }

        private static void Exercise1()
        {
            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.
            //    If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
            //    (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            Console.WriteLine("Give me a number:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid number");
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
