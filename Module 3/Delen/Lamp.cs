using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delen
{
    public partial class Lamp
    {
         public  void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp brandt met {Lumen} lumen");
            DoeIets();
        }
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        partial void DoeIets()
        {
            Console.WriteLine("Doe Iets");
        }
        public Lamp(ConsoleColor col, int intens = 100)
        {
            Lumen = intens;
            this.Kleur = col;
        }
        public Lamp() : this(ConsoleColor.Blue, 200)
        { }
    }
}
