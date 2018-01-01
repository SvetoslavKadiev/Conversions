using System;
using static System.Console;

namespace ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the temperature: ");
            float temp = (float)Convert.ToDecimal(ReadLine());
            
            Fahrenheit fahr = new Fahrenheit(temp);
            WriteLine("   {0} Fahrenheit", fahr.Degrees);

            Celsius c = (Celsius)fahr;
            WriteLine(" = {0} Celsius", c.Degrees.ToString("0.00"));

            Fahrenheit fahr2 = (Fahrenheit)c;
            WriteLine(" = {0} Fahrenheit", fahr2.Degrees);

            ReadLine();
        }
    }
}
