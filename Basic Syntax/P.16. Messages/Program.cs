using System;

namespace P._16._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string sms = string.Empty;
            char ch = '0';

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();

                if (num == "2")
                {
                    ch = 'a';
                }
                else if (num == "22")
                {
                    ch = 'b';
                }
                else if (num == "222")
                {
                    ch = 'c';
                }
                else if (num == "3")
                {
                    ch = 'd';
                }
                else if (num == "33")
                {
                    ch = 'e';
                }
                else if (num == "333")
                {
                    ch = 'f';
                }
                else if (num == "4")
                {
                    ch = 'g';
                }
                else if (num == "44")
                {
                    ch = 'h';
                }
                else if (num == "444")
                {
                    ch = 'i';
                }
                else if (num == "5")
                {
                    ch = 'j';
                }
                else if (num == "55")
                {
                    ch = 'k';
                }
                else if (num == "555")
                {
                    ch = 'l';
                }
                else if (num == "6")
                {
                    ch = 'm';
                }
                else if (num == "66")
                {
                    ch = 'n';
                }
                else if (num == "666")
                {
                    ch = 'o';
                }
                else if (num == "7")
                {
                    ch = 'p';
                }
                else if (num == "77")
                {
                    ch = 'q';
                }
                else if (num == "777")
                {
                    ch = 'r';
                }
                else if (num == "7777")
                {
                    ch = 's';
                }
                else if (num == "8")
                {
                    ch = 't';
                }
                else if (num == "88")
                {
                    ch = 'u';
                }
                else if (num == "888")
                {
                    ch = 'v';
                }
                else if (num == "9")
                {
                    ch = 'w';
                }
                else if (num == "99")
                {
                    ch = 'x';
                }
                else if (num == "999")
                {
                    ch = 'y';
                }
                else if (num == "9999")
                {
                    ch = 'z';
                }
                else if (num == "0")
                {
                    ch = ' ';
                }

                sms += ch;
            }
            Console.WriteLine(sms);
        }
    }
}
