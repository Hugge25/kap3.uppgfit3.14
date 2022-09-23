using System;

namespace uppgfit
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Har du gått ut gymnasiet? Svara ja eller nej");
            string skola = Console.ReadLine();

            if (ålder <= 22 && skola == "ja")
            {
                Console.WriteLine("Du är anställd");
            }

            else
            {
                Console.WriteLine("Du är inte anställd");
            }
        }
    }
}