using System;

namespace P._01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = 
            { 
                "Excellent product.",
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.",
                "Exceptional product.", 
                "I can’t live without this product."
            };

            string[] events =
            { 
                "Now I feel good.", 
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", 
                "I feel great!" 
            };

            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities =
            { 
                "Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse" 
            };

            Random phrase = new Random();
            Random eventes = new Random();
            Random author = new Random();
            Random town = new Random();
            
            for (int i = 1; i <= n; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);
                int eventIndex = eventes.Next(0, events.Length);
                int authorIndex = author.Next(0, authors.Length);
                int citiesIndex = town.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[citiesIndex]}");
            }
        }
    }
}
