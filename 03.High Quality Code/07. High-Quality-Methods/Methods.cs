﻿using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides cannot be negative.");
            }
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static string NumberToDigit(int number)
        {           
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:throw new FormatException("Invalid number!");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements must exist and cannot be negative,");
            }
            int maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }

        static void PrintAsNumber(object number, string format)
        {
            
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format.");
            }
        }


        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool IsHorizontal(double x1, double y1, double x2, double y2)
        {
            return (y1 == y2);          
        }
        static bool IsVertical(double x1, double y1, double x2, double y2)
        {
            return (x1 == x2);
        }
        
            
        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + IsVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
