using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace CSharpConceptBoldLab.Linq
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }


        

       
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Fazila",
                Job = "Manager",
                City = "New York",
                Salary = 50000,
                Age = 35
            },
            new Employee
            {
                Id = 2,
                Name = "John",
                Job = "Developer",
                City = "Los Angeles",
                Salary = 60000,
                Age = 28
            },
            new Employee
            {
                Id=3,
                Name="Monika",
                Job="Developer",
                City="Dhaka",
                Salary=70000,
                Age = 27
            },
            new Employee
            {
                Id=4,
                Name="Rashid",
                Job="Manager",
                City="Dhaka",
                Salary=80000,
                Age = 40
            }
        };
            //Find all employees who live in Dhaka and have a salary of 50,000 or more.
            var  empDhk = emp.Where(e => e.City=="Dhaka" && e.Salary >= 50000).ToList();
            foreach (var employee in empDhk)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Job: {employee.Job}, City: {employee.City}, Salary: {employee.Salary}, Age: {employee.Age}");
            }

            //2. Return only Name, Job, and Salary for every employee.
            var empInfo = emp.Select(e => new
            {
                e.Name,
                e.Job,
                e.Salary
            }).ToList();
            foreach (var employee in empInfo)
            {
                Console.WriteLine($"Name: {employee.Name}, Job: {employee.Job}, Salary: {employee.Salary}");
            }

            //Sort employees by Salary highest to lowest.If two employees have the same salary, sort them by Name alphabetically.
            var empName = emp.OrderByDescending(e => e.Salary).OrderBy(e => e.Name).ToList();
            foreach (var employee in empName)
            {
                Console.WriteLine($"Name: {employee.Name}, Job: {employee.Job}, Salary: {employee.Salary}");
            }
            //

        }
    }
}
