using System;

namespace Lab1Q2
{
    internal class Program
    {
        public static int[] GetFactors(int num)
        {
            int[] factors = new int[num / 2];
            int j = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    factors[j++] = i;
            }
            return factors;
        }

        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                var factors = GetFactors(i);
                int sumOfFactors = SumOfFactors(factors);
                if (sumOfFactors == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}