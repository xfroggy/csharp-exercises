using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            string input;
            do
            {
                Console.WriteLine("Please give me the radius:");
                input = Console.ReadLine();
                radius = float.Parse(input);
                if (radius < 0)
                    Console.WriteLine("Negative number, please retry");
            }
            while (radius < 0);
    

                area = 3.1417 * radius * radius;
                Console.WriteLine($"The area of your circle is: {area}");
                Console.ReadLine();
            
        }
    }
}
