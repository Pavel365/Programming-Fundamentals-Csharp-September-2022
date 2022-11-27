using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P._05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine().
                Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            SortedDictionary<string, int> demonHealths = new SortedDictionary<string, int>();
            SortedDictionary<string, double> demonDamages = new SortedDictionary<string, double>();

            string pattern = @"-?\d+\.?\d*";
            Regex regex = new Regex(pattern);

            foreach (string demon in demons)
            {
                int health = demon
                    .Where(s => !char.IsDigit(s)
                    && s != '+' && s != '-' && s != '*' && s != '/' && s != '.')
                    .Sum(s => (int)s);

                demonHealths[demon] = health;

                MatchCollection matches = regex.Matches(demon);

                double damage = 0.0;

                foreach (Match match in matches)
                {
                    string value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (char symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                demonDamages[demon] = damage;

            }

            foreach (var demon in demonDamages)
            {
                var demonName = demon.Key;
                var demonHealth = demonHealths[demonName];
                var demonDamage = demon.Value;

                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }
    }
}
