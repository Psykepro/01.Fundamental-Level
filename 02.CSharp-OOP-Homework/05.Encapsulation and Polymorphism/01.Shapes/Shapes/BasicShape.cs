using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes
{
   abstract class BasicShape:IShape
   {
       private double width;
       private double height;
       public BasicShape(double width,double heigth)
       {
           this.Width = width;
           this.Height = heigth;
       }
       public double Width
       {
           get { return this.width; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("value", "Cannot be negative!");
               }
               this.width = value;
           }
       }
       public double Height
       {
           get { return this.height; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("value", "Cannot be negative!");
               }
               this.height = value;
           }
       }
       public abstract double CalculateArea();
       public abstract double CalculatePerimeter();
   }

}
