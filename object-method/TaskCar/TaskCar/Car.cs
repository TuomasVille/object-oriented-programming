using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Fields
        public string Brand;
        public double Speed;

        //Constructor
        public Car()
        {
            Brand = "Unknown";
            Speed = 0;
        }

        public Car(string brand, int speed)
        {
            Brand = brand;
            this.Speed = speed;
        }

        //Methods

        public void AskData()
        {
            Console.WriteLine($"Syötä auton merkki: ");
            Brand = Console.ReadLine();
            Console.WriteLine("Syötä auton nopeus: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Merkki: {Brand}\n" +
                              $"Nopeus: {Speed} km/h");                   
        }
        
        public void Accelerate()
        {
            Console.WriteLine("Lisää nopeutta xx km/h");
            int speed = int.Parse(Console.ReadLine());

            if(speed < 0)
            {
                Console.WriteLine("Negatiivinen muutos ei ole sallittu");       
            }
            else
            {
                Console.WriteLine("Uusi nopeus:");
                Speed += speed;
            }         
        }

        public void Brake()
        {
            Console.WriteLine("Uusi nopeus:");
            Speed = Speed - Speed * 0.1;
        }
    }
}
