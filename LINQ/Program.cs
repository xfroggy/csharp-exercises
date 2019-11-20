using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() = { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009 },
                new Car() = { VIN = "B1", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2000 }

            };
            Console.ReadLine();
        }
    }
        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public double StickerPrice { get; set; }
            public int Year { get; set; }

        }
    
}
