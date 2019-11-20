using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public Dictionary<int, string> MenuCategories { get; private set; }
        public DateTime Updated { get; private set; }
        public List<MenuItem> MenuList { get; set; }

        public Menu ()
        {
            MenuList = new List<MenuItem>();
            Updated = DateTime.Now;
            MenuCategories = new Dictionary<int, string>();
            MenuCategories.Add(0, "Appetizers");
            MenuCategories.Add(1, "Main Dishes");
            MenuCategories.Add(2, "Desserts");
        }
        
    }



}
