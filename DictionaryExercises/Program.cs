using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // The keys should be the ID numbers (as integers) and the values should be the names
            Dictionary<int, string> students = new Dictionary<int, string>();

            // key: 1, value: "Sam"
            students[1] = "Sam";
            // students.Add(1, "Sam"); is the same thing
            // key: 2, value: "Francesca"
            students[2] = "Francesca";
            // students.Add(2, "Francesca");
            students.Add(0, "Pearce");

            Console.WriteLine(students);

            foreach (KeyValuePair<int, string> kvp in students)
            {
                Console.WriteLine($"ID: {kvp.Key} Name: {kvp.Value}");
            }
        }
    }
}
