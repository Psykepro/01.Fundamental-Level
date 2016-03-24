using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Calculator
{
    class Program
    {
        static void Main()
        {
            Fraction fraction1=new Fraction(421514124,41266123);
            Fraction fraction2=new Fraction(614324124,3231515);
            Fraction resultFraction1 = fraction1 + fraction2;
            Fraction resultFraction2 = fraction1 - fraction2;
            Console.WriteLine(resultFraction1.Numerator);
            Console.WriteLine(resultFraction1.Denominator);
            Console.WriteLine(resultFraction1);
            Console.WriteLine(resultFraction2.Numerator);
            Console.WriteLine(resultFraction2.Denominator);
            Console.WriteLine(resultFraction2);
        }
    }
}
