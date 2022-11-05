using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace P._13.__Take.Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<string> nonNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skiplist = new List<int>();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numbers.Add(int.Parse(message[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(message[i].ToString());
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skiplist.Add(numbers[i]);
                }
            }

            string result = string.Empty;
            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = nonNumbers
                    .Skip(index)
                    .Take(takeList[i])
                    .ToList();

                result += string.Concat(temp);
                index += takeList[i] + skiplist[i];
            }

            Console.WriteLine(result);
        }
    }
}
