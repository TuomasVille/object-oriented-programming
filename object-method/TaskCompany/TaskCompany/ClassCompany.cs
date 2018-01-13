using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class ClassCompany
    {
        //Fields
        public string Title;
        public string Address;
        public int Phone;
        private double _outcome;
        private double _expense;

        //Constructor
        public ClassCompany()
        {
            Title = "Unknown";
            Address = "Unknown";
            Phone = 0;
            _outcome = 0;
            _expense = 0;
        }

        public ClassCompany(string title, string address, int phone, double outcome, double expense)
        {
            Title = title;
            Address = address;
            this.Phone = phone;
            this._outcome = outcome;
            this._expense = expense;
        }
        
        //Copy constructor
        public ClassCompany(ClassCompany previousClassCompany)
        {
            Title = previousClassCompany.Title;
            Address = previousClassCompany.Address;
            this.Phone = previousClassCompany.Phone;
            this._outcome = previousClassCompany._outcome;
            this._expense = previousClassCompany._expense;
        }

        //Methods
        public void AskData()
        {
            Console.WriteLine("Syötä yrityksen nimi: ");
            Title = Console.ReadLine();

            Console.WriteLine("Syötä osoite: ");
            Address = Console.ReadLine();

            Console.WriteLine("Syötä puhelinnumero: ");
            Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä tulot: ");
            _outcome = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä menot: ");
            _expense = int.Parse(Console.ReadLine());
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {Title}\n" +
                              $"Osoite: {Address}\n" +
                              $"Puh. {Phone.ToString($"0## #### ###")}\n" +
                              $"Tulot: {_outcome:C}\n" +
                              $"Menot: {_expense:C}\n");
        }

        public void Profit(ClassCompany previousClassCompany)
        {
            double profit = (previousClassCompany._outcome - previousClassCompany._expense)/ previousClassCompany._expense * 100;

            if(profit < 100 )
            {
                Console.WriteLine($"Yrityksellä {previousClassCompany.Title} menee heikosti. Voitto on alle 100% suurempi kuin menot!");
            }
            else if(profit >= 100 && profit <= 300)
            {
                Console.WriteLine($"Yrityksellä {previousClassCompany.Title} menee tyydyttävästi. Voitto on 100% tai yli, mutta alle 300% suurempi kuin menot!");
            }
            else
            {
                Console.WriteLine($"Yrityksellä {previousClassCompany.Title} menee loistavasti. Voitto on yli 300% suurempi kuin menot!");
            }
        }      
    }
}
