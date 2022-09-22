using System;

namespace P._09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int freeBelts = 0;
            for (int i = 1; i <= numStudents; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double numStudents1 = Math.Ceiling(numStudents + numStudents * 0.10);

            decimal tottalPrice = lightsabersPrice*((decimal)numStudents1) + robesPrice*numStudents+
                + beltsPrice*(numStudents - freeBelts);


            if (tottalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {tottalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(tottalPrice - money):F2}lv more.");
            }

        }
    }
}
