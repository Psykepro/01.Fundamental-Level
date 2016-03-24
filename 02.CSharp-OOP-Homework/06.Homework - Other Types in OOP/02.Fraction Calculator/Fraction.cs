using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Calculator
{
    struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public Fraction(BigInteger a,BigInteger b):this()
        {
            this.Numerator = a;
            this.Denominator = b;
        }

       
     
        
        public BigInteger Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807 || value == 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Cannot be 0 or under than -9223372036854775808 or higher than 9223372036854775807!");
                }
                this.numerator = value;
            }
        }
        public BigInteger Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807 || value == 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Cannot be 0 or under than -9223372036854775808 or higher than 9223372036854775807!");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}",this.Numerator/this.Denominator);
        }
    }
}
