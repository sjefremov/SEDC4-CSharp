using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC
{
    public class Subject
    {
        public string Name { get; set; }
        public Proffesor Lecturer { get; set; }
        public Assistant Assistant { get; set; }
        public List<Student> Students { get; set; }

        public Staff Coordinator { get; set; }

        public override string ToString()
        {
            var result = string.Empty;

            result += "Subject name: " + Name;

            result += Environment.NewLine + "Lecturer: " + Lecturer;
            result += Environment.NewLine + "Assistant: " + Assistant;
            result += Environment.NewLine + "Coordinator: " + Coordinator;

            foreach (var student in Students)
            {
                result += Environment.NewLine + "Student: " + student;
            }

            return result;
        }
    }
}
