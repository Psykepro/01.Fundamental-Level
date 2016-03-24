using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Shapes
{
    class Triangle:BasicShape
    {
        private double c;
           public Triangle(double a, double b,double c) : base(a, b)
           {
               this.C = c;
           }

        public double C
        {
            get { return this.c; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value","Cannot be negative!");
                }
                this.c = value;
            }
        }

        public override double CalculateArea()
        {
            return (this.Height*this.Width)/2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width+this.Height+this.C;
        }
        public override string ToString()
        {
            return string.Format("Triangle Area : {0:F2}, Perimeter : {1:F2}", this.CalculateArea(), this.CalculatePerimeter());
        }
    }
}
