using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Fraction
    {
        private int num, den;

        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        // overload operator +
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den,
                a.den * b.den);
        }

        // overload operator *
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }

        // user-defined conversion from Fraction to double
        public static implicit operator double(Fraction f)
        {
            return (double)f.num / f.den;
        }
    }
}
