using System;
using System.Runtime.Intrinsics.Arm;

namespace P._03.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length-1; i >= 0 ; i--)
            {
                char currCh = username[i];
                password += currCh;
            }

            int tottalTries = 0;
            string eneredPassoword;
            while ((eneredPassoword = Console.ReadLine()) != password)
            {
                tottalTries++;
                if (tottalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (tottalTries < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}
