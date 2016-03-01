using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stole = new Person("Stojancho", "Jefremov", 0x17);
            //stole.FirstName = "Stojancho";
            //stole.LastName = "Jefremov";
            //stole.Age = 0x17;

            //Console.WriteLine($"Person is {stole.FirstName} {stole.LastName} and is {stole.Age}");
            Console.WriteLine($"Person is {stole.GetFullName()} and is {stole.Age} years old.");
        }
    }
}
