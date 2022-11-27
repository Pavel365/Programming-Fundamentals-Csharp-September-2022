using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P._04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackPlanets = new List<string>();
            List<string> destryedPlanets = new List<string>();

            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>\d+";

            Regex rg = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match match = rg.Match(decryptedMessage);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destryedPlanets.Add(planetName);
                    }
                }
            }

            PrintPlanets(attackPlanets, "Attacked");
            PrintPlanets(destryedPlanets, "Destroyed");
        }

        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder sb = new StringBuilder(); 
            int decrypedSpet = GetDecryptedStep(encryptedMessage);

            foreach (char oldCh in encryptedMessage)
            {
                sb.Append((char)(oldCh - decrypedSpet));
            }

            return sb.ToString();
        }

        static int GetDecryptedStep(string encryptedMessage)
        {
            int decryptionStep = 0;
            foreach (char ch in encryptedMessage.ToLower())
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                {
                    decryptionStep++;
                }
            }

            return decryptionStep;
        }

        static void PrintPlanets(List<string> planets, string attacType)
        {
            Console.WriteLine($"{attacType} planets: {planets.Count}");

            foreach (string name in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
