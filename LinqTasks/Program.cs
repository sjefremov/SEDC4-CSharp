﻿using LinqClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = InitPersons();

            var sumFemaleAges = persons.Where(p => p.Gender == Gender.Female).Sum(p => p.Age);

            var age = 10;
            var firstYoungerThan = persons.FirstOrDefault(p => p.Age < age);
            if (firstYoungerThan == null)
            {
                Console.WriteLine($"No one is under {age} years old.");
            }
            else
            {
                Console.WriteLine($"First person under {age} is {firstYoungerThan}");
            }

            
            var maxAge = persons.Max(p => p.Age);
            Console.WriteLine("The oldest ones: ");
            persons.Where(p => p.Age == maxAge)
                    .ToList()
                    .ForEach(Console.WriteLine);

            var theOldestOne = persons.OrderByDescending(p => p.Age).First();
            Console.WriteLine($"The oldest one is {theOldestOne}");

        }

        private static IEnumerable<Person> InitPersons()
        {
            var persons = new List<Person>();
            persons.Add(new Person
            {
                FirstName = "Walter",
                LastName = "White",
                Age = 52,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Jesse",
                LastName = "Pinkman",
                Age = 31,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Skyler",
                LastName = "White",
                Age = 41,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Walter Jr",
                LastName = "White",
                Age = 18,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Hank",
                LastName = "Schrader",
                Age = 48,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Marie",
                LastName = "Schrader",
                Age = 38,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Gustavo",
                LastName = "Fring",
                Age = 49,
                Gender = Gender.Male
            });

            persons.Add(new Person
            {
                FirstName = "Lydia",
                LastName = "Rodarte-Quayle",
                Age = 33,
                Gender = Gender.Female
            });

            persons.Add(new Person
            {
                FirstName = "Saul",
                LastName = "Goodman",
                Age = 54,
                Gender = Gender.Male
            });

            return persons;
        }
    }
}
