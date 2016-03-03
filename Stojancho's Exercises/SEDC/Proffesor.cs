using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC
{
    public class Proffesor : Person
    {
        public string Biography { get; set; }

        public override string ToString()
        {
            var result = base.ToString();
            result += Environment.NewLine + "Biography: " + Biography;
            return result;
        }

    }
}
