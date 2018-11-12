using System;

namespace LoopTask3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisen numeron parittoman ja parillisen luvun summan myös negatiivisilla numeroilla.");

            int number = 0;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                Console.WriteLine("Syötä luku");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("Väärä syöte!");
                        


            }
            while (number == 0);
            if (number > 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += i;
                    }
                    else
                    {
                        oddSum += i;
                    }
                }
            }
            else


            {

                for (int i = 0; i >= number; i--)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += i;
                    }
                    else
                    {
                        oddSum += i;
                    }
                }
            }
            Console.WriteLine($"Luvun {number} parittomien summa on {oddSum}");
            Console.WriteLine($"Luvun {number} parillisten summa on {evenSum}");

        }
    }
}

        
    

