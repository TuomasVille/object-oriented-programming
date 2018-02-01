using System;
using System.Collections.Generic;
using System.Text;
using TaskLiterature.TaskBookWriter;

namespace TaskBookWriter
{
    class ClassWriter
    {
        //Fields
        public string Name;
        public string Birthday;
        ClassBook Book;

        //Constructor
        public ClassWriter(string name, string birthday, ClassBook book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }

        //Methods
        public void PrintWriterInfo()
        {
            Console.WriteLine($"Writer name: {Name}\n" +
                              $"Birthday: {Birthday}");
            Book.GetBook("Kiirastuli");
        }
    }
}
