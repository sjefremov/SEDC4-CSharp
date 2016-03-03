using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC
{
    public abstract class Person
    {
        public string EMBG { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            var result = string.Empty;
            result += Environment.NewLine + "EMBG: " + EMBG;
            result += Environment.NewLine + "First name: " + FirstName;
            result += Environment.NewLine + "Last name: " + LastName;
            return result;
        }
    }
}
