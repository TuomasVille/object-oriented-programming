using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicket
{
    class ClassTicket
    {
        //Fields
        public int Age;
        public int Price;
        public float Discount;

        //Constructor
        public ClassTicket()
        {
            Age = 0;
            Price = 16;
            Discount = 0.0f;
        }

        public ClassTicket(int age, int price, float discount)
        {
            this.Age = age;
            this.Price = price;
            this.Discount = discount;           
        }

        //Methods
        public void AskData()
        {
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());       
        }

        public void ShowPrice(ClassTicket ticket)
        {
            if (Age < 7)
            {
                Console.WriteLine("Price = " + Price * 0 + "€");
            }
            else if (Age >= 7 && Age <= 15)
            {
                Console.WriteLine("Price = " + Price * 0.5 + "€");
            }
            else if (Age >= 65)
            {
                Console.WriteLine("Price = " + Price * 0.5 + "€");
            }
            if (Age > 15 && Age < 65)
            {
                Console.Write("Soldier? [Y/N]: ");
                if (Console.ReadLine().ToUpper() == "Y")
                    Console.WriteLine("Price = " + Price * 0.5 + "€");

                else
                {
                    Console.Write("Mtk member? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        Discount = 0.15f;
                    }
                    Console.Write("Student? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        Discount = Discount + 0.45f;
                    }
                    Console.WriteLine($"Price = {Price - Price * Discount}€");
                }
            }
        }
    }
}
            