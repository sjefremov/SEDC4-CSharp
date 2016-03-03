using System;

namespace SEDC
{
    public class Assistant : Person
    {

        public int BeerCapacity{ get; set; }

        public override string ToString()
        {
            var result = base.ToString();
            result += Environment.NewLine + "Beer capacity: " + BeerCapacity;
            return result;
        }
    }
}