using System;

namespace P._05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  numPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pay = 0;

            if (typeGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    pay = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pay = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pay = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    pay = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pay = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pay = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    pay = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pay = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pay = 22.50;
                }
            }

            double tottalPay = pay * numPeople;

            if (numPeople >= 30 && typeGroup == "Students")
            {
                tottalPay -= (0.15 * tottalPay);
            }
            else if (numPeople >= 100 && typeGroup == "Business")
            {
                tottalPay = tottalPay - 10 * pay;
            }
            else if (numPeople >= 10 && numPeople <= 20 && typeGroup == "Regular")
            {
                tottalPay -= (0.05 * tottalPay);
            }

            Console.WriteLine($"Total price: {tottalPay:F2}");
        }
    }
}
