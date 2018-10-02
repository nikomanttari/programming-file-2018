using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee numerot nousevaan järjestykseen");
            Console.Write("Syötä 1. numero: ");
            string userInput = Console.ReadLine();
            int a = int.Parse(userInput);
            Console.Write("Syötä 2. numero: ");
            userInput = Console.ReadLine();
            int b = int.Parse(userInput);
            Console.Write("Syötä 3. numero: ");
            userInput = Console.ReadLine();
            int c = int.Parse(userInput);
            
            if (a > c)
            {
                if (b > c)
                    Console.Write($"{c}, {b} ja {a} ");
                else
                {
                    if (c > a)
                        Console.Write($"{b}, {a} ja {c} ");
                    else
                        Console.Write($"{b}, {c} ja {a} ");
                }
            }
            else
            {
                if (a > c)
                    Console.Write($"{c}, {a} ja {b} ");
                else
                {
                    if (b > c)
                        Console.Write($"{a}, {c} ja {b} ");
                    else
                        Console.Write($"{a}, {b} ja {c} ");

                }
            }


        }
    }
}
