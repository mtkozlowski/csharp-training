using System;
using System.IO;

namespace Working_with_Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.
            //2 - Write a program that reads a text file and displays the longest word in the file.

            const string path = @"C:\Projects\csharp-training\csharp-training\Working with Files\bin\Debug\tekst.txt";
            if (File.Exists(path))
            {
                var tekst = File.ReadAllText(path).Split(' ');
                Console.WriteLine("number of words: {0}", tekst.Length);
                var longestWordIndex = 0;
                for (int i = 0; i < tekst.Length - 1; i++)
                {
                    if (tekst[i].Length < tekst[i + 1].Length)
                    {
                        longestWordIndex = i + 1;
                    }
                }
                Console.WriteLine("The longest word has {0} character and it is: {1}", tekst[longestWordIndex].Length, tekst[longestWordIndex]);
            }


        }
    }
}
