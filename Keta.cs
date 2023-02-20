using System;

namespace FishCommunity
{
    class Keta : KetaCommunity  // Кета
    {
        
        public Keta(string view, string community) : base(view, community)
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

