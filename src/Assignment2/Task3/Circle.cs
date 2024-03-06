using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return (3.1416 * Radius * Radius);
        }

        public double CalculatePerimeter()
        {
            return (2 * 3.1416 * Radius);   
        }
    }
}
