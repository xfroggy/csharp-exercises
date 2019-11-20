using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int length;
            int width;
            Console.WriteLine("Please enter the width:");
            input = Console.ReadLine();
            width = int.Parse(input);
            Console.WriteLine("Please enter the length:");
            input = Console.ReadLine();
            length = int.Parse(input);
            Console.WriteLine("The area of a rectangle that is " + width + " by " + length + " is " + width * length);

        }
    }
}
