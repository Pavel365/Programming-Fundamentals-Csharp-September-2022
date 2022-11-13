using System;
using System.Collections.Generic;
using System.Linq;

namespace P._02._Bit_at_Position1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << 1;

            int result = (n & mask) >> 1;
            Console.WriteLine(result);
        }
    }
}
