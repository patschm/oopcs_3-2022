using LampenFabriek;


namespace Overerven
{
    public class TL : Lamp
    {
        public int StartCount { get; set; } = 3;
   
        public override void Aan()
        {
            for(int i = 0; i < StartCount; i++)
            {
                Console.BackgroundColor = Kleur;
                Console.WriteLine("knipper");
                Task.Delay(200).Wait();
                Console.ResetColor();
            }
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De TL brandt met {Lumen} lumen");
        }
        
    }
}
