using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle : IShape
    {
        public double Height {  get; set; }
        public double Base { get; set; }

        public Triangle(double height, double bs)
        {
            Height = height;
            Base = bs;
        }

        public double CalculateArea()
        {
            return 0.5 * Height * Base;
        }

        public double CalculatePerimeter()
        {
            return (Height * Base) / 2;
        }

    }
}
