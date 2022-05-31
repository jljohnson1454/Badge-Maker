using System;
using System.Collections.Generic;

namespace CatWorx.Badgemaker
{
    class Program
    {
            static List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>();
                while(true)
                {
                    Console.WriteLine("Please enter first name: (leave empty to exit): ");
                    string firstName = Console.ReadLine();
                    if (firstName == "")
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a last name(leave empty to exit): ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter ID:");
                    int id = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter Photo URL:");
                    string photoUrl = Console.ReadLine();

                    // Create a new employee instance
                    Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                    employees.Add(currentEmployee);
                }
                return employees;
            }

            
            static void Main(string[]args)
            {
                // Employee employee = new Employee();
                // employee.FirstName = input;

                List<Employee> employees = GetEmployees();
                Util.PrintEmployees(employees);
            }
        }
    
}