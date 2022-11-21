using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company bobsBurgers = new Company("Bob's Burgers", new DateTime(2020, 07, 04));
            // Create three employees
            Employee janReno = new Employee();
            janReno.FirstName = "Jan";
            janReno.LastName = "Reno";
            janReno.Title = "Cashier";
            janReno.StartDate = new DateTime(2020, 07, 04);

            Employee bobBurger = new Employee();
            bobBurger.FirstName = "Bob";
            bobBurger.LastName = "Burger";
            bobBurger.Title = "Chef";
            bobBurger.StartDate = new DateTime(2020, 07, 04);

            Employee jimmySmith = new Employee();
            jimmySmith.FirstName = "Jimmy";
            jimmySmith.LastName = "Smith";
            jimmySmith.Title = "Cook";
            jimmySmith.StartDate = new DateTime(2020, 08, 12);


            // Assign the employees to the company
            bobsBurgers.Employees.Add(janReno);
            bobsBurgers.Employees.Add(bobBurger);
            bobsBurgers.Employees.Add(jimmySmith);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            bobsBurgers.ListEmployees();
        }
    }
}
