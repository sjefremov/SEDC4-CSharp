using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_TanenBaum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number of rows: ");
            //var numRows = int.Parse(Console.ReadLine());

            //printTanenBaum(numRows);

            

            

            Console.ReadLine();
        }

        private static void printTanenBaum(int numRows)
        {
            var numSpaces = numRows - 1;
            var numStars = 1;

            for (int row = 0; row < numRows; row++)
            {
                for (int i = 0; i < numSpaces; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < numStars; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                numSpaces--;
                numStars += 2;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < numRows - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }

        


    }
}
