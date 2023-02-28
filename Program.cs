using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
           Company company = new Company("Phoney's", DateTime.Now);
            // Create three employees

            Employee employee1 = new Employee
            {
                    FirstName = "Phoney",
                    LastName = "McPhoney",
                    Title = "CEO",
                    StartDate = DateTime.Now
            };

            Employee employee2 = new Employee

             {
                    FirstName = "honey",
                    LastName = "Mchoney",
                    Title = "CEO",
                    StartDate = DateTime.Now
            };

            Employee employee3 = new Employee

            {
                    FirstName = "Phone",
                    LastName = "McPhone",
                    Title = "CEO",
                    StartDate = DateTime.Now
            };
 
            // Assign the employees to the company
        company.Employees.Add(employee1);
        company.Employees.Add(employee2);
        company.Employees.Add(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above */
        company.ListEmployees();
}
    }
}

