using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Restaurant
{

    public class MenuItem
    {
        static int itemId;

        public int ItemId { get; private set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime Created { get; private set; }


        public MenuItem(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Created = DateTime.Now;
            ItemId = Interlocked.Increment(ref itemId);
           
     
        }
        public bool IsNew()
        {
            if ((Created - DateTime.Now).TotalDays < 7)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return "$"+Price+" "+Name+" - "+Description;
        }

        public override bool Equals(Object o)
        {
            if (o == this)
            {
                return true;
            }

            if ((o == null) || o.GetType() != GetType())
    {
                return false;
            }

            MenuItem menuObj = o as MenuItem;
            return ItemId == menuObj.ItemId;
        }

        public override int GetHashCode()
        {
            return ItemId;
        }

    }
}
