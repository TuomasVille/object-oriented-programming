using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTransmission
{
    class ClassTruck : ClassCar
    {
        //Fields
        protected double LoadWeight;
        protected double ConsumptionPerKg;

        //Constructor
        public ClassTruck(string type, string brand, int year, double price, double motor, string model, int doors, double loadweight, double consumptionperkg) : base(type, brand, year, price, motor, model, doors)
        {
            LoadWeight = loadweight;
            ConsumptionPerKg = consumptionperkg;
        }

        //Methods
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"LoadWeight: {LoadWeight}\n" +
                              $"ConsumptionPerKg: {ConsumptionPerKg}");
        }

        public double CountConsumption()
        {
            double Consumption = (LoadWeight / ConsumptionPerKg) / LoadWeight;
            return Consumption;
        }
    }
}
