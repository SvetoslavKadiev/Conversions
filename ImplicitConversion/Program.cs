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
            Digit dig = new Digit(7, "svetlio");
            WriteLine(dig.ToString());

            //This call invokes the implicit "double" operator
            double num = dig;
            string key = dig;

            //This call invokes the implicit "Digit" operator
            Digit dig2 = 12;
            WriteLine($"dig2 \t {dig2}");

            Digit key2 = "jeni";
            WriteLine($"key2 \t {key2}");

            ReadLine();
        }
    }
}
