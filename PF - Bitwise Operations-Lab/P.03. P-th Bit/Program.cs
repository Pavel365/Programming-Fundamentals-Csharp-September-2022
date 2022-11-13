using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._P_th_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int result = (number & mask) >> position;
            Console.WriteLine(result);
        }
    }
}
