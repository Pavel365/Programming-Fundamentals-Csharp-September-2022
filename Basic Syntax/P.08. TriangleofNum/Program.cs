using System;

namespace P._08._TriangleofNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{ rows} ");
                }
                Console.WriteLine();
            }
        }
    }
}
