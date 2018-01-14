using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class ClassEmployee
    {
        //Fields
        public string Name;
        public int Id;
        public string Position;
        public double Salary;
        public static double NewSalary = 0;

        //Constructor
        public ClassEmployee ()
        {
            Name = "Unknown";
            Id = 0;
            Position = "Unknown";
            Salary = 0;
        }

        public ClassEmployee(string name, int id, string position, double salary)
        {
            Name = name;
            this.Id = id;
            Position = position;
            this.Salary = salary;
        }

        //Methods
        public void PrintEmployeeInfo(ClassEmployee employee)
        {
            if(employee.Id == 1401700)
            {
                NewSalary = employee.Salary;
            }

            Console.WriteLine($"Name: {employee.Name}\n" +
                              $"Id: {employee.Id}\n" +
                              $"Position: {employee.Position}\n" +
                              $"Salary: {employee.Salary:C}\n" +
                              $"Compared to CEO´s salary: {CompareSalary(employee):C}");
                              
        }

        public static double CompareSalary(ClassEmployee employee)
        {
            double Comparison = 0;

            Comparison = employee.Salary - NewSalary;

            return Comparison;  
        }       
    }
}
