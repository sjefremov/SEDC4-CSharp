using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ_Exercises
{
    public class Rectangle
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }

        public int Perimeter
        {
            get
            {
                return 2 * (Width + Height);
            }
        }

        public override string ToString()
        {
            return $"Rectangle({Width}, {Height})";
        }

    }
}
