using System;

namespace Calculator
{
    abstract class Calculator
    {
        public abstract double Calculate(double num1, double num2);

        public void Start()
        {
            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, num2);
            Console.WriteLine("Result: " + result);
        }
    }

    class Addition : Calculator
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Subtraction : Calculator
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class Multiplication : Calculator
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class Division : Calculator
    {
        public override double Calculate(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    class Percentage : Calculator
    {
        public override double Calculate(double num1, double num2)
        {
            return (num1 * num2) / 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select operation: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Percentage");
            int choice = int.Parse(Console.ReadLine());

            Calculator calculator = null;

            switch (choice)
            {
                case 1:
                    calculator = new Addition();
                    break;
                case 2:
                    calculator = new Subtraction();
                    break;
                case 3:
                    calculator = new Multiplication();
                    break;
                case 4:
                    calculator = new Division();
                    break;
                case 5:
                    calculator = new Percentage();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (calculator != null)
            {
                calculator.Start();
            }

            Console.ReadLine();
        }
    }
}
