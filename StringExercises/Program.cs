using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string rhyme = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            // rhyme.split(' ');
            string[] splitRhyme = rhyme.Split(". ");
            //Console.WriteLine(string.Join(',', splitRhyme));
            foreach (string s in splitRhyme)
            {
                Console.WriteLine(s);
            }
        }
    }
}
