using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperatorOverload
{
    class Program
    {
        static void Main()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 7);
            Fraction c = new Fraction(2, 3);

            WriteLine((double)(a * b + c));
            ReadLine();
        }
    }
}
