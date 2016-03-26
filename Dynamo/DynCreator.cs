using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamo
{
    static class DynCreator
    {
        static private Random r = new Random();

        static private Dictionary<ObjectType, dynamic> mapper =
            new Dictionary<ObjectType, dynamic>
            {
                { ObjectType.Person, new Person { FirstName = "Wekoslav", LastName = "Stefanovski" }  },
                { ObjectType.Vehicle, new Vehicle { Make = "Toyota", Model = "Corolla", Year = 2005 }  },
                { ObjectType.Rectangle, new Rectangle { Width = 10, Height = 5 }  },
            };
            

        //public static dynamic GetSomeObject()
        //{
        //    return GetSomeObject(r.NextDouble());
        //}

        public static dynamic GetSomeObject(ObjectType objectType)
        { 
            return mapper[objectType];
        }

    }

    public enum ObjectType
    {
        Person,
        Vehicle,
        Rectangle
    }
  
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} from {Year}";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area { get { return Width * Height; } }

        public double Perimeter { get { return 2 * (Width + Height); } }

        public override string ToString()
        {
            return $"Rectangle ({Width}, {Height})";
        }
    }
}
