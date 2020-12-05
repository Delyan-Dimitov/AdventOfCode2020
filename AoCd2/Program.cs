using System;
using System.Collections.Generic;
using System.Linq;

namespace AoCd2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string>();
            int counter = 0;
            int counter2 = 0;
            while (input != "STOP")
            {
                list.Add(input);
                input = Console.ReadLine();
            }
            // Part 1
            foreach (var item in list)
            {
                var arr = item.Split(" ").ToArray();
                var bounds = arr[0].Split("-").ToArray();
                int lowBound = int.Parse(bounds[0]);
                int upperBound = int.Parse(bounds[1]);
                char character = arr[1].First();
                var password = arr[2];
                int chCount = 0;
                foreach (char ch in password)
                {
                    if (ch == character)
                    {
                        chCount++;
                    }
                }
                if (chCount >= lowBound && chCount <= upperBound)
                {
                    counter++;
                }
                if (password[lowBound - 1] == character ^ password[upperBound - 1] == character )
                {
                    counter2++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(counter2);

            // Part 2
          
        }
    }
}
