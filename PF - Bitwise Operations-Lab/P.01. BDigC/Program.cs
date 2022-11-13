using System;

namespace P._01._BDigC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            byte counter = 0;

            while (n > 0)
            {
                if (n % 2 == b)
                {
                    counter++;
                }
                n /= 2;
            }

            Console.WriteLine(counter);
        }
    }
}
