using System;

namespace TaskTransmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassTransportation car = new ClassCar("Sedan", "Audi", 2018, 60000);
            car.PrintInfo();
            Console.WriteLine();

            ClassCar car2 = new ClassCar("Sedan", "Ferrari", 2017, 200000, 4.2, "F430", 2);
            car2.PrintInfo();
            Console.WriteLine();

            ClassCar car3 = new ClassCar("Sedan", "BMW", 2017, 45000, 2.2, "M3", 4);
            Console.WriteLine(car3.ToString());
            Console.WriteLine();

            ClassCar car4 = new ClassCar("Sedan", "Aston Martin", 2017, 250000, 2.4, "DB", 2);
            Console.WriteLine(car4.Equals(car4));
            Console.WriteLine(car4.Equals(car3));
            Console.WriteLine();

            ClassTruck truck = new ClassTruck("Lorry", "Mercedes-Benz", 2017, 300000, 7.7, "Actros", 2, 30000, 0.025);
            truck.PrintInfo();
            Console.WriteLine($"Consumption: {truck.CountConsumption()} l/100km");

            Console.ReadKey();
        }
    }
}
