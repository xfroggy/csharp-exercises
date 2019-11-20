using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumNumbers = 0;
    

            
            for (int i=0; i<11; i++ )
            {
                numbers.Add(i);
            }
            
            for (int j=0; j<numbers.Count; j++)
            {
                if ((numbers[j])%2 == 0)
                {
                    sumNumbers += numbers[j];
                }
            }
            Console.WriteLine("Sum = {0}", sumNumbers);
            Console.ReadLine();
        }
    }
}
