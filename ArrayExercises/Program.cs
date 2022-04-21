using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,1,2,3,5,8
            int[] integerArray = { 1, 1, 2, 3, 5, 8 };
            Console.WriteLine(integerArray);
            //for (int i = 0; i < integerArray.Length; i++)
            //{
            //    Console.WriteLine(integerArray[i]);
            //}

            foreach (int integer in integerArray)
            {
                if (integer % 2 == 1)
                {
                    Console.WriteLine(integer);
                }
            }
        }
    }
}
