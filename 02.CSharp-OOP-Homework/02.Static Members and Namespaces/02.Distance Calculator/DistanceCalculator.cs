using System;
using _01.Point3D;

namespace _02.Distance_Calculator
{
    class DistanceCalculator
    {
        static void Main()
        {
            Point3D point1=new Point3D(3,2,-1);
            Point3D point2=new Point3D(5,2,10);
            CalculateDistance.Calculator(point1,point2);
        }
    }
}
