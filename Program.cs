using System;
using System.Collections.Generic;

namespace DogWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to fetch user data from the API? (Y/N)");
            string reply = Console.ReadLine();
            if (reply == "Y" || reply == "y")
            {
                List<Employee> employees = PeopleFetcher.GetFromAPI();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }
            else
            {
                List<Employee> employees = PeopleFetcher.GetEmployees();
                Util.PrintEmployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }



        }

    }

}
