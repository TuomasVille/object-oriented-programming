using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTransmission
{
    abstract class ClassTransportation
    {
        //Fields
        protected string Type;
        protected string Brand;
        protected int Year;
        protected double Price;

        //Constructor
        public ClassTransportation(string type, string brand, int year, double price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        //Methods
        abstract public void PrintInfo();
    }
}
