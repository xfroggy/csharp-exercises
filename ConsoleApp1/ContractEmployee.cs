using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ContractEmployee:BaseEmployee
    {
        public int HourlyRate { get; set; }
        public int HoursWorked { get; set; }

      

        public override int GetMonthlySalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
