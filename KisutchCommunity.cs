using System;

namespace FishCommunity
{
    class KisutchCommunity : GenusSalmon// Сообщество Кижуч 
    {
        public KisutchCommunity(string view, string community) : base(view, community)
        {
        }

        public override void Info()
        {
            Console.WriteLine("KisutchCommunity");
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}");
            Console.ReadLine();
        }

    }
}

