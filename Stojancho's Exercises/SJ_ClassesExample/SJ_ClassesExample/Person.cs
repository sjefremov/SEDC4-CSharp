using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_ClassesExample
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = -1;
        }

        private string firstName;
        private string lastName;
        private int age;

        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public void SetAge(int value)
        //{
        //    if (value < 0)
        //    {
        //        throw new Exception($"Invalid age value of {value}");
        //    }
        //    this.age = value;
        //}

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Invalid age value of {value}");
                }
                this.age = value;
            }
        }
    }
}
