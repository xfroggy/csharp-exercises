using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
          
            

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "John";
            fte.LastName = "Jones";
            fte.AnnualSalary = 50000;

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            ContractEmployee cte = new ContractEmployee();
            cte.FirstName = "Lisa";
            cte.LastName = "Smith";
            cte.HourlyRate = 150;
            cte.HoursWorked = 40;

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());

            Console.ReadLine();





        }
    }
}
