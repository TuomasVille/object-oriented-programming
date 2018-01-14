using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassEmployee[] employees = new ClassEmployee[3];
            employees[0] = new ClassEmployee("Kelly", 1401700, "CEO", 250000);
            employees[0].PrintEmployeeInfo(employees[0]);
            Console.WriteLine();

            employees[1] = new ClassEmployee("Olly", 1401701, "Marketing manager", 35000);
            employees[1].PrintEmployeeInfo(employees[1]);
            Console.WriteLine();

            employees[2] = new ClassEmployee("James", 1401702, "Marketing", 25000);
            employees[2].PrintEmployeeInfo(employees[2]);

            Console.ReadKey();
        }
    }
}
