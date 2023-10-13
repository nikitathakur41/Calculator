using ArithmeticOperations;
using PowerOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator
{
    internal class ScientificCalculator
    {
        static void Main(string[] args)
        {
            //ArithmeticOperations.Arithmetic a=new ArithmeticOperations.Arithmetic();
            Arithmetic a = new Arithmetic();
            Power powerCalculator = new Power();
            
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulo (%)");
                Console.WriteLine("6. Square");
                Console.WriteLine("7. Square Root");
                Console.WriteLine("8. Cube");
                Console.WriteLine("9. Cube Root");
                Console.WriteLine("10. Power (x^y)");
                Console.WriteLine("11. Power with Root (x^(1/y))");
                Console.WriteLine("12. Exit");
                Console.Write("Enter your choice (1/2/3/4/5/6/7/8/9/10/11/12): ");
                string choice = Console.ReadLine();

                double num1, num2, result, number, exponent, root;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = a.Add(num1, num2);
                        Console.WriteLine("Result:" + num1 + num2 + " = " + result);
                        break;
                    case "2":
                        Console.Write("Enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = a.Subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        Console.Write("Enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = a.Multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        Console.Write("Enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        try
                        {
                            result = a.Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        Console.Write("Enter the first number: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        num2 = double.Parse(Console.ReadLine());
                        try
                        {
                            result = a.Modulo(num1, num2);
                            Console.WriteLine($"Result: {num1} % {num2} = {result}");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "6":
                        Console.Write("Enter a number: ");
                        number = double.Parse(Console.ReadLine());
                        result = powerCalculator.Square(number);
                        Console.WriteLine($"Result: {number} squared = {result}");
                        break;
                    case "7":
                        Console.Write("Enter a number: ");
                        number = double.Parse(Console.ReadLine());
                        result = powerCalculator.SquareRoot(number);
                        Console.WriteLine($"Result: Square root of {number} = {result}");
                        break;
                    case "8":
                        Console.Write("Enter a number: ");
                        number = double.Parse(Console.ReadLine());
                        result = powerCalculator.Cube(number);
                        Console.WriteLine($"Result: {number} cubed = {result}");
                        break;
                    case "9":
                        Console.Write("Enter a number: ");
                        number = double.Parse(Console.ReadLine());
                        result = powerCalculator.CubeRoot(number);
                        Console.WriteLine($"Result: Cube root of {number} = {result}");
                        break;
                    case "10":
                        Console.Write("Enter the base (x): ");
                        number = double.Parse(Console.ReadLine());
                        Console.Write("Enter the exponent (y): ");
                        exponent = double.Parse(Console.ReadLine());
                        result = powerCalculator.Pwr(number, exponent);
                        Console.WriteLine($"Result: {number}^{exponent} = {result}");
                        break;
                    case "11":
                        Console.Write("Enter the base (x): ");
                        number = double.Parse(Console.ReadLine());
                        Console.Write("Enter the root (1/y): ");
                        root = double.Parse(Console.ReadLine());
                        result = powerCalculator.PowerWithRoot(number, root);
                        Console.WriteLine($"Result: {number}^(1/{root}) = {result}");
                        break;
                    case "12":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}