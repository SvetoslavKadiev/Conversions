using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversion
{
    public class Digit
    {
        public double val;
        // ...other members

        public string key;

        public Digit(double val, string key)
        {
            this.val = val;
            this.key = key;
        }

        public Digit(double d)
        {
            val = d;
        }

        public Digit(string key)
        {
            this.key = key;
        }


        // User-defined conversion from Digit to double
        public static implicit operator double(Digit d)
        {
            return d.val;
        }

        // User-defined conversion from Digit to string
        public static implicit operator string(Digit d)
        {
            return d.key;
        }

        //  User-defined conversion from double to Digit
        public static implicit operator Digit(double d)
        {
            return new Digit(d);
        }

        //  User-defined conversion from double to Digit
        public static implicit operator Digit(string key)
        {
            return new Digit(key);
        }

        public override string ToString()
        {
            return $"{nameof(val)}: {val}; {nameof(key)}: {key}";
        }
    }
}
