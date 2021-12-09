using System;
using System.Collections.Generic;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            List<IEmployee> employees = employeeRepo.GetEmployees();

            foreach(IEmployee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadLine();
        }
    }
}
