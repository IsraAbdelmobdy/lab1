using System;

namespace Lab1Q1
{
    internal class Program
    {
        public static double Calculator(double x, double y, char op)
        {
            if (op == '+')
                return x + y;
            else if (op == '-')
                return x - y;
            else if (op == '*')
                return x * y;
            else
                return x / y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operation (+ - * /) : ");
            char op = Convert.ToChar(Console.ReadLine());
            double result = Calculator(a, b, op);
            Console.WriteLine(result);

        }
    }
}