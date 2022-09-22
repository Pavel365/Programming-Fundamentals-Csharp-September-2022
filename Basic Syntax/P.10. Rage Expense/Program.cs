using System;
using System.Diagnostics;

namespace P._10._Rage_Expense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headestPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();

            int headestcunt = lostGames/2; ;
            int mousecunt = lostGames/3;
            int keyboardcunt = lostGames/6;
            int displaycunt = lostGames/12;

            
            double tottal = headestcunt * headestPrice + mousecunt * mousePrice + keyboardcunt * keyboardPrice + displaycunt * displayPrice;
            Console.WriteLine($"Rage expenses: {tottal:F2} lv.");
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
