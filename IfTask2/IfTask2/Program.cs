﻿using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma selvittää onko luku pariton vai parillinen");
            Console.Write("syötä numero: ");
            string userInput = Console.ReadLine();
            int number =  0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            { 
            if (number % 2 == 0)
                Console.WriteLine($"Luku {number} on parillinen");
            else
                Console.WriteLine($"luku {number} on pariton.");
            }
         else
        Console.WriteLine("väärä syöte! ");

              
        }
    }
}
