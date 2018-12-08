using System;

namespace LoopTask4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo 13 kohteen vakioveikkauksen tuloksen");
            int counter = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Double number = 0;
            for (int r = 1; r <= 13; r++)

            {
                number = rnd.NextDouble();
                if (number <= 0.4)
                {
                    Console.WriteLine("{0}: 1", r);
                }
                else if (number <= 0.6)
                {
                    Console.WriteLine("{0}: X", r);
                }
                else
                {
                    Console.WriteLine("{0}: 2", r);
                }
            }
        }
    }
}

