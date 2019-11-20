using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;

        }

        public abstract int GetMonthlySalary();
       
    }
}
