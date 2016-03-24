using System;
using _01.Point3D;
namespace _02.Distance_Calculator
{
    static class CalculateDistance
    {

        public static void Calculator(Point3D A, Point3D B)
        {
            Console.WriteLine("Distance : {0}",Math.Sqrt(Math.Pow(B.X-A.X,2)+Math.Pow(B.Y-A.Y,2)+Math.Pow(B.Z-A.Z,2)));
        }
    }
}
