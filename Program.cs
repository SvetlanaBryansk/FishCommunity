using System;

namespace FishCommunity
{
    class Program
    {
        static void Main(string[] args)
        {
   
            GenusSalmon genusSalmon = new GenusSalmon();
           string view = Console.ReadLine();
           
            string community = Console.ReadLine();
            Console.WriteLine($"{view}" + $"{community}");

            Console.WriteLine("Горбуша", "Сообщество вида Горбуша");

            Console.ReadKey();
            static void DisplayInfo()
            {
                Console.WriteLine("Кижуч", "Сообщество вида Кижуч");
                Console.WriteLine("Кета", "Сообщество вида Кета");
               // Console.WriteLine("Горбуша", "Сообщество вида Горбуша" );
               
            }
        }
    }   
}