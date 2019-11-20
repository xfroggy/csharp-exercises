using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            float miles;
            float gallons;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            miles = float.Parse(input);
            Console.WriteLine("How many gallons of gas have you consumed?");
            input = Console.ReadLine();
            gallons = float.Parse(input);
            Console.WriteLine("You are getting " + miles / gallons + " miles per gallon");

        }
    }
}
