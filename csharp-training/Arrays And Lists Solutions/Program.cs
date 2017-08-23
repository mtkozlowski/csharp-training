using System;
using System.Collections.Generic;

namespace Arrays_And_Lists_Solutions
{
    class Program
    {
        static void Main(string[] args)
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
