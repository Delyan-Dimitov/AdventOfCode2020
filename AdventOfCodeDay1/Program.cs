using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<int>();
            while ( input != "STOP")
            {
                list.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            // Part 1
            foreach (var number in list.Where(x => x < 1000))
            {
                foreach (var secondNumber in list.Where(x => x >=1000))
                {
                    if (number + secondNumber == 2020)
                    {
                        Console.WriteLine(number * secondNumber);
                        break;
                    }
                }
            }

            // Part 2
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[i] + list[j] + list[k] == 2020)
                        {
                            Console.WriteLine(list[i] * list[j] * list[k]);
                            return;
                        }
                    }
                }
            }
        }
    }
}
