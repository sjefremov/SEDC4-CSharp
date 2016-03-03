using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharp = new Subject
            {
                Name = "Visual Studio with C#",
                Lecturer = new Proffesor
                {
                    EMBG = "1212978410001",
                    FirstName = "Wekoslav",
                    LastName = "Stefanovski",
                    Biography = "Weko's biography..."
                },
                Assistant = new Assistant
                {
                    EMBG = "1110988410001",
                    FirstName = "Ace",
                    LastName = "Marce",
                    BeerCapacity = new Random().Next()
                },
                Students = new List<Student>
                {
                    new Student
                    {
                        EMBG = "1308992490009",
                        FirstName = "Stojancho",
                        LastName = "Jefremov",
                        PriorExperience = "Stojancho's PriorExperience..."
                    },
                    new Student
                    {
                        EMBG = "2509988495009",
                        FirstName = "Jasmina",
                        LastName = "Shuteva",
                        PriorExperience = "Jasmina's PriorExperience..."
                    },
                    new Student
                    {
                        EMBG = "1506989455009",
                        FirstName = "Darko",
                        LastName = "Gorgievski",
                        PriorExperience = "Darko's PriorExperience..."
                    }
                },
                Coordinator = new Staff
                {
                    EMBG = "1506978435009",
                    FirstName = "Orce",
                    LastName = "Petreski",
                }
            };
            Console.WriteLine(csharp);
        }
    }
}
