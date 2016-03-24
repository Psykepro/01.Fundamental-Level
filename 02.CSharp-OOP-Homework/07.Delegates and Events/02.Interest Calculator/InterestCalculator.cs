using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interest_Calculator
{
    internal class InterestCalculator
    {
        private decimal sum;
        private int years;
        private decimal interest;

        public InterestCalculator(decimal sum,decimal interest,int years,Func<decimal,decimal,int,decimal> calculator)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.TotalSum = calculator(sum,interest,years);
        }

        public decimal Sum
        {
            get { return this.sum; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The sum cannot be negative!");
                }
                this.sum = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The years cannot be negative!");
                }
                this.years = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest;}
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest cannot be negative!");
                }
                this.interest = value;
            }           
        }

        public decimal TotalSum { get; set; }
        public override string ToString()
        {
            return string.Format("Sum : {0}, Interest : {1}, Years : {2}, Total Sum : {3}", this.Sum, this.Interest,
                this.Years, this.TotalSum);
        }
    }
}
