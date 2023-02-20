using System;

namespace FishCommunity
{
    class Kisutch: KisutchCommunity   // Кижуч
    {
       
        public Kisutch(string view, string community) : base(view, community)
        {

        }
        public override void Info()
        {
            Console.WriteLine("Gorbuscha");
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}" );
            Console.ReadLine();
        }
    }
}



