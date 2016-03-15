﻿using LinqClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = InitPersons();
            PrintPersons(persons);
            

            //var malePersons = GetMalePersons(persons);
            //Func<Person, bool> isMale = (Person p) => p.Gender == Gender.Male;
            //Func<Person, bool> isMale = p => p.Gender == Gender.Male;
            //var malePersons = GetPersonsFilter(persons, isMale);
            var malePersons = GetPersonsFilter(persons, p => p.Gender == Gender.Male);
            PrintPersons(malePersons);

            var youngerThanFourtyPeople = GetYoungerThan(persons, 40);
            PrintPersons(youngerThanFourtyPeople);

            var peopleWithFirstNameLongerThanLastName = GetPeopleWithFirstNameLongerThanLastName(persons);
            PrintPersons(peopleWithFirstNameLongerThanLastName);
        }

        private static IEnumerable<Person> GetPersonsFilter(IEnumerable<Person> persons, Func<Person, bool> filter)
        {
            return persons.Where(filter);
        }

        private static IEnumerable<Person> GetPeopleWithFirstNameLongerThanLastName(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.FirstName.Length > p.LastName.Length);
        }

        private static IEnumerable<Person> GetYoungerThan(IEnumerable<Person> persons, int limit)
        {
            return persons.Where(p => p.Age < limit);
        }

        private static IEnumerable<Person> GetMalePersons(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.Gender == Gender.Male);
        }

        private static void PrintPersons(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("---------------------------");
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
