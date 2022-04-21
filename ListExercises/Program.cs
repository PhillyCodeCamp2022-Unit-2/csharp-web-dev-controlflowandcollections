using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list with at least 10 integers in it
            //int[] integerArray = [];
            List<int> numberList = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            // sum of integerList evens would be ----> 30
            // Call our AddEvensOnly method and pass in our numberList
            Console.WriteLine(AddEvensOnly(numberList));
        }

        // Write a static method to find the sum of all the even numbers in a List.
        // input: list of integers (TypeScript: array of numbers)
        // output: sum of all even integers in said list (TypeScript: sum of even numbers in array)
        // TypeScript method sig: 
        // static addEvensOnly(integerList: number[]) : number {}
        static int AddEvensOnly(List<int> integerList)
        {
            // let's take this integerList and add up any even integers from it
            int sum = 0;
            // sum += even numbers
            foreach (int integer in integerList)
            {
                if (integer % 2 == 0)
                {
                    sum += integer;
                }
            }

            return sum;
        }
    }
}
