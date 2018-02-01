using System;
using TaskLiterature.TaskBookWriter;

namespace TaskBookWriter
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                ClassBook book = new ClassBook("Vapauden risti", "Ilkka Remes", "WSOY", 22.90, "Fiction");
                book.GetBook("Vapauden risti");
                ClassBook.ChangeTheme("New Theme: Thriller");
                Console.WriteLine(ClassBook.ThemeName);
                Console.WriteLine();

                ClassBook book2 = new ClassBook("Kiirastuli", "Ilkka Remes", "WSOY", 16.90, "Thriller");
                book2.GetBook("Bob");
                Console.WriteLine();

                ClassBook book3 = new ClassBook("Jäätyvä helvetti", "Ilkka Remes", "WSOY", 28.60, "Thriller");
                book3.GetBook("Jäätyvä helvetti");
                Console.WriteLine($"New price: {book3.NewPrice = 34.60:C}");
                Console.WriteLine($"Discounted price: {book3.NewPrice:C}");
                Console.WriteLine();

                ClassBook book4 = new ClassBook("Pääkallokehrääjä", "Ilkka Remes", "WSOY", 7.90, "Thriller");
                Console.WriteLine(book4.WriterValue);
                Console.WriteLine();

                ClassWriter writer = new ClassWriter("Ilkka Remes", "13.12.1962", book2);
                writer.PrintWriterInfo();

                Console.ReadKey();
            }
        }
    }
