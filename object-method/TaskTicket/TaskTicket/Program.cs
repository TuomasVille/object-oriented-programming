using System;

namespace TaskTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClassTicket ticket = new ClassTicket();
            ticket.AskData();
            ticket.ShowPrice(ticket);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
