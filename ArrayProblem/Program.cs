using System;
using System.Collections.Generic;

namespace ArrayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[] numbers = new int[6] { 1, 1, 2, 3, 5, 8};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
