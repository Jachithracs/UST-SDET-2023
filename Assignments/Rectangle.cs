using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape,IDrawable
    {
        public double Length, Width;
        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 *(Length + Width);
        }

        public void Draw()
        {
            Console.WriteLine("Shape is Rectangle \n Area of Rectangle : {0}\n Perimeter of Rectangle : {1} ", CalculateArea(), CalculatePerimeter());
        }
    }
}
