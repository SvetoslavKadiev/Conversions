using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConversion
{
    class Celsius
    {
        private float degrees;

        public Celsius(float temp)
        {
            degrees = temp;
        }

        public float Degrees
        {
            get { return degrees; }
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
        }
        
    }
}
