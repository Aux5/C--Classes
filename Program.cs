using System;
using System.Collections.Generic;

namespace classes
{

    class Program
    {
        public class Employee {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string title { get; set; }
            public DateTime startDate {get ; set;}
        }
        public class Company {
            public string companyName { get; set;}
            public List<Employee> Employees = new List<Employee>();
            public DateTime dateFounded {get ; set;}

            public void ListCompany(){

                foreach (Employee employee in Employees)
                {
                    Console.WriteLine($"{employee.firstName} {employee.lastName} works at Table Makers Incorborated and started on {employee.startDate}");
                }
            }

        }
    
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
                Company tableMakers = new Company(){
                companyName = "Table Makers",
                dateFounded = new DateTime(2018, 8, 30),

                };
            
            // Create three employees

            Employee jordy = new Employee(){
                firstName = "Jordy",
                lastName = "Krasinski",
                title = "Table Stander",
                startDate = new DateTime(2018, 8, 30),

            };
            Employee austin = new Employee(){
                firstName = "Austin",
                lastName = "Pabes",
                title = "Table Sitter",
                startDate= new DateTime(2018, 8, 20),

            };
            Employee jenn = new Employee(){
                firstName = "Jenn",
                lastName = "Craples",
                title = "Table Squatter",
                startDate = new DateTime(2018, 8, 10),

            };

            // Assign the employees to the company
            tableMakers.Employees.Add(jordy);
            tableMakers.Employees.Add(austin);
            tableMakers.Employees.Add(jenn);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            tableMakers.ListCompany();
        }
    }
}
    



