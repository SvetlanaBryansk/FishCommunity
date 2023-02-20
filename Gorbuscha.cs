using System;

namespace FishCommunity
{
    class Gorbuscha :GorbuschaCommunity// Горбуша
    {
        
        public Gorbuscha(string view, string community) : base(view, community)
        {
            view = "Gorbuscha";
            community = "GorbuschaCommunity";

        }
        public override void Info()
        {
           
            Console.WriteLine("Gorbuscha");
          
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}");
            
        }
    }
}
