using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace P._10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command
                    .Split(":")
                    .ToArray();
                
                lessons = SoftUniCoursePlan(lessons, cmdArg);
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static List<string> SoftUniCoursePlan(List<string> lessons, string[] cmdArg)
        {
            string cmdType = cmdArg[0];

            if (cmdType == "Add")
            {
                lessons = Add(lessons, cmdArg); 
            }
            else if (cmdType == "Insert")
            {
                lessons = Insert(lessons, cmdArg);
            }
            else if (cmdType == "Remove")
            {
                lessons = Remove(lessons, cmdArg); 
            }
            else if (cmdType == "Swap")
            {
                lessons = Swap(lessons, cmdArg); 
            }
            else if (cmdType == "Exercise")
            {
                lessons = Exercise(lessons, cmdArg);
            }

            return lessons;
        }
        static List<string> Add(List<string> lessons, string[] cmdArg)
        {
            string lessonName = cmdArg[1];

            if (!lessons.Contains(lessonName))
            {
                lessons.Add(lessonName);
            }

            return lessons;
        }

        static List<string> Insert(List<string> lessons, string[] cmdArg)
        {
            string lessonName = cmdArg[1];
            int index = int.Parse(cmdArg[2]);

            if (index < 0 || index >= lessons.Count)
            {
                return lessons;
            }
            else if (!lessons.Contains(lessonName))
            {
                lessons.Insert(index, lessonName);
            }

            return lessons;
        }
        
        static List<string> Remove(List<string> lessons, string[] cmdArg)
        {
            string lessonName = cmdArg[1];

            if (lessons.Contains(lessonName))
            {
                lessons.Remove(lessonName);
            }
            else if (lessons.Contains(lessonName + "-Exercise"))
            {
                lessons.Remove(lessonName + "-Exercise");
            }

            return lessons;
        }

        static List<string> Swap(List<string> lessons, string[] cmdArg)
        {
            string lessonName = cmdArg[1];
            string lessonName1 = cmdArg[2];
            int index1 = lessons.IndexOf(lessonName);
            int index2 = lessons.IndexOf(lessonName1);

            if (lessons.Contains(lessonName) && lessons.Contains(lessonName1))
            {
                string tempLessonName = lessons.ElementAt(index1);
                lessons[index1] = lessons[index2];
                lessons[index2] = tempLessonName;
            }

            if (lessons.Contains(lessonName + "-Exercise") && lessons.Contains(lessons[index1]))
            {
                index1 = lessons.IndexOf(lessonName);
                lessons.Remove(lessonName + "-Exercise");
                lessons.Insert(index1 + 1, lessonName + "-Exercise");
            }
            else if (lessons.Contains(lessonName1 + "-Exercise") && lessons.Contains(lessons[index2]))
            {
                index2 = lessons.IndexOf(lessonName1);
                lessons.Remove(lessonName1 + "-Exercise");
                lessons.Insert(index2 + 1, lessonName1 + "-Exercise");
            }

            return lessons;
        }

        static List<string> Exercise(List<string> lessons, string[] cmdArg)
        {
            string lessonName = cmdArg[1];

            if (lessons.Contains(lessonName) && !lessons.Contains(lessonName + "-Exercise"))
            {
                int index = lessons.IndexOf(lessonName);
                lessons.Insert(index + 1, lessonName + "-Exercise");
            }
            else if (!lessons.Contains(lessonName))
            {
                lessons.Add(lessonName);
                lessons.Add(lessonName + "-Exercise");
            }

            return lessons;
        }
    }
}
