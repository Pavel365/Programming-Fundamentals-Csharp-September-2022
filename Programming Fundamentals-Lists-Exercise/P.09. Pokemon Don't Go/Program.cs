using System;
using System.Collections.Generic;
using System.Linq;

namespace P._09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distancePokemon = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedElement = 0;
            int sum = 0;

            while (distancePokemon.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int firstElement = distancePokemon[0];
                int lastElement = distancePokemon[distancePokemon.Count - 1];

                if (index >=0 && index < distancePokemon.Count)
                {
                    removedElement = distancePokemon[index];
                    distancePokemon.RemoveAt(index);
                }
                else if (index < 0)
                {
                    removedElement = firstElement;
                    distancePokemon.RemoveAt(0);
                    distancePokemon.Insert(0,lastElement);
                }
                else if (index > distancePokemon.Count - 1)
                {
                    removedElement = lastElement;
                    distancePokemon.RemoveAt(distancePokemon.Count - 1);
                    distancePokemon.Add(firstElement);
                }

                sum += removedElement;

                for (int i = 0; i < distancePokemon.Count; i++)
                {
                    int currrNum = distancePokemon[i];
                    if (currrNum <= removedElement)
                    {
                        currrNum += removedElement;
                        distancePokemon[i] = currrNum;
                    }
                    else if (distancePokemon[i] > removedElement)
                    {
                        currrNum -= removedElement;
                        distancePokemon[i] = currrNum;   
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
