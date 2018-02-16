using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class ClassProduct : IProduct
    {
        //Fields
        public string Name;
        public double UnitPrice;
        public int Amount;

        //Constructors
        public ClassProduct(string name, double unitprice, int amount)
        {
            Name = name;
            UnitPrice = unitprice;
            Amount = amount;
        }

        public override string ToString()
        {
            return ($"Name: {Name}\n" +
                    $"Unit Price: {UnitPrice:C}\n" +
                    $"Amount: {Amount}");
        }

        //Methods
        public void GetProduct()
        {
            string NewName = Name;
            if(Name == NewName)
            {
                Console.WriteLine($"Name: {Name}\n" +
                                  $"Unit Price: {UnitPrice:C}\n" +
                                  $"Amount: {Amount}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }

        public void CountTotalPrice()
        {
            Console.WriteLine($"Total Price: {UnitPrice * Amount:C}");
        }
    }
}
