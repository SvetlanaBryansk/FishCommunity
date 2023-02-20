using System;

namespace FishCommunity
{
    class KetaCommunity : GenusSalmon// Сообщество Кета
    {

        public KetaCommunity(string view, string community) : base(view, community)
        {

        }

        public override void Info()
        {
            Console.WriteLine("KetaCommunity");
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}" );
            Console.ReadLine();
        }
    }
}
