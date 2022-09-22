using System;

namespace P._12._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n > n1 && n > n2)
            {
                if (n1 > n2)
                {
                    Console.WriteLine(n);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }
            if (n1 > n && n1 > n2)
            {
                if (n > n2)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n);
                }
            }
            if (n2 > n && n2 > n1)
            {
                if (n > n1)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n);
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n);
                }
            }
        }
    }
}
