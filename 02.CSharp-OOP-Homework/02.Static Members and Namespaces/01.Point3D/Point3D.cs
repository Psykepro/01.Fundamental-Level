using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingPoint3D=new Point3D(0,0,0);
        private double x;
        private double y;
        private double z;
        static public Point3D StartingPoint3D { get { return startingPoint3D; }}
        public Point3D(int x,int y,int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D(double x, double y, double z)
        {
            // TODO: Complete member initialization
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D()
        {
            // TODO: Complete member initialization
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return string.Format("3D Points :\r\nX : {0}\r\nY : {1}\r\nZ : {2}", this.X, this.Y, this.Z);
        }
    }
    
}
