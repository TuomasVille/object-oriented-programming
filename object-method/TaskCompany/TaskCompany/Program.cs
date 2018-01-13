using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassCompany company = new ClassCompany();
            company.AskData();
            Console.WriteLine();
            company.ShowCompanyInfo();
            company.Profit(company);
            Console.WriteLine();

            ClassCompany company2 = new ClassCompany();
            company2.AskData();
            Console.WriteLine();
            company2.ShowCompanyInfo();
            company2.Profit(company2);
            Console.WriteLine();

            ClassCompany company3 = new ClassCompany();
            company3.AskData();
            Console.WriteLine();
            company3.ShowCompanyInfo();
            company3.Profit(company3);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
