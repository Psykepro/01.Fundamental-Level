using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.PrintVersion();
            list.Add(10);
            list.Add(1);
            list.Add(0);
            list.Add(20);
            Console.WriteLine("max" + list.Max());
            Console.WriteLine("min" + list.Min());
            Console.WriteLine("Is list contains 1 : {0}",list.Contains(1));
            Console.WriteLine(list);
            list.Remove(1);
            Console.WriteLine(list);
            Console.WriteLine("Is list contains 0 after remove : {0}", list.Contains(1));
            list.Add(-1);
            Console.WriteLine("Index of 20 : {0}",list.IndexOf(20));
            Console.WriteLine("Print list before clear : {0}", list);
            list.Clear();
            Console.WriteLine("Print list after clear : {0}", list);
        }
    }
}
