using System;

namespace Wonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string word;
            bool condition;


            Console.WriteLine("Input a string and I'll see if it's in my text...");
            condition = false;    
            word = Console.ReadLine();
            word = word.ToLower();
            text = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            text = text.ToLower();
     
            string[] textArray = new string[text.Length];
            textArray = text.Split(' ');
            for (int i=0; i<textArray.Length; i++)
            {
                /*Console.WriteLine(textArray[i] + " : " + word);*/
                if (textArray[i] == word)
                    condition = true;   
            }
            if (condition == false)
                Console.WriteLine(" No, your word is not in my text");
            else Console.WriteLine("Yes, your word is in my text");    

        }
    }
}
