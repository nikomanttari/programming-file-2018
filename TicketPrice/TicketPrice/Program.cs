using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää maatalousnäyttelyn lipun hinnan");
            int ticketPrice = 16;
            double discount = 0.15; //15% ale MTK



            Console.WriteLine($"Lipun hinta on {ticketPrice * discount}");
        }
    }
}
