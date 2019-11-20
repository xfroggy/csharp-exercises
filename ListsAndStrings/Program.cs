using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "confess", "lead", "mould", "impend", "ormer", "hoist", "snotty", "india" };

                foreach (string word in words)
                {
                    if (word.Length == 5) 
                    {
                        Console.WriteLine(word);    
                    }
                }
            Console.ReadLine();
        }
    }
}
