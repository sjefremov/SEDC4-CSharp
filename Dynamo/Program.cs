using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic person = DynCreator.GetSomeObject(ObjectType.Person);
            person.FirstName = "Weko";
            Console.WriteLine(person);

            dynamic vehicle = DynCreator.GetSomeObject(ObjectType.Vehicle);
            vehicle.Year = 1997;
            Console.WriteLine(vehicle);

            dynamic rectangle = DynCreator.GetSomeObject(ObjectType.Rectangle);
            rectangle.Height = 30;
            Console.WriteLine(rectangle);

        }
    }


}
