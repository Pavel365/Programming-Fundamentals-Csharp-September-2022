using System;
using System.Collections.Generic;

namespace P._13._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(getFibonacci(number, new Dictionary<int, long>()));
        }

        private static long getFibonacci(int n, Dictionary<int, long> dict)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                if (dict.ContainsKey(n))
                {
                    return dict[n];
                }
                else
                {
                    dict.Add(n, getFibonacci(n - 1, dict) + getFibonacci(n - 2, dict));
                    return (getFibonacci(n - 1, dict) + getFibonacci(n - 2, dict));
                }
            }
        }
    }
}
