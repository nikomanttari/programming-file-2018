using System;

namespace LoopTask_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo kolikonheiton tuloksen");
            Console.WriteLine("Kuinka monta kertaa kolikkoa heitetään");

            int counter = int.Parse(Console.ReadLine());
            int kruuna = 0;
            int klaava = 0;
            Random rnd = new Random();

            for (int i = 0; i < counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    kruuna++;
                else
                    klaava++;
            }
            Console.WriteLine($"Rahaa on heitetty {counter} kertaa");
            Console.WriteLine($"Kruunuja tuli {kruuna} ja klaavoja {klaava}");
        }
    }
}
