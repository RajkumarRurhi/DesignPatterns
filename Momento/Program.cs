using System;

namespace Momento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Raj";
            employee.ContactNumber = "111-111-1111";
            employee.Address = "123 main road city state";
            Console.WriteLine($"State 0 - {employee}");

            EmployeeMomentoCareTaker careTaker = new EmployeeMomentoCareTaker();
            careTaker.Save(employee);

            employee.ContactNumber = "222-222-2222";
            Console.WriteLine($"State 1 - {employee}");
            careTaker.Save(employee);

            employee.ContactNumber = "333-333-3333";
            employee.Address = "456 second street city state";
            Console.WriteLine($"State 2 - {employee}");
            careTaker.Save(employee);

            employee.ContactNumber = "444-444-4444";

            Console.WriteLine($"Employee object without save - {employee}");

            careTaker.Revert(employee);
            Console.WriteLine($"Reverted to State 2 - {employee}");

            careTaker.Revert(employee);
            Console.WriteLine($"Reverted to State 1 - {employee}");

            careTaker.Revert(employee);
            Console.WriteLine($"Reverted to State 0 - {employee}");

            Console.ReadLine();
        }
    }
}
