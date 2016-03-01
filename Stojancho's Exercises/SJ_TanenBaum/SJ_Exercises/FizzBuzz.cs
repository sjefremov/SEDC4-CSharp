using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_Exercises
{
    public class FizzBuzz
    {
        public static void printFizzBuzz(int n = 100)
        {
            //for (int i = 0; i < n; i++)
            //{
            //    var num = i + 1;
            //    if (num % 3 != 0 && num % 5 != 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    else
            //    {
            //        if (num % 3 == 0)
            //        {
            //            Console.Write("Fizz");
            //        }
            //        if (num % 5 == 0)
            //        {
            //            Console.Write("Buzz");
            //        }
            //        Console.WriteLine();
            //    }

            //}

            Enumerable.Range(1, 100).Select(
                        num =>
                        (num % 15 == 0) ? "FizzBuzz" :
                        (num % 3 == 0) ? "Fizz" :
                        (num % 5 == 0) ? "Buzz" :
                        num.ToString())
                        .ToList()
                        .ForEach(Console.WriteLine);

        }
    }
}
