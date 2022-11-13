using System;
using System.Collections.Generic;

namespace P._13._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            List<string> comments = new List<string>();

            string comment;
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                comments.Add(comment);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"\t{title}");
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine($"\t{content}");
            Console.WriteLine("</article>");

            foreach (var currComment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{currComment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
