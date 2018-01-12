using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassBook book = new ClassBook("Vapauden risti", "Ilkka Remes", 270154, 22.90);
            book.PrintBookInfo();
            Console.WriteLine();
            
            ClassBook newbook = new ClassBook("Kiirastuli", "Ilkka Remes", 170265, 16.90);
            newbook.PrintBookInfo();
            Console.WriteLine();

            Console.WriteLine($"{book.CompareBook(newbook)}");  
            Console.ReadKey();
        }
    }
}
