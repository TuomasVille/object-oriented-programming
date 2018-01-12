using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class ClassBook
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public ClassBook()
        {
            Title = "Unknown";
            Author = "Unknown";
            Id = 0;
            Price = 0;
        }

        public ClassBook(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            this.Id = id;
            this.Price = price;
        }

        //Methods
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan Nimi: {Title}\n" +
                              $"Kirjoittajan nimi: {Author}\n" +
                              $"Id: {Id}\n" +
                              $"Hinta: {Price:C}");
        }

        public string CompareBook(ClassBook book)
        {
            if(this.Price > book.Price)
            {
                return $"{this.Title} on kalliimpi kuin {book.Title} kirja";
            }
            else
            {
                return $"{this.Title} on halvempi kuin {book.Title} kirja";
            }
        }
    }
}
