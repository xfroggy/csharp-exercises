using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<string, int> letters =
                new Dictionary<string, int>();

            Console.WriteLine("Here is the phrase:\n");
            Console.WriteLine(phrase);

            for (int i = 0; i<phrase.Length; i++)
            {
                if (letters.ContainsKey(phrase.Substring(i,1)))
                {
                    letters[phrase.Substring(i, 1)] = letters[phrase.Substring(i, 1)] + 1;

                }
                else
                {
                    letters.Add(phrase.Substring(i, 1), 1);
                }

            }

            foreach (KeyValuePair<string, int> letter in letters)
            {
                Console.WriteLine(letter.Key + " : " + letter.Value);
            }

            Console.ReadLine();
        }
    }
}
