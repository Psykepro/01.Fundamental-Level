using System;
using System.Globalization;
using System.Threading;

namespace _02.Interest_Calculator
{
    class Test
    {
        
        private const int InterestCompounded = 12;
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Func<decimal, decimal, int, decimal> simpleCalc = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compoundCalc = GetCompoundInterest;

            InterestCalculator simpleCalculation = new InterestCalculator(2500, 7.2m, 15, simpleCalc);
            InterestCalculator compoundCalculation = new InterestCalculator(500, 5.6m, 10, compoundCalc);

            Console.WriteLine("simple : " + simpleCalculation);
            Console.WriteLine("compound : "+compoundCalculation);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {          
            decimal result = sum *(1 + (interest / 100 * years));
            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            int n = 12;
            decimal result = sum * (decimal)Math.Pow((double)(1 + (interest / 100 / InterestCompounded)), years * InterestCompounded);
            return result;
        }
    }
}
