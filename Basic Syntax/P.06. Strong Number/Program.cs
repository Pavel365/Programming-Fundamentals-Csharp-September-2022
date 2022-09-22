using System;

namespace P._06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int sumFactorial = 0;

            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sumFactorial += factorial;
            }

            if (sumFactorial == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
