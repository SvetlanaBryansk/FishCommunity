using System;

namespace FishCommunity
{
    class GorbuschaCommunity : GenusSalmon// Сообщество Горбуша
    {

        public GorbuschaCommunity(string view, string community) : base(view, community)
        {
            view = "Gorbuscha";
            community = "GorbuschaCommunity";
           
        }

        public override void Info()
        {
            Console.WriteLine("GorbuschaCommunity");
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}");
           
        }
    }
}

