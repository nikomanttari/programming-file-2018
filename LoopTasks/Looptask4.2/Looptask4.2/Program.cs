using System;

namespace Looptask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9.");
            Console.WriteLine("Syötä luku");
            int number = int.Parse(Console.ReadLine());
            
                for (int i = 1; i < 10; i++)

                {
                    Console.WriteLine($"   {number} * {i} = {number *i} ");
                }
                        
            

        }
    }
}
