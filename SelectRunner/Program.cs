﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 2, 3, 5, 7, 8, 11, 13, 16 };
            numbers.Where(n => n % 2 == 1)
                    .Select(n => Math.Sqrt(n))
                    .ToList()
                    .ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
