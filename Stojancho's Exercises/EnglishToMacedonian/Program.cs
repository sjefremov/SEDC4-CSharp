﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToMacedonian
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator.ToMacedonian("girl").ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
