using System;
using System.Collections.Generic;


namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Menu
            Menu CurrentMenu = new Menu();

            //Instantiate MenuItems
            MenuItem bruschetta = new MenuItem("Bruschetta", "Tomato and fresh basil served over garlic toast", 7.95, "Appetizers");
            MenuItem halibut = new MenuItem("Halibut", "White fish", 45.95, "Main Dishes");
            MenuItem tiramisu = new MenuItem("Tiramisu", "Italian dessert with lady fingers, coffee and Marscapone cheese", 8.95, "Desserts");

            MenuItem siumai = new MenuItem("Siu Mai", "Steamed pork dumplings", 7.95, "Appetizers");
            MenuItem filet = new MenuItem("Beef filet", "10 oz filet of aged Black Angus beef", 45.95, "Main Dishes");
            MenuItem chocolate = new MenuItem("Chocolate Decadence", "Flourless chocoate cake", 8.95, "Desserts");

            //to Add an item to the menu
            CurrentMenu.MenuList.Add(bruschetta);
            CurrentMenu.MenuList.Add(halibut);
            CurrentMenu.MenuList.Add(tiramisu);
            CurrentMenu.MenuList.Add(siumai);
            CurrentMenu.MenuList.Add(filet);
            CurrentMenu.MenuList.Add(chocolate);

            //to Remove an item from the menu
            CurrentMenu.MenuList.Remove(bruschetta);

            //Re-add an item to the menu
            CurrentMenu.MenuList.Add(bruschetta);

            //To test if MenuItem is new and print out entire menu
            foreach (MenuItem item in CurrentMenu.MenuList)
            { 
                
                Console.WriteLine("Menu item "+item.Name+" is new? " + item.IsNew());
            }

            //To print out a menu item
            Console.WriteLine("Here is an individual menu item to print out");
            Console.WriteLine(bruschetta.ToString());

            //To print out entire menu
            Console.WriteLine("Our Menu");
                foreach (KeyValuePair<int, string> kvp in CurrentMenu.MenuCategories)
                {
                   Console.WriteLine(kvp.Value);
                   foreach (MenuItem item in CurrentMenu.MenuList)
                    {
                        if (item.Category == kvp.Value)
                        {
                            Console.WriteLine(item.ToString());
                        }

                    }
                }


            /*

        // The unsorted menu
        Console.WriteLine("This is the unsorted menu");
        foreach (MenuItem item in CurrentMenu.MenuList)
            Console.WriteLine(item.ToString());
              */



            //To tell when menu was last updated
            Console.WriteLine("This menu was last updated:  "+CurrentMenu.Updated);

            //Test if equals
            Console.WriteLine("Test if equal");
            Console.WriteLine("Bruschetta and Tiramisu");
            Console.WriteLine(bruschetta.Equals(tiramisu));
            Console.WriteLine(bruschetta.GetHashCode().Equals(tiramisu.GetHashCode()));
            Console.WriteLine("Bruschetta and Bruschetta");
            Console.WriteLine(bruschetta.Equals(bruschetta));
            Console.WriteLine(bruschetta.GetHashCode().Equals(bruschetta.GetHashCode()));

            Console.ReadLine();

        }

      


    }

        
}

