using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOperations
{
    public class Power
    {
        public double Square(double x)
        {
            return x * x;
        }

        public double SquareRoot(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(x);
        }

        public double Cube(double x)
        {
            return x * x * x;
        }

        public double CubeRoot(double x)
        {
            return Math.Pow(x, 1.0 / 3);
        }

        public double Pwr(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double PowerWithRoot(double x, double root)
        {
            if (x < 0 && root % 2 == 0)
            {
                Console.WriteLine("Cannot calculate an even root of a negative number.");
            }
            return Math.Pow(x, 1.0 / root);
        }
    }
}
         
    



    

