using System;
using System.Linq;
using System.Text;

namespace P._05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < @string.Length; i++)
            {
                char character = @string[i];

                if (char.IsDigit(character))
                {
                    numbers.Append(character);
                }
                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else
                {
                    other.Append(character);
                }
            }
            Console.WriteLine($"{numbers}");
            Console.WriteLine($"{letters}");
            Console.WriteLine($"{other}");
        }
    }
}
