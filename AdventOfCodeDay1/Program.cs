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
        }
    }
}
