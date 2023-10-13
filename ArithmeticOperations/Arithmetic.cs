using ArithmeticOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    public class Arithmetic
    {

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            return num1 / num2;
        }

        public double Modulo(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Modulo by zero is not allowed.");
            }
            return num1 % num2; 
        }
    }
}


