using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P._12._MorseCodeTrans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" | ")
                .ToArray();

            List<string> output = new List<string>();

            foreach (string morseWord in input)
            {
                string[] morseLetters = morseWord
                    .Split()
                    .ToArray();

                StringBuilder word = new StringBuilder();

                foreach (string morseLetter in morseLetters)
                {
                    switch (morseLetter)
                    {
                        case ".-":
                            word.Append("A");
                            break;
                        case "-...":
                            word.Append("B");
                            break;
                        case "-.-.":
                            word.Append("C");
                            break;
                        case "-..":
                            word.Append("D");
                            break;
                        case ".":
                            word.Append("E");
                            break;
                        case "..-.":
                            word.Append("F");
                            break;
                        case "--.":
                            word.Append("G");
                            break;
                        case "....":
                            word.Append("H");
                            break;
                        case "..":
                            word.Append("I");
                            break;
                        case ".---":
                            word.Append("J");
                            break;
                        case "-.-":
                            word.Append("K");
                            break;
                        case ".-..":
                            word.Append("L");
                            break;
                        case "--":
                            word.Append("M");
                            break;
                        case "-.":
                            word.Append("N");
                            break;
                        case "---":
                            word.Append("O");
                            break;
                        case ".--.":
                            word.Append("P");
                            break;
                        case "--.-":
                            word.Append("Q");
                            break;
                        case ".-.":
                            word.Append("R");
                            break;
                        case "...":
                            word.Append("S");
                            break;
                        case "-":
                            word.Append("T");
                            break;
                        case "..-":
                            word.Append("U");
                            break;
                        case "...-":
                            word.Append("V");
                            break;
                        case ".--":
                            word.Append("W");
                            break;
                        case "-..-":
                            word.Append("X");
                            break;
                        case "-.--":
                            word.Append("Y");
                            break;
                        case "--..":
                            word.Append("Z");
                            break;
                    }
                }

                output.Add(word.ToString());
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
