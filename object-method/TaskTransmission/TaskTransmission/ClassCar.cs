using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTransmission
{
    class ClassCar : ClassTransportation
    {
        //Fields
        protected double Motor;
        protected string Model;
        protected int Doors;

        //Constructor
        public ClassCar(string type, string brand, int year, double price, double motor, string model, int doors) : base(type, brand, year, price)
        {
            Motor = motor;
            Model = model;
            Doors = doors;
        }

        public ClassCar(string type, string brand, int year, double price) : base(type, brand, year, price)
        {
        }

        //Methods
        public override void PrintInfo()
        {  
            Console.WriteLine($"Type: {Type}\n" +
                              $"Brand: {Brand}\n" +
                              $"Year: {Year}\n" +
                              $"Price: {Price:C}\n" +
                              $"Motor: {Motor}\n" +
                              $"Model: {Model}\n" +
                              $"Doors: {Doors}");
        }

        public override string ToString()
        {
            return ($"Motor: {Motor}\n" +
                    $"Model: {Model}\n" +
                    $"Doors: {Doors}");
        }

        public override bool Equals(object obj)
        {
            ClassCar ClassCarObj = obj as ClassCar;
            if (ClassCarObj == null)
            {
                return false;
            }
            else
            {
                return Model.Equals(ClassCarObj.Model);
            }                                       
        }
    }
}
