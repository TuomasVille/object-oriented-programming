using System;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car car = new Car();
            car.AskData();
            car.ShowCarInfo();
            car.Accelerate();
            car.ShowCarInfo();
            Console.WriteLine();

            Car car2 = new Car();
            car.AskData();
            car.ShowCarInfo();
            car.Brake();
            car.ShowCarInfo();

            Console.ReadKey();
        }
    }
}
