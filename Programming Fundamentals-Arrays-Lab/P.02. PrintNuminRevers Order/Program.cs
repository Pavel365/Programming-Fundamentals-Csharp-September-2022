using System;
using System.Runtime.Intrinsics.Arm;

namespace P._02._PrintNuminRevers_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] copyArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                copyArr[i] = array[array.Length-i-1];
            }
            Console.Write(string.Join(" ", copyArr));
        }
    }
}
