using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FullTimeEmployee: BaseEmployee
    {
        
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
