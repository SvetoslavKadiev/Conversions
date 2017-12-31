using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ImplicitConversion
{

    class Program
    {
        static void Main(string[] args)
        {
            Digit dig = new Digit(7);

            //This call invokes the implicit "double" operator
            double num = dig;

            //This call invokes the implicit "Digit" operator
            Digit dig2 = 12;

            WriteLine("num = {0} dig2 = {1}", num, dig2.val);
            ReadLine();
        }
    }
}
