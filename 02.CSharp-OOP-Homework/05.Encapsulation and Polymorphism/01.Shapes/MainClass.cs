using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;
using _01.Shapes.Shapes;

namespace _01.Shapes
{
    class MainClass
    {
        static void Main()
        {
            IShape[] shapes=new IShape[]
            {
                new Rectangle(4,5),
                new Circle(9),
                new Triangle(7,9,12), 
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
