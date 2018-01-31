using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBookWriter
{
    class ClassBook
    {
        //Fields
        public string Name;
        public readonly string Writer;
        public string Publisher;
        public static string ThemeName;
        private double _price;

        //Constructor
        public ClassBook()
        {
            Name = "Unknown";
            Writer = "Unknown";
            Publisher = "Unknown";
            _price = 0;
            ThemeName = "Unknown";
        }

        public ClassBook(string name, string writer, string publisher, double price, string themename)
        {
            Name = name;
            Writer = writer;
            Publisher = publisher;
            NewPrice = price;
            ThemeName = themename;
        }

        //Methods
        public void GetBook(string name)
        {
            if (Name.Equals(name))
            {
                Console.WriteLine($"Name: {Name}\n" +
                                  $"Writer: {Writer}\n" +
                                  $"Publisher: {Publisher}\n" +
                                  $"Price: {_price:C}\n" +
                                  $"Theme: {ThemeName}");
            }
            else
            {
                Console.WriteLine($"The book {Name} wasn´t found.");
            }
        }

        public static void ChangeTheme(string Theme)
        {
            ThemeName = Theme;
        }

        public double NewPrice
        {
            get
            {
                return _price;
            }

            set
            {
                if (value > 30)
                {
                    _price = value - (value * 0.1);
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string WriterValue
        {
            get
            {
                return Writer;
            }
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Book name: {Name}\n" +
                              $"Publisher: {Publisher}\n" +
                              $"Price: {_price:C}\n" +
                              $"Theme: {ThemeName}");
        }
            
    }
}
