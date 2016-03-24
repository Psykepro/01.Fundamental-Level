using System;
using System.Collections.Generic;
using _01.Point3D;

namespace Path
{
    class PathMain
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 4, 1);
            Point3D point2 = new Point3D(-4, 10, 2);
            Point3D point3 = new Point3D(4, 1, 2);
            Point3D point4 = new Point3D(5,2,1);

            List<Point3D> list = new List<Point3D>() { point1, point2, point3 };
            Path3D path1 = new Path3D(list);

            Path3D path2 = new Path3D(new List<Point3D>() { point4, point1 });
            path2.AddPoints(point2);

            Path3D path3 = new Path3D(point4);
            path3.AddPoints(point1);

            Storage.SavePath("../../path.txt", path2);
            Path3D loaded = Storage.LoadPath("../../path.txt");
            Console.WriteLine(loaded);

        }
    }


}
