using System;


namespace FishCommunity

{
        public class GenusSalmon:IGenus // Род Лососевые 
        {
        public string View; //вид

        public string Community; //сообщество

        public GenusSalmon() { }

        protected GenusSalmon(string view, string community)
        {
            
            View = view;

            Community = community;

        }
        public virtual void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"вид {View}" +
                $"сообщество{Community}");
           
        }
        
    }
}
        


