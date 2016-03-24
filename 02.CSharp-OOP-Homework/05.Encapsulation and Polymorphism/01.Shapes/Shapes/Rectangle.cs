using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    class Rectangle:BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Height*this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2*(this.Width + this.Height);
        }
        public override string ToString()
        {
            return string.Format("Rectangle Area : {0:F2}, Perimeter : {1:F2}", this.CalculateArea(), this.CalculatePerimeter());
        }
    }
}
