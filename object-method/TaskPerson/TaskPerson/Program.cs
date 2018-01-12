using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person personTuomas = new Person();
            Console.WriteLine($"Tuomaksen ikä: {personTuomas.GetAge()}");
            
            personTuomas.Name = "Tuomas";
            personTuomas.GrowOld();
            personTuomas.GrowOld(20);
            personTuomas.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();
        }
    }
}
