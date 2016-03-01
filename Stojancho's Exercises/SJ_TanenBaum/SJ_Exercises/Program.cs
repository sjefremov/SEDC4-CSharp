using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz.printFizzBuzz();

            var rectangle = new Rectangle(10, 3);
            Console.WriteLine($"{rectangle} has area {rectangle.Area} and perimeter {rectangle.Perimeter}");

            Console.ReadLine();
        }
    }
}
