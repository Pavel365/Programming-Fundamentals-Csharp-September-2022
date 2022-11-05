using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArg[0];

                if (cmdArg.Length == 3)
                {
                    if (guestsList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestsList.Add(name);
                }
                else if (cmdArg.Length == 4)
                {
                    if (!guestsList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestsList.Remove(name);
                }
                    
            }

            GuestsList(guestsList);
        }

        static void GuestsList (List<string> guestsList)
        {
            foreach (string name in guestsList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
