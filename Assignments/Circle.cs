using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle : Shape,IDrawable
    {
        public double Radius;
        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Shape is Circle \n Area of Circle : {0}\n Perimeter of Circle : {1} ", CalculateArea(),CalculatePerimeter());
        }
    }
}
