using System;
using System.Linq;

namespace P._02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] zeroState = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < zeroState.Length; i++)
            {
                if (zeroState[i] < 4)
                {
                    while(zeroState[i] < 4 && people > 0)
                    {
                        zeroState[i]++;
                        people--;
                    }
                }
            }

            if (people == 0 && zeroState.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", zeroState));
            }
            else if (people == 0 && zeroState.All(x => x == 4))
            {
                Console.WriteLine(string.Join(" ", zeroState));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", zeroState));
            }
        }
    }
}
