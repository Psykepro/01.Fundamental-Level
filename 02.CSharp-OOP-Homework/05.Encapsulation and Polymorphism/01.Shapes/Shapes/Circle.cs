using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Shapes
{
    class Circle:IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value","Cannot be negative!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*this.Radius*this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*this.Radius;
        }

        public override string ToString()
        {
            return string.Format("Circle Area : {0:F2}, Perimeter : {1:F2}", this.CalculateArea(), this.CalculatePerimeter());
        }
    }
}
